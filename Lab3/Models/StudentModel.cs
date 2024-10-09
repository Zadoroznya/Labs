namespace Lab3.Models;

internal class StudentModel {
	private readonly int[] _grades;

	public StudentModel(string name, int age, int course, int maxGradesForCourse = 10) {
		_grades = new int[maxGradesForCourse];
		Name = name;
		Age = age;
		Course = course;
		MaxItems = maxGradesForCourse;
	}

	/// <summary>
	/// Індексатор для доступу до оцінок
	/// </summary>
	/// <param name="index">Індекс</param>
	/// <returns>Оцінка студента</returns>
	public int this[int index] {
		get {
			if (index >= 0 && index < _grades.Length)
				return _grades[index];
			
			throw new IndexOutOfRangeException("Індекс виходить за межі масиву оцінок.");
		}
		set {
			if (index >= 0 && index < _grades.Length)
				_grades[index] = value;
			else
				throw new IndexOutOfRangeException("Індекс виходить за межі масиву оцінок.");
		}
	}

	/// <summary>
	/// Відображає максимальну кількість оцінок за курс
	/// </summary>
	public int MaxItems { get; set; }

	/// <summary>
	///     ПІБ студента
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	///     Вік студента
	/// </summary>
	public int Age { get; set; }

	/// <summary>
	///     Курс в якому вчиться студент
	/// </summary>
	public int Course { get; set; }

	/// <summary>
	///     Середній бал студента
	/// </summary>
	public double Rating { get; set; }

	/// <summary>
	///     Виведення інформації про студента
	/// </summary>
	public void GetStudentInfo() {
		Console.WriteLine("Дані про студента:\r\n" +
		                  $"ПІБ: \"{Name}\";\r\n" +
		                  $"Вік: \"{Age}\";\r\n" +
		                  $"Курс: \"{Course}\";\r\n" +
		                  $"Середній бал: \"{Rating}\";\r\n");
	}

	/// <summary>
	///     Розрахунок середнього балу студента
	/// </summary>
	public void CalculateAverageGrade() {
		Console.WriteLine($"Розраховуємо середній бал студента: \"{Name}\"\r\n");

		var total = 0;
		var count = 0;

		foreach (var grade in _grades) {
			// Це як захист від "дурня"
			if (grade <= 0)
				continue;

			total += grade;
			count++;
		}

		Rating = count > 0
			         ? (double)total / count
			         : 0.0;
	}
}