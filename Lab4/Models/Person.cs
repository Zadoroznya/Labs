namespace Lab4.Models;

internal class Person {
	public Person(string name, string role, int age) {
		Name = name;
		Age = age;
		Role = role;
	}

	public string Name { get; set; }
	public int Age { get; set; }
	public string Role { get; set; }

	public string GetName() {
		return Name;
	}

	public virtual void MyRating() { }
}