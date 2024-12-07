using Lab5.Interfaces;

namespace Lab5.Models;

public class Flower : Plant, IPriceable, ICountable {
	public Flower(string name, string about) : base(name, about) { }

	public int Count() => Random.Shared.Next(10, 50);

	public decimal GetPrice() => Random.Shared.Next(10, 40);
}