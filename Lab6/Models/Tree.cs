using System.Collections;

namespace Lab6.Models;

public class Tree : IComparable<Tree>, IComparer<Tree>, IEnumerable<Tree> {
	private readonly List<Tree> _trees = [];

	public Tree(string species, decimal price, int height) {
		Species = species;
		Price = price;
		Height = height;
	}

	/// <summary>
	/// Порода дерева
	/// </summary>
	public string Species { get; set; }
	
	/// <summary>
	/// Ціна дерева
	/// </summary>
	public decimal Price { get; set; }

	/// <summary>
	/// Висота дерева
	/// </summary>
	public int Height { get; set; }

	public int CompareTo(Tree? other) {
		return other == null
			       ? 1
			       : Price.CompareTo(other.Price);
	}

	public int Compare(Tree? x, Tree? y) {
		if (x == null || y == null) return 0;
		return x.Height.CompareTo(y.Height);
	}

	public IEnumerator<Tree> GetEnumerator() => _trees.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public void AddTree(Tree tree) => _trees.Add(tree);

	public override string ToString() => $"Порода дерева: {Species}, " +
	                                     $"Ціна: {Price:0.00}, " +
	                                     $"Висота: {Height}";
}