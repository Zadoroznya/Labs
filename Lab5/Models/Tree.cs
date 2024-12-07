using Lab5.Interfaces;

namespace Lab5.Models;

public class Tree : Plant, IPriceable, ICountable {
	public Tree(string name, string about) : base(name, about) { }

	public int Count() => Random.Shared.Next(10, 100);

	public decimal GetPrice() => Random.Shared.Next(100, 500);
}