using Lab5.Interfaces;

namespace Lab5.Models;

public abstract class Plant : IPlant {
	protected Plant(string name, string about) {
		Name = name;
		About = about;
	}

	public string Name { get; set; }
	public string About { get; set; }
}