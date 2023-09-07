namespace _1.Anatomy;


public class Person
{
    public void Display()
    {
        Console.WriteLine("Displaying the person");
    }

    public void PrintData(string name, int age, double height)
    {
        Console.WriteLine($"Name: {name}  Age: {age}  Height: {height:#.##}");
    }
}



public class Program
{
    static void Main(string[] args)
    {
        var p = new Person();

        p.Display();

        p.PrintData("Sam", 30, 2.026345);
    }
}