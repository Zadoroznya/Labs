namespace Lab5.Interfaces;

public interface IPlant {
	/// <summary>
	/// Найменування рослини
	/// </summary>
	string Name { get; set; }
	/// <summary>
	/// Інформація про рослину
	/// </summary>
	string About { get; set; }
}