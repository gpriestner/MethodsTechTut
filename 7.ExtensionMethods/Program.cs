namespace _7.ExtensionMethods;

public static class StringExtensions
{
    public static string Left(this string str, int length)
    {
        if (length >= str.Length) return str;
        else return str.Substring(0, length);
    }

}

public class Program
{
    static void Main(string[] args)
    {
        string name = "Geoffrey";

        string shortName = name.Left(5);

        Console.WriteLine(shortName);
    }
}