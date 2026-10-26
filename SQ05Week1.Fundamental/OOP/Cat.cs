namespace SQ05Week1.Fundamental.OOP;

public class Cat : Animal
{
    public string WiskerColor { get; set; }
    public bool HasClaws { get; set; }

    public void Hunt()
    {
        Console.WriteLine("Cat is hunting.");
    }
}
