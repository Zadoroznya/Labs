using System.Text;
using Lab3.Models;
using Lab3.Properties;

// Для коректного відображення символів на консолі та читання даних
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task 1

Console.WriteLine("Завдання №1. Модифікація програми\r\n");

var dbase = new List<Person>();
int nameWidth;
int birthWidth;
int salaryWidth;
int dividerWidth;
try {
	// Отримання даних з файлу ресурсів і розбиття на рядки (масиви)
	var lines = Resources.DataSet.Split(Environment.NewLine);
	if (lines.Length <= 0) {
		Console.WriteLine("Не знайдено жодного рядка в файлі!");
		return;
	}

	// Створення моделей і їх заповнення
	dbase.AddRange(lines.Select(line => new Person(line)));

	// Допоміжні поля для реалізації гарного списку осіб
	nameWidth = dbase.Max(p => p.Name.Length);
	birthWidth = dbase.Max(p => p.BirthDate?.ToString("yyyy-MM-dd").Length ?? 0);
	salaryWidth = dbase.Max(p => p.Salary?.ToString("F2").Length ?? 0);
	dividerWidth = nameWidth + birthWidth + salaryWidth + 2;
	const string title = "Списки працівників";

	// Виведення списку осіб
	Console.WriteLine($"{title.PadLeft(dividerWidth - title.Length / 2)}\r\n" +
	                  $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
	                  $"{new string('-', dividerWidth)}");

	foreach (var person in dbase) {
		person.SetWidth(nameWidth, birthWidth, salaryWidth);
		Console.WriteLine(person);
	}
	Console.WriteLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));
}
catch (FileNotFoundException e) {
	Console.WriteLine(e.Message);
	Console.WriteLine("Перевірте правильність імені і шляху до файлу!");
	return;
}

catch (IndexOutOfRangeException) {
	Console.WriteLine("Дуже великий файл!");
	return;
}
catch (Exception e) {
	Console.WriteLine($"Помилка: {e.Message}");
	return;
}

var builder = new StringBuilder();
var personCount = 0;
decimal? meanPay = 0;
string? name;

Console.WriteLine("\r\nВведіть прізвище співробітника і натисніть Enter, щоб виконати пошук\r\n" +
                  "Або введіть Enter для пропуску завдання (тільки в тому разі якщо поле пусте)");
while ((name = Console.ReadLine()) != "") {
	builder.Clear();
	var notFound = true;

	builder.AppendLine("Знайдено результати:\r\n" +
	                   $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
	                   $"{new string('-', dividerWidth)}");
	foreach (var person in dbase.FindAll(person => person.Compare(name))) {
		builder.AppendLine(person.ToString());

		++personCount;
		meanPay += person.Salary;
		notFound = false;
	}
	builder.AppendLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));

	Console.WriteLine(notFound ? "Такого співробітника немає" : builder);
	
	Console.WriteLine("Введіть прізвище співробітника або Enter для завершення");
}

if (personCount > 0)
	Console.WriteLine("Середній оклад: {0:F2}\r\n", meanPay / personCount);

#endregion

#region Task 2

Console.WriteLine("Завдання №2. Перевизначення методів\r\n");

// Основна модель, з якою працюємо
var product = new ProductModel {
	Type = "Електроніка",
	Name = "Смартфон OnePlus 11 5G",
	Price = 40000
};

// Виводимо всю наявну інформацію
product.GetInfo();

// Перезаписуємо і виводимо інформацію про товар (Тип й найменування)
product.GetInfo("Електроніка", "Ноутбук ASUS");

// Перезаписуємо і виводимо інформацію про товар (Тип, найменування й ціна)
product.GetInfo("Електроніка", "Монітор Samsung Odyssey", 45000);

#endregion

#region Task 3

Console.WriteLine("Завдання №3. Приклад роботи індексатора\r\n");

// Ініціалізація індексатора
var collection = new ProductCollection(10);

// Отримання і виведення значення
Console.WriteLine("Отримання і виведення даних з індексатору по випадковому значенню з 0 ДО 10");

collection[new Random().Next(collection.MaxItems)].GetInfo();

#endregion

#region Task 4

Console.WriteLine("Завдання №4. Індексатори\r\n");

var student = new StudentModel("Задорожня Ірина Юріївна", 18, 2);

for (var i = 0; i < student.MaxItems; i++)
	student[i] = new Random().Next(0, 100);

// Розрахунок середнього бала
student.CalculateAverageGrade();

// Виведення інформації
student.GetStudentInfo();

#endregion

#region Task 5

Console.WriteLine("Завдання №5. Перевизначення операцій\r\n");

Console.WriteLine("Для цієї задачі використаємо дані з завдання №1.\r\n" +
                  "Виберемо якусь особу і збільшимо їй заробітну плату використовуючи перевизначені оператори\r\n");

#region Increase salary

builder.Clear();

builder.AppendLine("Було вибрано:\r\n" +
                   $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
                   $"{new string('-', dividerWidth)}");

var randomPerson = new Random().GetItems(dbase.ToArray(), 1).First();

builder.AppendLine(randomPerson.ToString());

builder.AppendLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));

Console.WriteLine(builder);

builder.Clear();

builder.AppendLine("Дані після підвищення заробітної плати:\r\n" +
                   $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
                   $"{new string('-', dividerWidth)}");

randomPerson.Salary = randomPerson + new Random().Next(100, 500);

builder.AppendLine(randomPerson.ToString());

builder.AppendLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));

Console.WriteLine(builder);

#endregion

#region Decrease salary

builder.Clear();

builder.AppendLine("Було вибрано іншу особу:\r\n" +
                   $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
                   $"{new string('-', dividerWidth)}");

var randomPerson2 = new Random().GetItems(dbase.ToArray(), 1).First();

builder.AppendLine(randomPerson2.ToString());

builder.AppendLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));

Console.WriteLine(builder);

builder.Clear();

builder.AppendLine("Дані після зниження заробітної плати:\r\n" +
                   $"{"Name".PadRight(nameWidth)} {"Birth".PadRight(birthWidth)} {"Salary".PadLeft(salaryWidth)}\r\n" +
                   $"{new string('-', dividerWidth)}");

randomPerson2.Salary = randomPerson2 - new Random().Next(100, 300);

builder.AppendLine(randomPerson2.ToString());

builder.AppendLine(new string('-', nameWidth + birthWidth + salaryWidth + 2));

Console.WriteLine(builder);

#endregion

#endregion

Console.WriteLine("Дякуємо за увагу. Натисніть щось щоб завершити роботу");
Console.ReadKey();