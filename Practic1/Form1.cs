using System.Text;
using System.Text.RegularExpressions;

namespace Practic1;

public partial class Form1 : Form {
	#region Base

	private static readonly Regex EmailRegex = new(
		@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
		+ @"([-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+(?:\.[-a-zA-Z0-9!#$%&'*+/=?^_`{|}~]+)*)"
		+ @")@((?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z]{2,})$",
		RegexOptions.Compiled | RegexOptions.IgnoreCase);

	public Form1() {
		InitializeComponent();

		#region Task1

		var price = 150;
		foreach (var keyValuePair in Furniture) {
			DeliveryPrice.Add(keyValuePair.Key, price);
			price += 150;

			ItemSelector.Items.Add(keyValuePair.Value);
		}

		foreach (var keyValuePair in ElevatorTypes)
			ElevatorTypeBox.Items.Add(keyValuePair.Key);

		ItemSelector.SelectedIndex = 0;
		ElevatorTypeBox.SelectedIndex = 0;
		DeliveryPriceBox.Enabled = false;
		ElevatorTypeBox.Enabled = false;
		IsElevatorBox.Checked = false;

		#endregion
	}

	private Dictionary<Guid, string> Furniture { get; } = new() {
		{ Guid.NewGuid(), "������" },
		{ Guid.NewGuid(), "�����" },
		{ Guid.NewGuid(), "���" },
		{ Guid.NewGuid(), "����" },
		{ Guid.NewGuid(), "˳���" }
	};

	private Dictionary<string, long> ElevatorTypes { get; } = new() {
		{ "���������", 5 },
		{ "���������", 10 }
	};

	private Dictionary<Guid, decimal> DeliveryPrice { get; } = new();

	#endregion

	#region Helpers

	private Guid Get(string name) {
		try {
			if (!Furniture.Values.Contains(name))
				return Guid.Empty;

			var item = Furniture.FirstOrDefault(pair => pair.Value == name);
			return item.Key;
		}
		catch (Exception e) {
			return Guid.Empty;
		}
	}

	private bool Validation(out string errors) {
		errors = string.Empty;
		var builder = new StringBuilder();
		var isValid = true;

		if (string.IsNullOrWhiteSpace(FirstNameBox.Text)) {
			builder.AppendLine("�������. ���� \"��'�\" �� ���� ���� ������");
			isValid = false;
		}

		if (string.IsNullOrWhiteSpace(LastNameBox.Text)) {
			builder.AppendLine("�������. ���� \"�������\" �� ���� ���� ������");
			isValid = false;
		}

		if (DateBirthPicker.Value >= DateTime.Today) {
			builder.AppendLine(
				"�������. \"���� ����������\" �� ���� ���� ���������� ����, ��� ���� �������� �������� ������");
			isValid = false;
		}
		else {
			if (DateTime.Today - DateBirthPicker.Value < TimeSpan.FromDays(6570)) {
				builder.AppendLine("�������. ��� ���� 18 ����");
				isValid = false;
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
		}

		errors = builder.ToString();

		return isValid;
	}

	#endregion

	#region UI Interactive

	private void ItemSelector_SelectedIndexChanged(object sender, EventArgs e) {
		var key = Get(ItemSelector.Text);
		var isExist = DeliveryPrice.TryGetValue(key, out var selectedPrice);
		DeliveryPriceBox.Value = isExist ? selectedPrice : 100;
		IsCustomDeliveryPrice.Checked = false;
	}

	private void IsElevatorBox_CheckedChanged(object sender, EventArgs e) {
		ElevatorTypeBox.Enabled = IsElevatorBox.Checked;
	}

	private void IsCustomDeliveryPrice_CheckedChanged(object sender, EventArgs e) {
		DeliveryPriceBox.Enabled = IsCustomDeliveryPrice.Checked;
	}

	private void DeliveryPriceBox_ValueChanged(object sender, EventArgs e) {
		if (!IsCustomDeliveryPrice.Checked)
			return;

		var numericUpDown = sender as NumericUpDown;
		var key = Get(ItemSelector.Text);

		if (numericUpDown != null)
			DeliveryPrice[key] = numericUpDown.Value;
	}

	private void ClearButton_Click(object sender, EventArgs e) {
		ResultBox.Clear();
	}

	private void CalculateButton_Click(object sender, EventArgs e) {
		var builder = new StringBuilder();

		var distance = DistanceBox.Value / 5;
		var price = DeliveryPriceBox.Value;

		long discount;
		long additionalPayment = 0;
		decimal discountPrice = 0;

		var isElevator = IsElevatorBox.Checked;
		if (isElevator) {
			var hasElevator = ElevatorTypes.TryGetValue(ElevatorTypeBox.Text, out var elevatorDiscount);
			discount = hasElevator ? elevatorDiscount : 0;
		}
		else {
			discount = 0;
			var level = StageLevel.Value;
			additionalPayment = level < 2 ? 0 : (long)((level - 1) * 5);
		}

		var result = distance * price;
		if (isElevator) {
			var level = StageLevel.Value;
			discountPrice = level >= 2 ? result * discount / 100 : 0;
			result -= discountPrice;
		}
		else {
			result += additionalPayment;
		}

		builder.AppendLine($"������ ���� �� ������: {price} ���.");
		builder.AppendLine($"³������: {DistanceBox.Value} ��.");
		builder.AppendLine($"���������� ������ � ����: {distance}. ������� 5 �� = 1 ������.");
		builder.AppendLine($"ֳ�� ��������: {distance * price} ���.");
		if (isElevator) {
			if (StageLevel.Value >= 2) {
				builder.AppendLine(
					$"\r\n������� ������� ��� \"{ElevatorTypeBox.Text}\", ������ ������ �: {discount}%");
				builder.AppendLine($"���� ������: {discountPrice} ���.");
			}
		}
		else {
			if (StageLevel.Value >= 2) {
				builder.AppendLine(
					"\r\n������� ��� ������� �� �� �������, �� �� ����� ������ + 5 ��� ��������� � �������");
				builder.AppendLine($"���� ��������: {additionalPayment} ���.");
			}
		}

		builder.AppendLine($"\r\n���� �� ������: {result} ���.");

		ResultBox.Text = builder.ToString();
	}

	private void ClearRegisterButton_Click(object sender, EventArgs e) {
		FirstNameBox.Clear();
		LastNameBox.Clear();
		EmailBox.Clear();
		RegisterResultBox.Clear();
		DateBirthPicker.Value = DateTime.Now;
	}

	private void RegisterButton_Click(object sender, EventArgs e) {
		var isValid = Validation(out var errors);
		RegisterResultBox.Text = isValid
			? "��������� �������� ������"
			: errors;
	}

	#endregion
}