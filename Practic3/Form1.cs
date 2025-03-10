using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Practic3;

public partial class Form1 : Form {
	private static readonly Regex EmailRegex = new(
		@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
		+ @"([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+)*)"
		+ @")@((?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z]{2,})$",
		RegexOptions.Compiled | RegexOptions.IgnoreCase);

	private readonly Dictionary<string, decimal> _autos = new() {
		{ "��� / Lada 2110", 65_680 },
		{ "Audi A4 2000", 184_725 },
		{ "Volkswagen CC", 472_075 },
		{ "Mercedes-Benz A-Class", 348_925 },
		{ "Subaru Outback 2024", 2_177_580 }
	};

	private readonly Dictionary<string, decimal> _optionsPrice = new() {
		{ "ColorBox", 10_000 },
		{ "WheelBox", 5_000 },
		{ "AirGasBox", 2_500 },
		{ "EngineBox", 50_000 },
		{ "GlassBox", 1_000 },
		{ "InsideBox", 15_000 },
		{ "AutopilotBox", 7_500 }
	};

	public Form1() {
		InitializeComponent();

		foreach (var keyValuePair in _autos)
			AutoListBox.Items.Add(keyValuePair.Key);

		AutoListBox.SelectedIndex = 0;
	}

	#region Helpers

	private DateTime? GetDate(bool isFix) {
		try {
			var year = YearBox.Value;
			var month = MonthBox.Value;
			var selectedDate = isFix
				? DateBox.Value - 1
				: DateBox.Value;

			return new DateTime((int)year, (int)month, (int)selectedDate);
		}
		catch (Exception) {
			return null;
		}
	}

	private bool Validation(out string messages) {
		messages = string.Empty;
		var builder = new StringBuilder();
		var isValid = true;

		if (string.IsNullOrWhiteSpace(FirstNameBox.Text)) {
			builder.AppendLine("�������. ���� \"��'�\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			builder.AppendLine($"��'�: {FirstNameBox.Text}");
		}

		if (string.IsNullOrWhiteSpace(LastNameBox.Text)) {
			builder.AppendLine("�������. ���� \"�������\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			builder.AppendLine($"�������: {LastNameBox.Text}");
		}

		var date = GetDate(false);
		if (!date.HasValue) {
			var monthNumber = (int)MonthBox.Value;
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

		if (string.IsNullOrWhiteSpace(EmailBox.Text)) {
			builder.AppendLine("�������. ���� \"Email\" �� ���� ���� ������");
			isValid = false;
		}
		else {
			if (!EmailRegex.IsMatch(EmailBox.Text)) {
				builder.AppendLine("�������. ���� \"Email\" �� ������ �������� ���������� �����");
				isValid = false;
			}
			else {
				builder.AppendLine($"Email: {EmailBox.Text}");
			}
		}

		messages = builder.ToString();

		return isValid;
	}

	#endregion

	#region UI

	private void CalculateButton_Click(object sender, EventArgs e) {
		var selectedCount = Task2CountBox.Value;
		if (selectedCount < 1) {
			ResultBox2.Text = "ʳ������ �� �������";
			return;
		}

		var checkedButton = RadioGroupBox.Controls.OfType<RadioButton>()
			.FirstOrDefault(r => r.Checked);
		var price = checkedButton?.Name switch {
			"RadButtonType1" => 15,
			"RadButtonType2" => 25,
			"RadButtonType3" => 40,
			_ => 0
		};

		if (price == 0) {
			ResultBox2.Text = "������� �������� �����";
			return;
		}

		var result = selectedCount * price;

		var builder = new StringBuilder();
		if (selectedCount > 20) {
			builder.AppendLine($"����: {result} ���.");
			var discount = result * 10 / 100;

			builder.AppendLine($"��������� ������ � 10%, �� ��������� {discount} ���.");
			result -= discount;

			builder.AppendLine($"���� �� ������: {result} ���.");
			ResultBox2.Text = builder.ToString();
		}
		else {
			builder.AppendLine($"���� �� ������: {result} ���.");

			ResultBox2.Text = builder.ToString();
		}
	}

	private void ClearRegisterButton_Click(object sender, EventArgs e) {
		RegisterResultBox.Clear();

		FirstNameBox.Clear();
		LastNameBox.Clear();
		EmailBox.Clear();

		YearBox.Value = default;
		MonthBox.Value = default;
		DateBox.Value = default;
	}

	private void MonthBox_ValueChanged(object sender, EventArgs e) {
		DateBox.Maximum = sender is NumericUpDown { Value: 2 } ? 29 : 31;
	}

	private void RegisterButton_Click(object sender, EventArgs e) {
		var isValid = Validation(out var messages);
		RegisterResultBox.Text = isValid
			? $"{messages}��������� �������� ������"
			: messages;
	}

	private void BuyButton_Click(object sender, EventArgs e) {
		var builder = new StringBuilder();
		var carName = AutoListBox.Text;

		_autos.TryGetValue(carName, out var price);

		var selectedOptions = OptionsGroup.Controls
			.OfType<CheckBox>()
			.Where(box => box.Checked)
			.ToList();
		if (selectedOptions.Any()) {
			var options = selectedOptions.Aggregate(string.Empty, (current, checkBox) => current + $"\r\n - {checkBox.Text}");

			builder.AppendLine($"������ ��������� \"{carName}\" " +
							   $"�� {price} ������� � ������ �������:{options}");
			var result = price;

			foreach (var selectedOption in selectedOptions) {
				_optionsPrice.TryGetValue(selectedOption.Name, out var additionalPrice);
				result += additionalPrice;
			}

			builder.AppendLine($"���� �� ������: {result} �������.");
		}
		else {
			builder.AppendLine($"�������� ��������� \"{carName}\" �� {price} ������� ��� ���� ���� �����");
		}

		AutoResultBox.Text = builder.ToString();
	}

	private void AutoCancelButton_Click(object sender, EventArgs e) {
		AutoResultBox.Clear();

		ColorBox.Checked = false;
		AirGasBox.Checked = false;
		EngineBox.Checked = false;
		GlassBox.Checked = false;
		InsideBox.Checked = false;
		AutopilotBox.Checked = false;
	}

	private void AutoListBox_SelectedIndexChanged(object sender, EventArgs e) {
		var selected = sender as ComboBox;
		_autos.TryGetValue(selected?.Text!, out var price);
		AutoPrice.Text = $"{price} ���.";
	}

	#endregion
}