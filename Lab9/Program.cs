using System.Text;

const string endLine = "\r\n";
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task1

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1. Одиничні лямбда-вирази{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введіть значення x: ");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
	Console.WriteLine($"Потрібно було ввести хоч щось{endLine}");
else {
	if (!double.TryParse(input, out var x))
		Console.WriteLine($"Потрібно було ввести дійсне число{endLine}");
	else {
		// Одиничні лямбда-вирази
		Func<double, double> positiveFunc = val => 1 / val;
		Func<double, double> negativeFunc = val => val * val + 2 * val + 4;
		Func<double, double> zeroFunc = _ => 4;

		var result = x switch {
			> 0 => positiveFunc(x),
			< 0 => negativeFunc(x),
			_ => zeroFunc(x)
		};

		Console.WriteLine($"F({x}) = {result}{endLine}");
	}
}

#endregion

#region Task2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №2. Одиничні лямбда-вирази в делегаті Funс{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Func<int, int, int> squareOfProduct = (x, y) => (x * y) * (x * y);

var a = Random.Shared.Next(2,12);
var b = Random.Shared.Next(2, 12);

Console.WriteLine($"Число №1: {a}{endLine}" +
                  $"Число №2: {b}{endLine}");

var result2 = squareOfProduct(a, b);

Console.WriteLine($"Використаємо Func<int, int, int> squareOfProduct = (x, y) => (x * y) * (x * y);{endLine}" +
                  $"Квадрат добутку чисел {a} та {b} дорівнює {result2}.{endLine}");

#endregion

#region Task3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №3. Одиничні лямбда-вирази в делегаті Predicate{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введіть щось: ");
var inputTask3 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(inputTask3))
	Console.WriteLine("Ви нічого не ввели");
else {
	// Лямбда-вираз для перевірки, чи є рядок числом
	Predicate<string> isNumber = s => double.TryParse(s, out _);

	Console.WriteLine(isNumber(inputTask3)
		                  ? $"Це число.{endLine}"
		                  : $"Це не число.{endLine}");
}

#endregion

#region Task4

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №4. Блокові лямбда-вирази{endLine}");
Console.ForegroundColor = ConsoleColor.White;

var random = new Random();

// Створення масиву з 10 випадкових цілих чисел. Діапазон від -50 до 50
var numbers = new int[10];
for (var i = 0; i < numbers.Length; i++)
	numbers[i] = random.Next(-50, 51);

// Вивід згенерованого масиву на консоль для наочності
Console.WriteLine($"Згенерований масив:{endLine}" +
                  $"[{string.Join(", ", numbers)}]{endLine}");

// Блоковий лямбда-вираз для перевірки, чи число додатнє
Func<int, bool> isPositive = x => x > 0;
Console.WriteLine("Використаємо Func<int, bool> isPositive = x => x > 0;");

foreach (var number in numbers) {
	var resultTask4 = isPositive(number);
	Console.WriteLine(resultTask4
		                  ? $"Число {number} є додатнім."
		                  : $"Число {number} не є додатнім.");
}

#endregion

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();