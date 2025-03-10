using System.Globalization;
using System.Text;

namespace Practic2;

public partial class Form1 : Form {
	private readonly Dictionary<string, decimal> _alcoholAdditionDict = new() {
		{ "Чіпси", 25 },
		{ "Риба", 45 }
	};

	private readonly Dictionary<string, decimal> _alcoholDict = new() {
		{ "Світле", 50 },
		{ "Темне", 75 }
	};

	public Form1() {
		InitializeComponent();

		foreach (var keyValuePair in _alcoholDict)
			AlcoholTypeBox.Items.Add(keyValuePair.Key);
		AlcoholTypeBox.SelectedIndex = 0;

		foreach (var keyValuePair in _alcoholAdditionDict)
			AdditionalTypeBox.Items.Add(keyValuePair.Key);
		AdditionalTypeBox.SelectedIndex = 0;
	}

	private void AdditionalTypeBox_SelectedIndexChanged(object sender, EventArgs e) {
		var isExist = _alcoholAdditionDict.TryGetValue(AdditionalTypeBox.Text, out var price);
		if (isExist)
			AdditionalPriceBox.Text = price.ToString(CultureInfo.InvariantCulture);
		else
			AdditionalPriceBox.Clear();
	}

	#region UI

	private void AlcoholTypeBox_SelectedIndexChanged(object sender, EventArgs e) {
		var isExist = _alcoholDict.TryGetValue(AlcoholTypeBox.Text, out var price);
		if (isExist)
			AlcoholPriceBox.Text = price.ToString(CultureInfo.InvariantCulture);
		else
			AlcoholPriceBox.Clear();
	}

	private void CloseButton_Click(object sender, EventArgs e) {
		Close();
	}

	private void BuyButton_Click(object sender, EventArgs e) {
		if (AlcoholCountBox.Value < 1) {
			ResultBox.Text = "Нічого не вибрано";
			return;
		}

		var count = long.Parse(AlcoholCountBox.Text);
		var price = decimal.Parse(AlcoholPriceBox.Text);
		var result = count * price;
		if (count > 300)
			result -= result * 15 / 100;

		var builder = new StringBuilder();
		builder.AppendLine($"Вибрано \"{AlcoholTypeBox.Text}\" в кількості \"{count}\" шт.");
		if (count > 300)
			builder.AppendLine("Оскільки вибрана кількість більша за 300 одиниць, то застосовуємо знижку 15%");

		if (AdditionalCountBox.Value >= 1) {
			var additionalCount = long.Parse(AdditionalCountBox.Text);
			var additionalPrice = decimal.Parse(AdditionalPriceBox.Text);

			var additionalResult = additionalCount * additionalPrice;

			builder.AppendLine($"Було додано \"{AdditionalTypeBox.Text}\" в кількості \"{additionalCount}\" шт.");
			builder.AppendLine($"Сума до сплати: {result + additionalResult}");
		}
		else
			builder.AppendLine($"Сума до сплати: {result}");

		ResultBox.Text = builder.ToString();
	}

	private void CancelButton_Click(object sender, EventArgs e) {
		AlcoholCountBox.Value = 0;
		AdditionalCountBox.Value = 0;

		ResultBox.Clear();
	}

	#endregion
}