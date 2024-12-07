using Lab5.Interfaces;
using System.Xml.Linq;

namespace Lab5.Models;

public abstract class BankAccount : IBankAccount {
	protected BankAccount(string name, decimal balance) {
		CreateAccount(name);
		AccountName = name;
		Balance = balance;
	}

	public string AccountName { get; protected set; }
	public decimal Balance { get; protected set; }

	public void CreateAccount(string name) =>
		Console.WriteLine(string.IsNullOrWhiteSpace(AccountName)
			                  ? $"Створено новий рахунок \"{name}\"."
			                  : $"Рахунок \"{name}\" раніше вже було створено. " +
			                    $"Поточний баланс: {Balance:0.00} грн.");

	public void DeleteAccount() =>
		Console.WriteLine(Balance > 0
			                  ? $"Видалено рахунок \"{AccountName}\" з балансом: {Balance:0.00} грн. " +
			                    "Для повернення коштів зверніться до відділення банку."
			                  : $"Видалено рахунок \"{AccountName}\"");

	/// <summary>
	/// Додавання коштів до рахунку
	/// </summary>
	/// <param name="amount">Сума поповнення</param>
	public abstract void AddToAccount(decimal amount);

	/// <summary>
	/// Зняття коштів з рахунку
	/// </summary>
	/// <param name="amount">Сума зняття</param>
	public abstract void TakeFromAccount(decimal amount);
}