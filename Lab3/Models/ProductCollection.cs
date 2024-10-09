namespace Lab3.Models;

internal class ProductCollection {
	/// <summary>
	/// Створює індексатор і заповнює його значеннями
	/// </summary>
	public ProductCollection(int maxItems) {
		MaxItems = maxItems;

		_products = new ProductModel[MaxItems];
		for (var i = 0; i < MaxItems; i++)
			_products[i] = new ProductModel {
				Type = "Електроніка",
				Name = $"Смартфон №{i + 1}",
				Price = (i + 1) * 100
			};
	}

	private readonly ProductModel[] _products;

	/// <summary>
	/// Відображає максимальну кількість доступних елементів
	/// </summary>
	public int MaxItems { get; set; }

	public ProductModel this[int index] {
		get => _products[index];
		set => _products[index] = value;
	}
}