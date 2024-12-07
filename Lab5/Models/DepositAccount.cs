namespace Lab5.Models;

internal class DepositAccount : BankAccount {
	public DepositAccount(string name, decimal balance) : base(name, balance) { }

	public override void AddToAccount(decimal amount) {
		Balance += amount;
		Console.WriteLine($"На депозитний рахунок \"{AccountName}\" додано {amount:0.00} грн. Баланс: {Balance:0.00} грн.");
	}

	public override void TakeFromAccount(decimal amount) {
		string message;

		if (Balance >= amount) {
			Balance -= amount;
			message = $"З депозитного рахунку \"{AccountName}\" знято {amount:0.00} грн. Баланс: {Balance:0.00} грн.";
		}
		else {
			message = $"Недостатньо коштів для зняття {amount:0.00} грн. з депозитного рахунку \"{AccountName}\". Баланс: {Balance:0.00} грн.";
		}

		Console.WriteLine(message);
	}
}