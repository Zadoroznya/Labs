using System.Text;
using static Lab8.Helpers;

const string endLine = "\r\n";
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task1

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1. Просте використання делегатів{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введіть значення x: ");

var input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
	Console.WriteLine($"Потрібно було ввести число{endLine}");
else {
	if (!double.TryParse(input, out var x))
		Console.WriteLine($"Потрібно було ввести дійсне число{endLine}");
	else {
		// Вибір делегату для обчислення функції
		FunctionDelegate selectedFunction = x switch {
			> 0 => FunctionPositive,
			< 0 => FunctionNegative,
			_ => FunctionZero
		};

		// Виклик обраного методу через делегат
		var result = selectedFunction(x);
		Console.WriteLine($"F({x}) = {result}{endLine}");
	}
}

#endregion

#region Task2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №2. Групове перетворення методів, що делегуються{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.Write($"Оберіть дію:{endLine}" +
                  $"1 - Обчислити n-те число Фібоначчі{endLine}" +
                  $"2 - Обчислити n-те парне число{endLine}{endLine}" +
				  $"Введіть 1 або 2: ");

var choice = Console.ReadLine();

if (string.IsNullOrWhiteSpace(choice)) {
	Console.WriteLine($"Потрібно було ввести число.{endLine}");
}
else {
	var isCorrect = choice switch {
		"1" => true,
		"2" => true,
		_ => false
	};

	if (!isCorrect)
		Console.WriteLine($"Невірний вибір{endLine}");
	else {
		Console.Write("Введіть n (натуральне число): ");
		var inputN = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(inputN) || !int.TryParse(inputN, out var n) || n <= 0)
			Console.WriteLine($"Потрібно було ввести натуральне число.{endLine}");
		else {
			MathOperation? operation = choice switch {
				"1" => Fibonacci,
				"2" => EvenNumber,
				_ => null
			};

			Console.WriteLine(operation == null
				                  ? $"Невірний вибір.{endLine}"
				                  : $"Результат: {operation(n)}{endLine}");
		}
	}
}

#endregion

#region Task3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №3. Універсальні делегати{endLine}");
Console.ForegroundColor = ConsoleColor.White;

Console.Write($"Оберіть тип чисел:{endLine}" +
              $"1 - Цілі числа{endLine}" +
              $"2 - Дійсні числа{endLine}{endLine}" +
              $"Введіть 1 або 2: ");

var typeChoice = Console.ReadLine();

if (string.IsNullOrWhiteSpace(typeChoice))
	Console.WriteLine($"Необхідно ввести число.{endLine}");
else {
	var isCorrect2 = typeChoice switch {
		"1" => true,
		"2" => true,
		_ => false
	};

	if (!isCorrect2)
		Console.WriteLine($"Невірний вибір{endLine}");
	else {
		Console.Write("Введіть перше число: ");
		var inputA = Console.ReadLine();

		Console.Write("Введіть друге число: ");
		var inputB = Console.ReadLine();

		Console.Write("Введіть операцію (+, -, *, /): ");
		var op = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB) || string.IsNullOrWhiteSpace(op))
			Console.WriteLine("Необхідно було ввести повні дані.");
		else
			switch (typeChoice) {
				case "1": {
					// Цілі числа
					if (!int.TryParse(inputA, out var aInt) || !int.TryParse(inputB, out var bInt))
						Console.WriteLine($"Необхідно ввести цілі числа.{endLine}");
					else {
						var operation = GetOperation<int>(op);
						if (operation == null)
							Console.WriteLine($"Невідома операція.{endLine}");
						else
							try {
								Console.WriteLine($"Результат: {operation(aInt, bInt)}");
							}
							catch (DivideByZeroException) {
								Console.WriteLine($"Ділення на нуль!{endLine}");
							}
					}

					break;
				}
				case "2": {
					// Дійсні числа
					if (!double.TryParse(inputA, out var aDouble) || !double.TryParse(inputB, out var bDouble))
						Console.WriteLine($"Необхідно ввести дійсні числа.{endLine}");
					else {
						var operation = GetOperation<double>(op);
						if (operation == null)
							Console.WriteLine($"Невідома операція.{endLine}");
						else
							try {
								Console.WriteLine($"Результат: {operation(aDouble, bDouble)}");
							}
							catch (DivideByZeroException) {
								Console.WriteLine($"Ділення на нуль!{endLine}");
							}
					}

					break;
				}
				default:
					Console.WriteLine($"Невірний вибір типу чисел.{endLine}");
					break;
			}
	}
}

#endregion

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();