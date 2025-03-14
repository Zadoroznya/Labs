using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Practic4;

public partial class Form1 : Form {
	private static readonly Regex EmailRegex = new(
		@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
		+ @"([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+)*)"
		+ @")@((?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z]{2,})$",
		RegexOptions.Compiled | RegexOptions.IgnoreCase);

	public Form1() {
		InitializeComponent();

		Task3ResultBox.Text = "ͳ���� �� �������";
	}

	#region Task #1

	private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e) {
		// ���������� �����, Backspace, �����, �����, ����� � "+"
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
									   && e.KeyChar != '(' && e.KeyChar != ')'
									   && e.KeyChar != '-' && e.KeyChar != ' '
									   && e.KeyChar != '+')
			e.Handled = true;
	}

	private void AddSkillButton_Click(object sender, EventArgs e) {
		if (!SkillBox.Items.Contains(AddSkillBox.Text))
			SkillBox.Items.Add(AddSkillBox.Text);
		AddSkillBox.Clear();
	}

	private void DeleteSkinButton_Click(object sender, EventArgs e) {
		if (SkillBox.SelectedIndex < 0) {
			MessageBox.Show("�� ������� �������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		SkillBox.Items.Remove(SkillBox.Items[SkillBox.SelectedIndex]);
	}

	private void GenerateResumeButton_Click(object sender, EventArgs e) {
		var builder = new StringBuilder();
		var hasError = false;

		if (string.IsNullOrWhiteSpace(LastNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"�������\" �� ���� ���� ������");
		}

		if (string.IsNullOrWhiteSpace(FirstNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"��'�\" �� ���� ���� ������");
		}

		if (string.IsNullOrWhiteSpace(MiddleNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"��-�������\" �� ���� ���� ������");
		}

		if (!PhoneBox.MaskFull) {
			hasError = true;
			builder.AppendLine("\"�������\" �� ���� ���� ������");
		}

		var email = EmailBox.Text;
		if (string.IsNullOrWhiteSpace(email)) {
			hasError = true;
			builder.AppendLine("\"Email\" �� ���� ���� ������");
		}
		else if (!EmailRegex.IsMatch(email)) {
			hasError = true;
			builder.AppendLine("�������, ���� \"Email\" �� ������� ������� Email");
		}

		if (SkillBox.Items.Count <= 0) {
			hasError = true;
			builder.AppendLine("�� ������� ����� �������");
		}

		if (hasError) {
			ResumeBox.Text = builder.ToString();
			return;
		}

		var fullName = $"{LastNameBox.Text} {FirstNameBox.Text} {MiddleNameBox.Text}";

		builder.AppendLine($"���� ����� {fullName}.");

		var contactData = string.Empty;
		contactData += $"\r\n - �������: {PhoneBox.Text}";
		contactData += $"\r\n - Email: {EmailBox.Text}";

		builder.AppendLine($"�� �������� ���:{contactData}");
		builder.AppendLine("�� �������:");
		foreach (var skill in SkillBox.Items)
			builder.AppendLine($" - {skill}");

		ResumeBox.Text = builder.ToString();
	}

	#endregion

	#region Task #2

	private void MonthBox_SelectedIndexChanged(object sender, EventArgs e) {
		DateBox.Maximum = sender is ComboBox { SelectedIndex: 1 } ? 29 : 31;
	}

	private void ClearRegisterButton_Click(object sender, EventArgs e) {
		FirstNameRegisterBox.Clear();
		LastNameRegisterBox.Clear();
		RegisterResultBox.Clear();
		EmailRegisterBox.Clear();

		YearBox.Value = 1980;
		MonthBox.SelectedIndex = -1;
		DateBox.Value = 1;
		CityBirthBox.SelectedIndex = -1;
	}

	private void RegisterButton_Click(object sender, EventArgs e) {
		var isValid = Validation(out var messages);
		RegisterResultBox.Text = isValid
			? $"{messages}��������� �������� ������"
			: messages;
	}

	private DateTime? GetDate(bool isFix) {
		try {
			var year = YearBox.Value;
			var month = MonthBox.SelectedIndex + 1;
			var selectedDate = isFix
				? DateBox.Value - 1
				: DateBox.Value;

			return new DateTime((int)year, month, (int)selectedDate);
		}
		catch (Exception) {
			return null;
		}
	}

	private bool Validation(out string messages) {
		messages = string.Empty;
		var builder = new StringBuilder();
		var isValid = true;

		if (string.IsNullOrWhiteSpace(FirstNameRegisterBox.Text)) {
			builder.AppendLine("�������. ���� \"��'�\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			builder.AppendLine($"��'�: {FirstNameRegisterBox.Text}");
		}

		if (string.IsNullOrWhiteSpace(LastNameRegisterBox.Text)) {
			builder.AppendLine("�������. ���� \"�������\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			builder.AppendLine($"�������: {LastNameRegisterBox.Text}");
		}

		if (MonthBox.SelectedIndex < 0) {
			builder.AppendLine("�������. ���� \"̳���� ����������\" �� ���� ���� ������");
			isValid = false;
		}

		if (!isValid) {
			messages = builder.ToString();
			return isValid;
		}

		var date = GetDate(false);
		if (!date.HasValue) {
			var monthNumber = MonthBox.SelectedIndex + 1;
			var monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber);

			if (monthNumber == 2)
				builder.AppendLine($"� ����� \"{monthName}\" 28 ���, �� �������� �� �� � ����������");
			else
				builder.AppendLine($"� ����� \"{monthName}\" 30 ���");

			date = GetDate(true);
			builder.AppendLine($"����������� ���������� �� {date?.ToLongDateString()}");
			isValid = false;
		}

		if (date >= DateTime.Today) {
			builder.AppendLine(
				"�������. \"���� ����������\" �� ���� ���� ���������� ����, ��� ���� �������� �������� ������");
			isValid = false;
		}
		else {
			if (DateTime.Today - date < TimeSpan.FromDays(6570)) {
				builder.AppendLine("�������. ��� ���� 18 ����");
				isValid = false;
			}
			else {
				builder.AppendLine($"������� ����: {date?.ToLongDateString()}");
			}
		}

		if (string.IsNullOrWhiteSpace(EmailRegisterBox.Text)) {
			builder.AppendLine("�������. ���� \"Email\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			if (!EmailRegex.IsMatch(EmailRegisterBox.Text)) {
				builder.AppendLine("�������. ���� \"Email\" �� ������ �������� ���������� �����");
				isValid = false;
			}
			else {
				builder.AppendLine($"Email: {EmailRegisterBox.Text}");
			}
		}

		if (CityBirthBox.SelectedIndex < 0) {
			builder.AppendLine("�������. ���� \"̳��� ����������\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			builder.AppendLine($"̳��� ����������: {CityBirthBox.Text}");
		}

		messages = builder.ToString();

		return isValid;
	}

	#endregion

	#region Task #3

	private void EducationBox_ItemCheck(object sender, ItemCheckEventArgs e) {
		if (sender is not CheckedListBox checkedListBox)
			return;

		var itemText = checkedListBox.Items[e.Index].ToString();
		var isChecked = e.NewValue == CheckState.Checked;

		var checkedItems = checkedListBox.CheckedItems.Cast<object>().Select(item => item.ToString()).ToList();
		if (isChecked)
			checkedItems.Add(itemText);
		else
			checkedItems.Remove(itemText);

		Task3ResultBox.Clear();

		if (checkedItems.Count <= 0) {
			Task3ResultBox.Text = "ͳ���� �� �������";
			return;
		}

		var builder = new StringBuilder();
		builder.AppendLine("������ ��������:");

		foreach (var checkedItem in checkedItems)
			builder.AppendLine($" - {checkedItem}");

		Task3ResultBox.Text = builder.ToString();
	}

	#endregion
}