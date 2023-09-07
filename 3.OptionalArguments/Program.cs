namespace _3.OptionalArguments;

public class Demo
{
    public static void Error(string text, int severity = 0, bool terminate = false)
    {
        Console.WriteLine($"Text: {text}  Severity: {severity}  Terminate: {terminate}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Demo.Error("File failure");

        Demo.Error("Retry read", 5);

        Demo.Error("Corruption", 3, true);
    }
}