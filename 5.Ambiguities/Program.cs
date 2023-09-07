namespace _5.Ambiguities;


public class Demo
{
    public static void CalcBalance(int v1, double v2)
    {

    }
    public static void CalcBalance(long v1, float v2) 
    { 
    
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Demo.CalcBalance(500, 11.5);

        // Demo.CalcBalance(250, 10.5F);

        // Demo.CalcBalance(500000L, 45.5);

        // Console.WriteLine($"LONG: {sizeof(double)}");
    }
}