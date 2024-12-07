using System.Text;
using Lab6.Models;

// Для коректного відображення символів на консолі та читання даних
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1 і №2 і №3\r\n");
Console.ForegroundColor = ConsoleColor.White;

// Створення масиву дерев
var treeArray = new Tree[] {
	new("Дуб", 200, 20),
	new("Сосна", 150, 25),
	new("Береза", 180, 15),
	new("Липа", 220, 18)
};

// Сортування масиву дерев за ціною за допомогою IComparable
Array.Sort(treeArray);
Console.WriteLine("Дерева, впорядковані за ціною:");
foreach (var tree in treeArray)
	Console.WriteLine(tree);

Console.WriteLine();

// Сортування за висотою за допомогою IComparer
Array.Sort(treeArray, new Tree("", 0, 0)); // Передаємо Tree як IComparer
Console.WriteLine("Дерева, впорядковані за висотою:");
foreach (var tree in treeArray)
	Console.WriteLine(tree);

Console.WriteLine();

// Використання IEnumerable для виводу списку дерев
var treeCollection = new Tree("", 0, 0);
foreach (var tree in treeArray)
	treeCollection.AddTree(tree);

Console.WriteLine("Список дерев (з використанням IEnumerable):");
foreach (var tree in treeCollection)
	Console.WriteLine(tree);

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();