using System.Text;
using Lab1.Models;

// Для коректного відображення символів на консолі
Console.OutputEncoding = Encoding.UTF8;

#region Task 1

var student = new StudentModel("Іван", 20, 3, 95.5);

student.GetStudentInfo();

student.StudentRating();

student.GetRole();

student.EditStudent("Петро", 21, 98.0);

student.StudentRating();


#endregion

#region Task2

var product = new ProductModel {
	Type = "Цукерка",
	Name = "Корівка",
	Manufacturer = "Рошен",
	Price = 45
};

product.GetInfo();

product.CalculateCost();

product.UpdateProduct("Шоколад", "Корона", "Монделіс", 60);

product.CalculateCost();

#endregion

Console.WriteLine("Натисніть щоб завершити роботу");
Console.ReadKey();