namespace Lab5.Interfaces;

public interface IBankAccount {
	/// <summary>
	/// Створення нового рахунку
	/// </summary>
	/// <param name="name">Найменування рахунку</param>
	void CreateAccount(string name);

	/// <summary>
	/// Видалення рахунку
	/// </summary>
	void DeleteAccount();
}