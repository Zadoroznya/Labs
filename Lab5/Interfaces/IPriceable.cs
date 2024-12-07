namespace Lab5.Interfaces;

public interface IPriceable {
	/// <summary>
	/// Розрахунок вартості рослини
	/// </summary>
	/// <returns>Вартість</returns>
	decimal GetPrice();
}