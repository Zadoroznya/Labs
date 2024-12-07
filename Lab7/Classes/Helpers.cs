namespace Lab7.Classes;

internal static class Helpers
{
	/// <summary>
	///     Узагальнений метод для обміну значеннями
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="left">Перший елемент</param>
	/// <param name="right">Другий елемент</param>
	internal static void Swap<T>(ref T left, ref T right)
	{
		(left, right) = (right, left);
	}

	internal static (T Min, T Max) FindMinMax<T>(T[]? array) where T : IComparable<T>
	{
		if (array == null || array.Length == 0)
		{
			Console.WriteLine("Масив не може бути порожнім.");
			return default;
		}

		var min = array[0];
		var max = array[0];

		foreach (var item in array)
		{
			if (item.CompareTo(min) < 0)
				min = item;
			if (item.CompareTo(max) > 0)
				max = item;
		}

		return (min, max);
	}
}