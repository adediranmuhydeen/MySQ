namespace SQ05Week1.Fundamental.OOP;

public class Animal : BaseEntity
{
    public int Legs { get; set; }
    public int Eyes { get; set; }
    public int Mouth { get; set; }
    public string  Name { get; set; }

    public void Move()
    {
        Console.WriteLine("Animal is moving.");
    }
    public override void MoveIt()
    {
        Console.WriteLine("Method is overriden in Animal class.");
    }
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void  GetAnimalName()
    {
        Console.WriteLine(Name);
    }


}
