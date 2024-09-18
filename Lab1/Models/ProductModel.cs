namespace Lab1.Models;

internal class ProductModel {
	/// <summary>
	/// Тип товару
	/// </summary>
	public string? Type { get; set; }

	/// <summary>
	/// Найменування товару
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Виробник товару
	/// </summary>
	public string? Manufacturer { get; set; }

	/// <summary>
	/// Ціна товару
	/// </summary>
	public double Price { get; set; }

	/// <summary>
	/// Зміна значень полів та виведення на консоль
	/// </summary>
	/// <param name="type">Тип товару</param>
	/// <param name="name">Найменування товару</param>
	/// <param name="manufacturer">Виробник товару</param>
	/// <param name="price">Ціна товару</param>
	public void UpdateProduct(string? type, string name, string manufacturer, double? price = null) {
		Type = type;
		Name = name;
		Manufacturer = manufacturer;
		Price = price ?? Price;

		Console.WriteLine("Нові значення полів:\r\n" +
		                  $"Тип: \"{Type}\";\r\n" +
		                  $"Назва: \"{Name}\";\r\n" +
		                  $"Виробник: \"{Manufacturer}\";\r\n");
	}

	/// <summary>
	/// Введення кількості товару та обчислення вартості
	/// </summary>
	public void CalculateCost() {
		Console.Write("Введіть кількість товару (в шт.): ");
		var isDouble = double.TryParse(Console.ReadLine(), out var quantity);

		Console.WriteLine(isDouble
			                  ? $"[{Type}] \"{Name}\", {quantity} шт., коштують {quantity * Price} грн.\r\n"
			                  : "Ви ввели не число\r\n");
	}

	/// <summary>
	/// Виводить інформацію про товар
	/// </summary>
	public void GetInfo() =>
		Console.WriteLine("Інформація про товар:\r\n" +
		                  $"Тип товару: \"{Type}\";\r\n" +
		                  $"Назва товару: \"{Name}\";\r\n" +
		                  $"Виробник товару: \"{Manufacturer}\";\r\n");
}