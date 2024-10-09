using System.Text;
using Lab2.Abstract.Models;

// Для коректного відображення символів на консолі
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Реалізація з абстракцією\r\n");

var toy = new Toy("М'яка іграшка", "Плюшевий ведмедик", 10, "Коричневий");
toy.VirtualMethod1();
toy.VirtualMethod2();
var toysPrice = toy.GetPrice(toy.Count);
Console.WriteLine($"Вартість усіх іграшок: {toysPrice} грн");
toy.GetInfo();

Console.WriteLine("\r\n---------------------------\r\n");

var products = new Products("Яблука", "Фрукти", "Перший", 100);
products.VirtualMethod1();
products.VirtualMethod2();
products.GetPrice();

Console.WriteLine("Натисніть щоб завершити роботу");
Console.ReadKey();