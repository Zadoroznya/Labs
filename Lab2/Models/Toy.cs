namespace Lab2.Models;

internal class Toy : Goods {
	public Toy(string name, string type, int count, string color)
		: base(name, type) {
		Count = count;
		Color = color;
	}

	public int Count { get; set; }
	public string Color { get; set; }

	public override void VirtualMethod1() => Console.WriteLine("Перевизначений віртуальний метод 1 у класі \"Іграшка\"");

	public override void VirtualMethod2() => Console.WriteLine("Перевизначений віртуальний метод 2 у класі \"Іграшка\"");

	/// <summary>
	/// Обчислює вартість усіх іграшок і повертає результат.
	/// </summary>
	/// <param name="count">Кількість товару</param>
	/// <returns>Сума всіх товарів</returns>
	public double GetPrice(int count) {
		const double price = 20.0;
		return count * price;
	}

	/// <summary>
	/// Виводить на консоль усі поля класу
	/// </summary>
	public void GetInfo() {
		Console.WriteLine($"\r\nНазва: {Name};\r\n" +
		                  $"Тип: {Type};\r\n" +
		                  $"Кількість: {Count};\r\n" +
		                  $"Колір: {Color}");
	}
}