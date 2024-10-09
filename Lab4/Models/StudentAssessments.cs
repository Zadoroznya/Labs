namespace Lab4.Models;

internal class StudentAssessments {
	public Dictionary<string, List<int>> Assessment { get; } = [];
	public string Subject { get; }

	private const int MaxItems = 10;

	public StudentAssessments(string subject) {

		// Кількість модулів
		var modules = new Random().Next(1, 5);

		// Ініціалізація оцінювання
		for (var m = 0; m < modules; m++) {
			var items = new List<int>();

			for (var i = 0; i < MaxItems; i++)
				items.Add(new Random().Next(40, 100));

			Assessment.Add($"Модуль #{m + 1}", items);
		}

		Subject = subject;
	}

	public double StudentRating(out int selectedCount) {
		var count = selectedCount = Assessment.Count;
		double rating = 0;
		
		Console.WriteLine($"Дисципліна: \"{Subject}\"");
		foreach (var keyValuePair in Assessment.Take(count)) {
			var average = keyValuePair.Value.Average();
			Console.WriteLine($"Середній бал за \"{keyValuePair.Key}\": {average:F2}");
			rating += average;
		}

		return rating / count;
	}
}