namespace _6.VariadicMethods;

public class Demo
{
    public static void UseParams(string required, params int[] list)
    {
        Console.WriteLine(required);
        foreach (int i in list) Console.WriteLine(i);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Demo.UseParams("test", 2, 4, 6, 8, 10);

        var array = new int[] { 1, 3, 5, 7, 9 };
        Demo.UseParams("array", array);
    }
}