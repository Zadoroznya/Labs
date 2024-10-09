namespace Lab4.Models;

internal partial class DepartmentPartial {
	private readonly string[] _disciplines = new string[10]; // Масив дисциплін
	private string? _name;

	private int _teacherCount;

	/// <summary>
	///     Індексатор для дисциплін кафедри
	/// </summary>
	/// <param name="index">Індекс</param>
	/// <returns></returns>
	/// <exception cref="IndexOutOfRangeException"></exception>
	public string this[int index] {
		get {
			if (index >= 0 && index < _disciplines.Length)
				return _disciplines[index];
			throw new IndexOutOfRangeException("Індекс виходить за межі масиву дисциплін.");
		}
		set {
			if (index >= 0 && index < _disciplines.Length)
				_disciplines[index] = value;
			else
				throw new IndexOutOfRangeException("Індекс виходить за межі масиву дисциплін.");
		}
	}
}