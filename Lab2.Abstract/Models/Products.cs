namespace Lab2.Abstract.Models;

internal class Products : Goods {
	public Products(string name, string type, string sort, int count)
		: base(name, type) {
		Variety = sort;
		Count = count;
	}

	public string Variety { get; set; }
	public int Count { get; set; }

	public override void VirtualMethod1() => Console.WriteLine("Перевизначений віртуальний метод 1 у класі \"Продукти\"");

	public override void VirtualMethod2() => Console.WriteLine("Перевизначений віртуальний метод 2 у класі \"Продукти\"");

	/// <summary>
	/// Обчислює вартість продуктів з урахуванням їх сорту
	/// </summary>
	public void GetPrice() {
		const double variety1Price = 50.0;
		const double variety2Price = 40.0;
		const double variety3Price = 30.0;

		var pricePerOnce = Variety switch {
			"Перший" => variety1Price,
			"Другий" => variety2Price,
			"Третій" => variety3Price,
			_ => 0.0
		};

		var productsPrice = Count * pricePerOnce;

		Console.WriteLine($"\r\nТовар = {Name};\r\n" +
			$"Тип = {Type};\r\n" +
			$"Сорт = {Variety};\r\n" +
			$"Ціна за 1 товару = {pricePerOnce};\r\n" +
			$"Кількість на складі = {Count};\r\n" +
			$"Вартість партії товару = {productsPrice}\r\n");
	}
}