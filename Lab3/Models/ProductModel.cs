namespace Lab3.Models;

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
	/// Ціна товару
	/// </summary>
	public double Price { get; set; }

	/// <summary>
	/// Виводить інформацію про товар
	/// </summary>
	public void GetInfo() {
		Console.WriteLine("Загальна інформація про товар:\r\n" +
		                  $"Тип товару: \"{Type}\";\r\n" +
		                  $"Назва товару: \"{Name}\";\r\n" +
		                  $"Ціна товару: \"{Price}\";\r\n");
	}

	/// <summary>
	/// Виводить інформацію про товар попередньо перезаписавши 2 параметри
	/// </summary>
	/// <param name="type">Тип товару</param>
	/// <param name="name">Найменування товару</param>
	public void GetInfo(string? type, string? name) {
		Type = type;
		Name = name;

		Console.WriteLine("Інформація про товар з перезаписом двох параметрів:\r\n" +
		                  $"Тип товару: \"{Type}\";\r\n" +
		                  $"Назва товару: \"{Name}\";\r\n");
	}

	/// <summary>
	/// Виводить інформацію про товар попередньо перезаписавши 3 параметри
	/// </summary>
	/// <param name="type">Тип товару</param>
	/// <param name="name">Найменування товару</param>
	/// <param name="price">Ціна товару</param>
	public void GetInfo(string? type, string? name, double price) {
		Type = type;
		Name = name;
		Price = price;

		Console.WriteLine("Інформація про товар з перезаписом трьох параметрів:\r\n" +
		                  $"Тип товару: \"{Type}\";\r\n" +
		                  $"Назва товару: \"{Name}\";\r\n" +
		                  $"Ціна товару: \"{Price}\";\r\n");
	}
}