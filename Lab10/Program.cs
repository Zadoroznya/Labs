using System.Text;
using System.Text.RegularExpressions;
using Lab10.Models;

const string endLine = "\r\n";
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task1

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1{endLine}");
Console.ForegroundColor = ConsoleColor.White;

string[] files = [
	"report.txt",
	"image.png",
	"document.pdf",
	"notes.txt",
	"photo.jpg",
	"archive.zip",
	"readme.txt"
];

Console.WriteLine($"Список файлів: {string.Join(", ", files)}.{endLine}");

// Формування LINQ-запиту для вибірки тільки текстових файлів
var textFiles = files.Where(file => file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase));

Console.WriteLine($"Текстові файли: {string.Join(", ", textFiles)}{endLine}");

#endregion

#region Task2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №2{endLine}");
Console.ForegroundColor = ConsoleColor.White;

const string fileName = "Task2.txt";
// Тестовий вміст файлу
const string text = "Цей документ засекречений. Використовувати його тільки для службового використання. " +
                    "Будь ласка, передайте файл таємно іншим співробітникам вашого рангу. " +
                    "Якщо слово \"таємно\" згадується кілька разів, це потрібно зафіксувати і передати вищому керівництву.";

if (!File.Exists(fileName))
	File.WriteAllText(fileName, text);

// Зчитуємо текст з файлу
var fileContent = File.ReadAllText(fileName);
Console.WriteLine($"Контент з файлу: \"{fileContent}\"{endLine}");

// Перевіряємо наявність слів "таємно" та "для службового використання"
var containsSecret = fileContent.IndexOf("таємно", StringComparison.OrdinalIgnoreCase) > 0;
var containsForOfficialUse = fileContent.IndexOf("для службового використання", StringComparison.OrdinalIgnoreCase) > 0;

// Підрахунок кількості слів "таємно" ігноруючи регістр
var countSecret = Regex.Matches(fileContent, "таємно", RegexOptions.IgnoreCase).Count;

Console.WriteLine($"Чи містить текст слово \"таємно\": {containsSecret}{endLine}" +
                  $"Чи містить текст фразу \"для службового використання\": {containsForOfficialUse}{endLine}" +
                  $"Скільки разів у тексті зустрічається слово \"таємно\": {countSecret}{endLine}");

#endregion

#region Task3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №3{endLine}");
Console.ForegroundColor = ConsoleColor.White;

// Створимо колекцію з 10 об'єктів Movie
var movies = new List<Movie> {
	new() { Name = "Фільм1", Author = "Автор1", Year = 1999, Category = "Фентезі" },
	new() { Name = "Фільм2", Author = "Автор2", Year = 2001, Category = "Романтика" },
	new() { Name = "Фільм3", Author = "Автор3", Year = 2005, Category = "Драма" },
	new() { Name = "Фільм4", Author = "Автор4", Year = 2008, Category = "Фантастика" },
	new() { Name = "Фільм5", Author = "Автор5", Year = 2010, Category = "Фентезі" },
	new() { Name = "Фільм6", Author = "Автор6", Year = 2012, Category = "Комедія" },
	new() { Name = "Фільм7", Author = "Автор7", Year = 2003, Category = "Фентезі" },
	new() { Name = "Фільм8", Author = "Автор8", Year = 2011, Category = "Комедія" },
	new() { Name = "Фільм9", Author = "Автор9", Year = 2007, Category = "Фентезі" },
	new() { Name = "Фільм10", Author = "Автор10", Year = 2002, Category = "Фентезі" }
};

Console.WriteLine("Список фільмів:");
foreach (var movie in movies)
	Console.WriteLine($"{movie.Name} ({movie.Year}) - {movie.Author}, {movie.Category}");

var selectedMovies = movies.Where(m => m is { Category: "Фентезі", Year: > 2000 and < 2012 })
                           .ToList();

// Обчислення кількості вибраних фільмів
var count = selectedMovies.Count();

Console.WriteLine($"{endLine}Кількість фільмів (Фентезі) з роком випуску між 2000 та 2012: " + count);
foreach (var movie in selectedMovies)
	Console.WriteLine($"{movie.Name} ({movie.Year}) - {movie.Author}, {movie.Category}");

Console.WriteLine();

#endregion

#region Task4

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №4{endLine}");
Console.ForegroundColor = ConsoleColor.White;

var domains = new List<string> {
	"gmail.com",
	"mail.ru",
	"yahoo.com",
	"ukr.net",
	"example.com",
	"hotmail.com",
	"mail.com",
	"meta.ua",
	"outlook.com",
	"icloud.com"
};

Console.WriteLine($"Список доменів: {string.Join(", ", domains)}{endLine}");

var selectedDomains = domains.Where(d => d is "gmail.com" or "mail.ru");

Console.WriteLine($"Відібрані домени: {string.Join(", ", selectedDomains)}{endLine}");

#endregion

#region Task5

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №5{endLine}");
Console.ForegroundColor = ConsoleColor.White;

int[] numbers = [52, 42, 54, 38, 25, 55, 78];
Console.WriteLine($"Є масив чисел: [{string.Join(", ", numbers)}]{endLine}");
Console.WriteLine($"За допомогою методу Average() знайдемо середнє арифметичне.{endLine}" +
                  $"Середнє арифметичне значення елементів масиву: {numbers.Average()}{endLine}");

#endregion

#region Task6

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №6{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine($"Використовуючи масив чисел з попередньої задачі відберемо 4 числа, починаючи з другого{endLine}");

var selectedNumbers = numbers.Skip(1).Take(4);

Console.WriteLine($"Для цього використаэмо методи Skip() та Take(){endLine}" +
                  $"Отриманий результат: [{string.Join(", ", selectedNumbers)}]{endLine}");

#endregion

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();