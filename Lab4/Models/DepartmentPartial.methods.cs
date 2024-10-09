using System.Text;

namespace Lab4.Models;

internal partial class DepartmentPartial {
	/// <summary>
	///     Встановлення назви кафедри
	/// </summary>
	/// <param name="departmentName">Найменування кафедри</param>
	public void SetName(string? departmentName) => _name = departmentName;

	/// <summary>
	///     Встановлення кількості викладачів кафедри
	/// </summary>
	/// <param name="count">Кількість викладачів</param>
	public void SetTeacherCount(int count) => _teacherCount = count;

	/// <summary>
	///     Виведення інформації про кафедру
	/// </summary>
	/// <param name="builder"></param>
	public void ShowInfo(StringBuilder builder) {
		builder.AppendLine($"[Частковий клас]\r\nКафедра: {_name}, викладачів: {_teacherCount}");
		builder.AppendLine("Дисципліни кафедри:");
		foreach (var discipline in _disciplines)
			if (!string.IsNullOrEmpty(discipline))
				builder.AppendLine($"- {discipline}");
		builder.AppendLine();
	}
}