namespace SQ05Week1.Fundamental.OOP;
#nullable disable

public class Car : BaseEntity
{
    //Properties
    public string Make { get; set; }
    public string Year { get; set; }
    public int Doors { get; set; }
    public int Tyres { get; set; }


    //Field
    int myTyres;

    //Methods

    public override void MoveIt()
    {
        Console.WriteLine("Method is overriden in Car class.");
    }
    public void Move()
    {
        Console.WriteLine("car is moving.");
    }

    public void Hoot()
    {
        Console.WriteLine("Honking hooking!!");
    }

    public void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }

    public static int Addition(int a, int b)
    {
        return a + b;
    }

    public static int Addition(int a, int b, int c)
    {
        return a + b + c;
    }
    public static int Addition(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static int Addition(int a, float b)
    {
        return a + (int)b;
    }

    public static int Addition(float b, int a)
    {
        return (int)b + a;
    }
}
