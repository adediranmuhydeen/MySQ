using SQ05Week1.Fundamental.Models;
using SQ05Week1.Fundamental.OOP;
using SQ05Week3.Entities;
//using SQ05Week3;

//Console.BackgroundColor = ConsoleColor.DarkGreen;
//Console.ForegroundColor = ConsoleColor.White;

//var myAnimal = new Animal 
//{
//    Legs = 4,
//    Eyes =2,
//    Mouth = 1,
//    Name = "Dog"
//};
//var myCat = new Cat();

//myCat.Legs = 4;
//myCat.Eyes = 2;
//myCat.Mouth = 1;
//myCat.WiskerColor = "Orange";
//myCat.HasClaws = true;
//myCat.Name = "Tommy";

//myCat.GetAnimalName();

//Console.WriteLine(Car.Addition(10, 3, 10));
////This throws compile time error because BaseEntity is an abstract class and cannot be instantiated
////var BaseEntity = new BaseEntity();

//bool CheckEven(int num)
//{
//    return num % 2 == 0;
//}

//Console.WriteLine(CheckEven(3));


//var myEntity  = new Entity();

var mySample = new Sample();


var myCar = new Car
{
    Make = "Toyota",
    Year = "2020",
    Doors = 4,
    Tyres = 4
};

//var firstStudent = new Student(1, "Shukuroh", "Lawal");

Dictionary<string, string> newDictionary = new Dictionary<string, string>
{
};

var names = new List<string> {"Shukuroh", "Fatimoh", "Aisha" };

foreach(string name in names)
{
    Console.WriteLine(name);
}

names.Insert(0, "Muhydeen");

Console.WriteLine(names.LastIndexOf("Fatimoh"));


var students = new List<Student>
{
    new Student(1, "Shukuroh", "Lawal", 16),
    new Student(2, "Fatimoh", "Lawal", 17),
    new Student(3, "Aisha", "Ajose", 18),
    new Student(4, "Jamal", "Ajose", 19),
    new Student(5, "Abdulrahman", "Lawal", 20)
};

var underAged = students.Where(x => x.Age > 17);

Console.WriteLine(underAged.Count());

var lawals = students.Where(x => x.LastName == "Lawal").Select(a => new {a.FirstName, a.LastName, a.Age}).ToList();

var lawals2 = from student in students
              where student.LastName == "Lawal"
              select new { student.FirstName, student.LastName, student.Age };

Console.WriteLine(lawals[0].FirstName);

var olderLawals = students.Where(x => x.LastName == "Lawal" && x.Age > 16).ToList();
Console.WriteLine(olderLawals.Count);


List<int> myNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Console.WriteLine(myNumber.Average());
Console.WriteLine(myNumber.Sum());
Console.WriteLine(myNumber.Max());
Console.WriteLine(myNumber.Min());