namespace Lab2.Models;

internal class Goods {
	public Goods(string name, string type) {
		Name = name;
		Type = type;
	}

	public string Name { get; set; }
	public string Type { get; set; }

	public virtual void VirtualMethod1() => Console.WriteLine("Віртуальний метод 1 базового класу");

	public virtual void VirtualMethod2() => Console.WriteLine("Віртуальний метод 2 базового класу");
}