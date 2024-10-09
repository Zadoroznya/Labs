namespace Lab3.Models;

internal class Person {
	public Person() {
		Name = "Anonimous";
		BirthDate = DateOnly.MinValue;
		Salary = decimal.Zero;
	}

	public Person(string line) {
		var splitter = line.Split(";");
		var namePart = splitter[0];
		Name = splitter.Length > 0 && !string.IsNullOrWhiteSpace(namePart)
			       ? namePart
			       : "Невідомий користувач";

		BirthDate = splitter.Length > 1 && DateOnly.TryParse(splitter[1], out var birthDate)
			            ? birthDate
			            : DateOnly.MinValue;

		Salary = splitter.Length > 2 && decimal.TryParse(splitter[2], out var salary)
			         ? salary
			         : decimal.Zero;
	}

	/// <summary>
	/// Прізвище та ініціали особи
	/// </summary>
	public string Name { get; set; }

	/// <summary>
	/// Дата народження особи
	/// </summary>
	public DateOnly? BirthDate { get; set; }

	/// <summary>
	/// Заробітна плата, яку отримує особа
	/// </summary>
	public decimal? Salary { get; set; }

	// Змінні для збереження ширини колонок
	private int _nameWidth;
	private int _birthWidth;
	private int _salaryWidth;

	public void SetWidth(int nameWidth, int birthWidth, int salaryWidth) {
		_nameWidth = nameWidth;
		_birthWidth = birthWidth;
		_salaryWidth = salaryWidth;
	}

	public override string ToString() {
		var birthDateStr = BirthDate?.ToString("yyyy-MM-dd") ?? string.Empty;
		var salaryStr = Salary.HasValue ? Salary.Value.ToString("F2") : string.Empty;

		return $"{Name.PadRight(_nameWidth)} {birthDateStr.PadRight(_birthWidth)} {salaryStr.PadLeft(_salaryWidth)}";
	}

	public bool Compare(string? name) {
		var onlyName = Name.Split(" ")[0];
		var result = !string.IsNullOrWhiteSpace(name) && string.Equals(onlyName, name);
		return result;
	}

	public static decimal? operator +(Person person, decimal a) {
		person.Salary += a;
		return person.Salary;
	}

	public static decimal? operator -(Person person, decimal a) {
		person.Salary -= a;
		if (person.Salary < 0) throw new FormatException();
		return person.Salary;
	}
}