using ClassRoom_10.Controllers;
using ClassRoom_10.Models;
using ClassRoom_10.Services;


//GetFiltredStudents();
//StudenAge();
//Car car = new();
//car.color = "red";
//car.Vin = "salam";
//car.Year = 2022;
//car.speed = 500;
//Console.WriteLine(car.speed);
//Console.WriteLine(car.Vin);
//Console.WriteLine(car.color);

//StudentController studentController = new();
//studentController.GetFiltredStudents();
//studentController.StudenAge();

BookController bookController = new BookController();
//bookController.GetAllByAuthor();
//bookController.GetById();
bookController.Search();
