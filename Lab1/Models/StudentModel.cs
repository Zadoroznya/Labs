namespace Lab1.Models;

internal class StudentModel {
	private string _name;
	private int _age;
	private int _course;
	private double _rating;

	/// <summary>
	/// ПІБ студента
	/// </summary>
	public string Name {
		get => _name;
		set => _name = value;
	}

	/// <summary>
	/// Вік студента
	/// </summary>
	public int Age {
		get => _age;
		set => _age = value;
	}

	/// <summary>
	/// Курс в якому вчиться студент
	/// </summary>
	public int Course {
		get => _course;
		set => _course = value;
	}

	/// <summary>
	/// Середній бал студента
	/// </summary>
	public double Rating {
		get => _rating;
		set => _rating = value;
	}

	public StudentModel(string name, int age, int course, double rating) {
		_name = name;
		_age = age;
		_course = course;
		_rating = rating;
	}

	public void GetStudentInfo() {
		Console.WriteLine("Дані про студента:\r\n" +
		                  $"ПІБ: \"{Name}\";\r\n" +
		                  $"Вік: \"{Age}\";\r\n" +
		                  $"Середній бал: \"{Rating}\";\r\n");
	}

	public void EditStudent(string? name, int? age, double? rating) {
		Console.WriteLine($"Виконаємо метод \"{nameof(EditStudent)}\" для редагування даних.");
		Name = name ?? Name;
		Age = age ?? Age;
		Rating = rating ?? Rating;

		Console.WriteLine("Нові значення даних студента:\r\n" +
		                  $"Оновлене ПІБ: \"{Name}\";\r\n" +
		                  $"Оновлений вік: \"{Age}\";\r\n" +
		                  $"Оновлений середній бал: \"{Rating}\";\r\n");
	}

	public void StudentRating() => Console.WriteLine($"Виконаємо метод \"{nameof(StudentRating)}\". Середній бал студента: {Rating}\r\n");

	public void GetRole() {
		var level = Course <= 4
			            ? "Бакалавр"
			            : "Магістр";
		Console.WriteLine($"Виконаємо метод \"{nameof(GetRole)}\". Cтудент наразі: \"{level}\"\r\n");
	}
}