namespace _2.NamedArguments;

public class Demo
{
    public static void PrintData(string name, int age, double height)
    {
        Console.WriteLine($"Name: {name}  Age: {age}  Height: {height:#.##}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Demo.PrintData("Sam", 30, 2.026345);

        Demo.PrintData(age: 20, height: 1.99, name: "Jo");
    }
}