using SQ05Week1.Fundamental.OOP;

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.White;

var myAnimal = new Animal 
{
    Legs = 4,
    Eyes =2,
    Mouth = 1,
    Name = "Dog"
};
var myCat = new Cat();

myCat.Legs = 4;
myCat.Eyes = 2;
myCat.Mouth = 1;
myCat.WiskerColor = "Orange";
myCat.HasClaws = true;
myCat.Name = "Tommy";

myCat.GetAnimalName();

Console.WriteLine(Car.Addition(10, 3, 10));

var BaseEntity = new BaseEntity();
