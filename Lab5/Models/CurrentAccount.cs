namespace Lab5.Models;

internal class CurrentAccount : BankAccount {
	public CurrentAccount(string name, decimal balance) : base(name, balance) { }
	public override void AddToAccount(decimal amount) {
		Balance += amount;
		Console.WriteLine($"На поточний рахунок \"{AccountName}\" додано {amount:0.00} грн. Баланс: {Balance:0.00} грн.");
	}

	public override void TakeFromAccount(decimal amount) {
		string message;

		if (Balance >= amount){
			Balance -= amount;
			message = $"З поточного рахунку \"{AccountName}\" знято {amount:0.00} грн. Баланс: {Balance:0.00} грн.";
		}
		else
			message = $"Недостатньо коштів для зняття {amount:0.00} грн. з поточного рахунку \"{AccountName}\". Баланс: {Balance:0.00} грн.";

		Console.WriteLine(message);
	}
}