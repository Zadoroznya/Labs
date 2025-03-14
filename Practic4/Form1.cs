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

		Task3ResultBox.Text = "Нічого не вибрано";
	}

	#region Task #1

	private void PhoneBox_KeyPress(object sender, KeyPressEventArgs e) {
		// Дозволяємо цифри, Backspace, пробіл, дужки, дефіс і "+"
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
			MessageBox.Show("Не вибрано навичку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
		}

		SkillBox.Items.Remove(SkillBox.Items[SkillBox.SelectedIndex]);
	}

	private void GenerateResumeButton_Click(object sender, EventArgs e) {
		var builder = new StringBuilder();
		var hasError = false;

		if (string.IsNullOrWhiteSpace(LastNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"Прізвище\" не може бути пустим");
		}

		if (string.IsNullOrWhiteSpace(FirstNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"Ім'я\" не може бути пустим");
		}

		if (string.IsNullOrWhiteSpace(MiddleNameBox.Text)) {
			hasError = true;
			builder.AppendLine("\"По-батькові\" не може бути пустим");
		}

		if (!PhoneBox.MaskFull) {
			hasError = true;
			builder.AppendLine("\"Телефон\" не може бути пустим");
		}

		var email = EmailBox.Text;
		if (string.IsNullOrWhiteSpace(email)) {
			hasError = true;
			builder.AppendLine("\"Email\" не може бути пустим");
		}
		else if (!EmailRegex.IsMatch(email)) {
			hasError = true;
			builder.AppendLine("Помилка, поле \"Email\" не відповідає формату Email");
		}

		if (SkillBox.Items.Count <= 0) {
			hasError = true;
			builder.AppendLine("Не вказано жодну навичку");
		}

		if (hasError) {
			ResumeBox.Text = builder.ToString();
			return;
		}

		var fullName = $"{LastNameBox.Text} {FirstNameBox.Text} {MiddleNameBox.Text}";

		builder.AppendLine($"Мене звати {fullName}.");

		var contactData = string.Empty;
		contactData += $"\r\n - Телефон: {PhoneBox.Text}";
		contactData += $"\r\n - Email: {EmailBox.Text}";

		builder.AppendLine($"Мої контактні дані:{contactData}");
		builder.AppendLine("Мої навички:");
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
			? $"{messages}Реєстрація пройдена успішно"
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
			builder.AppendLine("Помилка. Поле \"Ім'я\" не може бути пустим");
			isValid = false;
		}
		else {
			builder.AppendLine($"Ім'я: {FirstNameRegisterBox.Text}");
		}

		if (string.IsNullOrWhiteSpace(LastNameRegisterBox.Text)) {
			builder.AppendLine("Помилка. Поле \"Прізвище\" не може бути пустим");
			isValid = false;
		}
		else {
			builder.AppendLine($"Прізвище: {LastNameRegisterBox.Text}");
		}

		if (MonthBox.SelectedIndex < 0) {
			builder.AppendLine("Помилка. Поле \"Місяць народження\" не може бути пустим");
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
				builder.AppendLine($"В місяці \"{monthName}\" 28 днів, бо вказаний рік не є високосним");
			else
				builder.AppendLine($"В місяці \"{monthName}\" 30 днів");

			date = GetDate(true);
			builder.AppendLine($"Автоматично виправлено на {date?.ToLongDateString()}");
			isValid = false;
		}

		if (date >= DateTime.Today) {
			builder.AppendLine(
				"Помилка. \"Дата народження\" не може бути сьогоднішнім днем, або мати значення майбутніх періодів");
			isValid = false;
		}
		else {
			if (DateTime.Today - date < TimeSpan.FromDays(6570)) {
				builder.AppendLine("Помилка. Вам немає 18 років");
				isValid = false;
			}
			else {
				builder.AppendLine($"Вибрано дату: {date?.ToLongDateString()}");
			}
		}

		if (string.IsNullOrWhiteSpace(EmailRegisterBox.Text)) {
			builder.AppendLine("Помилка. Поле \"Email\" не може бути пустим");
			isValid = false;
		}
		else {
			if (!EmailRegex.IsMatch(EmailRegisterBox.Text)) {
				builder.AppendLine("Помилка. Поле \"Email\" не містить значення електронної пошти");
				isValid = false;
			}
			else {
				builder.AppendLine($"Email: {EmailRegisterBox.Text}");
			}
		}

		if (CityBirthBox.SelectedIndex < 0) {
			builder.AppendLine("Помилка. Поле \"Місто народження\" не може бути пустим");
			isValid = false;
		}
		else {
			builder.AppendLine($"Місто народження: {CityBirthBox.Text}");
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
			Task3ResultBox.Text = "Нічого не вибрано";
			return;
		}

		var builder = new StringBuilder();
		builder.AppendLine("Обрано дисипліни:");

		foreach (var checkedItem in checkedItems)
			builder.AppendLine($" - {checkedItem}");

		Task3ResultBox.Text = builder.ToString();
	}

	#endregion
}