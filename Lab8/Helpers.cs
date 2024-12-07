namespace Lab8;

internal class Helpers {
	/// <summary>
	/// Метод для F(x) = 1 / x, x більше 0
	/// </summary>
	/// <param name="x">Значення</param>
	/// <returns>Результат</returns>
	internal static double FunctionPositive(double x) => 1 / x;

	/// <summary>
	/// Метод для F(x) = x^2 + 2 * x + 4, x менше 0
	/// </summary>
	/// <param name="x">Значення</param>
	/// <returns>Результат</returns>
	internal static double FunctionNegative(double x) => x * x + 2 * x + 4;

	/// <summary>
	/// Метод для F(x) = 4, x = 0
	/// </summary>
	/// <param name="x">Значення</param>
	/// <returns>Результат</returns>
	internal static double FunctionZero(double x) => 4;

	/// <summary>
	/// Делегат для обчислення функції
	/// </summary>
	/// <param name="x">Значення</param>
	/// <returns>Результат</returns>
	internal delegate double FunctionDelegate(double x);

	/// <summary>
	/// Делегат, що приймає ціле число (n) і повертає обчислене число (double використовується для універсальності)
	/// </summary>
	/// <param name="n">Значення</param>
	/// <returns>Результат</returns>
	internal delegate double MathOperation(int n);

	/// <summary>
	/// Метод обчислення числа Фібоначчі F(n) <br/>
	/// F1 = 1; F2 = 1; для k > 2: Fk = Fk-1 + Fk-2
	/// </summary>
	/// <param name="n">Значення</param>
	/// <returns>Результат</returns>
	internal static double Fibonacci(int n) {
		if (n is 1 or 2)
			return 1;

		double f1 = 1;
		double f2 = 1;
		double f = 0;

		for (var i = 3; i <= n; i++) {
			f = f1 + f2;
			f1 = f2;
			f2 = f;
		}

		return f;
	}

	/// <summary>
	/// Метод обчислення n-го парного числа
	/// Парні числа: 2, 4, 6, 8, ...
	/// n-те парне число = 2 * n
	/// </summary>
	/// <param name="n">Значення</param>
	/// <returns>Результат</returns>
	internal static double EvenNumber(int n) => 2 * n;

	/// <summary>
	/// Універсальний делегат для арифметичної операції
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="a">Число №1</param>
	/// <param name="b">Число №2</param>
	/// <returns>Результат</returns>
	internal delegate T Operation<T>(T a, T b);

	/// <summary>
	/// Операція додавання
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="x">Значення №1</param>
	/// <param name="y">Значення №2</param>
	/// <returns>Результат операції</returns>
	private static T Add<T>(T x, T y) => (dynamic)x + (dynamic)y;

	/// <summary>
	/// Операція віднімання
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="x">Значення №1</param>
	/// <param name="y">Значення №2</param>
	/// <returns>Результат операції</returns>
	private static T Sub<T>(T x, T y) => (dynamic)x - (dynamic)y;

	/// <summary>
	/// Операція множення
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="x">Значення №1</param>
	/// <param name="y">Значення №2</param>
	/// <returns>Результат операції</returns>
	private static T Mul<T>(T x, T y) => (dynamic)x * (dynamic)y;

	/// <summary>
	/// Операція ділення
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="x">Значення №1</param>
	/// <param name="y">Значення №2</param>
	/// <returns>Результат операції</returns>
	private static T Div<T>(T x, T y) => (dynamic)y == 0 
		                                     ? (T)(dynamic)0
		                                     : (T)((dynamic)x / (dynamic)y);

	/// <summary>
	/// Допоміжний метод для отримання делегата відповідної операції
	/// </summary>
	/// <typeparam name="T">Тип даних</typeparam>
	/// <param name="op">Тип операції</param>
	/// <returns>Результат операції</returns>
	internal static Operation<T>? GetOperation<T>(string op) =>
		op switch {
			"+" => Add,
			"-" => Sub,
			"*" => Mul,
			"/" => Div,
			_ => null
		};
}