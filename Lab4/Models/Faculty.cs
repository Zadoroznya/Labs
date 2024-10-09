using System.Text;

namespace Lab4.Models;

internal class Faculty {
	// Два екземпляри класу Кафедра
	public Department Department1 = new();
	public DepartmentPartial Department2 = new();

	/// <summary>
	/// Найменування факультету
	/// </summary>
	public string? Name { get; set; }

	/// <summary>
	/// Виведення загальної інформації про факультет
	/// </summary>
	public void ShowFacultyInfo() {
		var builder = new StringBuilder();
		builder.AppendLine($"Факультет: {Name}");
		Department1.ShowInfo(builder);
		Department2.ShowInfo(builder);

		Console.WriteLine(builder);

		builder.Clear();
	}

	internal class Department {
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

		/// <summary>
		/// Встановлення назви кафедри
		/// </summary>
		/// <param name="departmentName">Найменування кафедри</param>
		public void SetName(string? departmentName) {
			_name = departmentName;
		}

		/// <summary>
		///     Встановлення кількості викладачів кафедри
		/// </summary>
		/// <param name="count">Кількість викладачів</param>
		public void SetTeacherCount(int count) {
			_teacherCount = count;
		}

		/// <summary>
		/// Виведення інформації про кафедру
		/// </summary>
		/// <param name="builder"></param>
		public void ShowInfo(StringBuilder builder) {
			builder.AppendLine($"Кафедра: {_name}, викладачів: {_teacherCount}");
			builder.AppendLine("Дисципліни кафедри:");
			foreach (var discipline in _disciplines)
				if (!string.IsNullOrEmpty(discipline))
					builder.AppendLine($"- {discipline}");
			builder.AppendLine();
		}
	}
}