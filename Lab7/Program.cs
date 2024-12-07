// Для коректного відображення символів на консолі та читання даних
using System.Text;
using Lab7.Classes;
using Lab7.Models;

const string endLine = "\r\n";
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task1

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1. Універсальні методи{endLine}");
Console.ForegroundColor = ConsoleColor.White;

// Приклад обміну для типу double
var x = 3.14;
var y = 2.71;

Console.WriteLine("Перед обміном:");
Console.WriteLine($"x = {x}, y = {y}");

Helpers.Swap(ref x, ref y);

Console.WriteLine("Після обміну:");
Console.WriteLine($"x = {x}, y = {y}{endLine}");

// Приклад обміну для типу string
var data1 = "Hello";
var data2 = "World";

Console.WriteLine("Перед обміном:");
Console.WriteLine($"str1 = {data1}, str2 = {data2}");

Helpers.Swap(ref data1, ref data2);

Console.WriteLine("Після обміну:");
Console.WriteLine($"str1 = {data1}, str2 = {data2}{endLine}");

#endregion

#region Task2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №2. Універсальні методи з обмеженнями типу{endLine}");
Console.ForegroundColor = ConsoleColor.White;

int[] intArray = [3, 5, 1, 9, 7, 2];
Console.WriteLine($"Масив цілих чисел: {string.Join(", ", intArray)}");
var (intMin, intMax) = Helpers.FindMinMax(intArray);
Console.WriteLine($"Мінімум = {intMin}. Максимум = {intMax}{endLine}");

double[] doubleArray = [3.14, 1.59, 2.71, 0.1, 5.0];
Console.WriteLine($"Масив дійсних чисел: {string.Join(" | ", doubleArray)}");
var (doubleMin, doubleMax) = Helpers.FindMinMax(doubleArray);
Console.WriteLine($"Мінімум = {doubleMin}. Максимум = {doubleMax}{endLine}");

#endregion

#region Task3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №3. Універсальні (узагальнені) класи з одним параметром{endLine}");
Console.ForegroundColor = ConsoleColor.White;

// Приклад з цілими числами
var intExample = new NumberMinComparer<int>(5);
var intValueMin = intExample.FindMin(10, 20);
Console.WriteLine($"Мінімум серед 10 і 20: {intValueMin}");

var intValueMin2 = intExample.FindMin(32);
Console.WriteLine($"[Альтернативний метод] Мінімум серед 5 і 32: {intValueMin2}");

Console.WriteLine();

// Приклад з дійсними числами
var doubleExample = new NumberMinComparer<double>(5.5);
var doubleValueMin = doubleExample.FindMin(3.14, 2.71);
Console.WriteLine($"Мінімум серед 3.14 і 2.71: {doubleValueMin}");

var doubleValueMin2 = doubleExample.FindMin(6.14);
Console.WriteLine($"[Альтернативний метод] Мінімум серед 5.5 і 6.14: {doubleValueMin2}{endLine}");

#endregion

#region Task4

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №4. Обмеження параметрів типу{endLine}");
Console.ForegroundColor = ConsoleColor.White;

var productList = new GenericList<Product>();

// Додавання виробів до списку
productList.AddHead(new Product(101, "Стілець"));
productList.AddHead(new Product(102, "Стіл"));
productList.AddHead(new Product(103, "Диван"));
productList.AddHead(new Product(104, "Тумба"));
productList.AddHead(new Product(105, "Шафа"));

// Перегляд списку виробів
Console.WriteLine("Список виробів:");
foreach (var product in productList)
	Console.WriteLine($"Назва: {product?.Name}, ID: {product?.Id}");

Console.WriteLine();

const string searchName = "Стіл";
Console.WriteLine($"Шукаємо виріб: \"{searchName}\"");
var foundProduct = productList.FindFirstOccurrence(searchName);
Console.WriteLine(foundProduct != null
	                  ? $"Знайдено виріб: Назва: \"{foundProduct.Name}\", ID: {foundProduct.Id}"
	                  : $"Виріб з назвою \"{searchName}\" не знайдено.");

#endregion

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();