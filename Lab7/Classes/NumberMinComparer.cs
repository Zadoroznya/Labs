namespace Lab7.Classes;

internal class NumberMinComparer<T> where T : IComparable<T> {
	// Конструктор
	public NumberMinComparer(T value) {
		Value = value;
	}

	public T Value { get; private set; }

	/// <summary>
	/// Метод для знаходження меншого з двох чисел
	/// </summary>
	/// <param name="a">Перше число</param>
	/// <param name="b">друге число</param>
	/// <returns></returns>
	public T FindMin(T a, T b) => a.CompareTo(b) < 0 ? a : b;

	/// <summary>
	/// Метод для знаходження меншого з двох чисел
	/// </summary>
	/// <param name="a">Інше число яке порівнюємо з основним</param>
	/// <returns></returns>
	public T FindMin(T a) => a.CompareTo(Value) < 0 ? a : Value;
}