using System.Text;
using Lab5.Models;

const string endLine = "\r\n"; 
// Для коректного відображення символів на консолі та читання даних
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

#region Task1 and Task2

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №1 і №2{endLine}");
Console.ForegroundColor = ConsoleColor.White;

var tree = new Tree("Яблуня", "Звичайне дерево");
var flower = new Flower("Троянда", "Звичайна квітка");

Console.WriteLine($"Найменування дерева: {tree.Name}{endLine}" +
                  $"Опис дерева: {tree.About}{endLine}" +
                  $"Ціна за одиницю: {tree.GetPrice()} грн.{endLine}" +
                  $"В наявності на складі: {tree.Count()} шт.{endLine}");


Console.WriteLine($"Найменування квітки: {flower.Name}{endLine}" +
                  $"Опис квітки: {flower.About}{endLine}" +
                  $"Ціна за одиницю: {flower.GetPrice()} грн.{endLine}" +
                  $"В наявності на складі: {flower.Count()} шт.{endLine}");

#endregion

#region Task3

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Завдання №3{endLine}");
Console.ForegroundColor = ConsoleColor.White;

var currentAccount = new CurrentAccount("Основний", 1000);
currentAccount.CreateAccount(currentAccount.AccountName);
currentAccount.AddToAccount(500);
currentAccount.TakeFromAccount(2000);
currentAccount.TakeFromAccount(1000);
currentAccount.DeleteAccount();

Console.WriteLine();

var depositAccount = new DepositAccount("Банка", 5000);
depositAccount.CreateAccount(depositAccount.AccountName);
depositAccount.AddToAccount(1000);
depositAccount.TakeFromAccount(6000);
depositAccount.DeleteAccount();

Console.WriteLine();

#endregion

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Дякуємо за увагу. Натисніть на будь яку клавішу, щоб завершити роботу");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();