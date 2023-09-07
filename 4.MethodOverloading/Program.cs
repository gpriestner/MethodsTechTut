namespace _4.MethodOverloading;

public class Demo
{
    public static void Print(string val)
    {
        Console.WriteLine($"Value: {val}");
    }
    public static void Print(int val)
    {
        Console.WriteLine($"Value: {val}");
    }
    public static void Print(double val)
    {
        Console.WriteLine($"Value: {val}");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Demo.Print("Hello world");

        Demo.Print(42);

        Demo.Print(3.141592);
    }
}