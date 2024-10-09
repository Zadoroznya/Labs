using System.Text;
using Lab4.Extensions;
using Lab4.Models;

// Для коректного відображення символів на консолі та читання даних
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task 1

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Завдання №1. Модифікація програми\r\n");
Console.ForegroundColor = ConsoleColor.White;

// Створення екземпляра student
var student = new Student("Задорожня Ірина Юріївна", "Студентка", 18, "МНТУ", "І-31", 3);

// Виведення інформації про студента
student.GetStudentInfo();

// Виведення інформації про успішність студента
student.MyRating();

#endregion

#region Task 2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Завдання №2. Реалізація факультету і кафедри\r\n");
Console.ForegroundColor = ConsoleColor.White;

var faculty = new Faculty {
	Name = "Комп'ютерних наук"
};

// Встановлюємо дані для першої кафедри
faculty.Department1.SetName("Комп'ютерних наук та ІПЗ");
faculty.Department1.SetTeacherCount(10);
faculty.Department1[0] = "Програмування";
faculty.Department1[1] = "Алгоритми";
faculty.Department1[2] = "Бази даних";

// Встановлюємо дані для другої кафедри
faculty.Department2.SetName("Вища математика");
faculty.Department2.SetTeacherCount(5);
faculty.Department2[0] = "Математичний аналіз";
faculty.Department2[1] = "Лінійна алгебра";

// Викликаємо метод для відображення інформації про факультет і кафедри
faculty.ShowFacultyInfo();

#endregion

#region Task 3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Завдання №3. Розбити клас Кафедра на 2 частини.\r\n");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Вже реалізовано, подивіться на код програми. В попередній задачі один з класів кафедри - частковий.\r\n");

#endregion

#region Task 4

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Завдання №4. Статичні класи. Розробити статичний клас з методами:\r\n" +
                  "1) Знайти методом лінійного пошуку максимальний і мінімальний елементи в масиві {4,5,2,3,8,7,6,1}\r\n" +
                  "2) Знайти методом двійкового пошуку потрібний елемент у масиві розміру 100.\r\n");
Console.ForegroundColor = ConsoleColor.White;

int[] array = [4, 5, 2, 3, 8, 7, 6, 1];

Console.WriteLine($"1) Використовуючи статичний метод \"{nameof(Extensions.FindMinMax)}\" отримаємо необхідні значення:");

var (minValue, maxValue) = array.FindMinMax();

Console.WriteLine($"- Мінімальне значення в масиві: {minValue}\r\n" +
                  $"- Максимальне значення в масиві: {maxValue}");

var arrayAlt = new int[100];
for (var i = 0; i < arrayAlt.Length; i++)
	arrayAlt[i] = new Random().Next(1000);

Array.Sort(arrayAlt);

var builder = new StringBuilder();

builder.AppendLine("\r\n2) Створимо масив з 100 елементів:");
arrayAlt.PrintArrayInTable(builder);

builder.Append("Введіть елемент, який потрібно знайти: ");
Console.WriteLine(builder);

var target = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"\r\nВикористовуючи статичний метод \"{nameof(Extensions.BinarySearch)}\" отримаємо необхідне значення:");
var resultIndex = arrayAlt.BinarySearch(target);
Console.WriteLine(resultIndex != -1
	                  ? $"Елемент знайдено за індексом: {resultIndex}\r\n"
	                  : "Елемент не знайдено.\r\n");

#endregion

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();