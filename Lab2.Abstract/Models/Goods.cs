namespace Lab2.Abstract.Models;

public abstract class Goods {
	protected Goods(string name, string type) {
		Name = name;
		Type = type;
	}

	public string Name { get; set; }
	public string Type { get; set; }

	public abstract void VirtualMethod1();
	public abstract void VirtualMethod2();
}