namespace Lab4.Models;

internal class Student : Person {
	public Student(string name, string role, int age, string faculty, string group, int course)
		: base(name, role, age) {
		Name = name;
		Age = age;
		Role = role;
		Faculty = faculty;
		Group = group;
		Course = course;

		InitializeAssessments();
	}

	private void InitializeAssessments() {
		Assessments.Add(new StudentAssessments("Об'єктно-орієнтоване програмування"));
		Assessments.Add(new StudentAssessments("Операційні системи"));
		Assessments.Add(new StudentAssessments("Іноземна мова (за професійним спрямуванням)"));
		Assessments.Add(new StudentAssessments("Соціально-політичні студії"));
		Assessments.Add(new StudentAssessments("Філософія"));
		Assessments.Add(new StudentAssessments("Soft skills і способи їх розвитку"));
		Assessments.Add(new StudentAssessments("Алгоритми та структури даних"));
		Assessments.Add(new StudentAssessments("Законодавчі основи суспільних відносин"));
		Assessments.Add(new StudentAssessments("Комп'ютерна графіка"));
		Assessments.Add(new StudentAssessments("Дискретна математика"));
	}

	public string Faculty { get; set; }
	public string Group { get; set; }
	public int Course { get; set; }
	public List<StudentAssessments> Assessments { get; set; } = [];

	/// <summary>
	/// Оцінка діяльності студента протягом навчального періоду
	/// </summary>
	public override void MyRating() {
		var selectedCount = 0;

		double ratings = 0;
		foreach (var rating in Assessments.Select(assessment => assessment.StudentRating(out selectedCount))) {
			Console.WriteLine($"Середній бал за дисципліну (за таку кількість модулів - {selectedCount}): {rating:F2}");

			ratings += rating;

			switch (rating) {
				case >= 80:
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Студент відмінник в цій дисципліні!\r\n");
					break;
				case <= 60:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Студент повинен перездати!\r\n");
					break;
				default:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Студент вчиться нормально!\r\n");
					break;
			}

			Console.ForegroundColor = ConsoleColor.White;
		}

		var averageRating = ratings / Assessments.Count;

		Console.WriteLine($"Середній бал студента по всім дисциплінам: {averageRating:F2}");

		switch (averageRating) {
			case >= 80:
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Студент - відмінник!\r\n");
				break;
			case <= 60:
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Студент - відрахований!\r\n");
				break;
			default:
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Студент - тримається середнячком!\r\n");
				break;
		}
		Console.ForegroundColor = ConsoleColor.White;
	}

	/// <summary>
	/// Виведення інформації про студента
	/// </summary>
	public void GetStudentInfo() =>
		Console.WriteLine("Дані про студента:\r\n" +
		                  $"ПІБ: \"{Name}\";\r\n" +
		                  $"Вік: {Age};\r\n" +
		                  $"Факультет: \"{Faculty}\";\r\n" +
		                  $"Група: \"{Group}\";\r\n" +
		                  $"Курс: {Course};\r\n");
}