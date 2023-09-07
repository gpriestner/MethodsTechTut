namespace _8.OperatorOverloading;

public class Date
{
    private int day, month, year;

    public Date(int d, int m, int y)
    {
        day = d; month = m; year = y;
    }
    public Date AddOneDay()
    {
        int d = day + 1;
        int m = month;
        int y = year;
        if (d > Date.GetDaysInMonth(m, y))
        {
            m++;
            d = 1;
        }
        if (m > 12)
        {
            y++;
            m = 1;
        }
        return new Date(d, m, y);
    }
    public static Date operator +(Date lhs, int rhs)
    {
        Date newDate = lhs;
        for (int i = 0; i < rhs; i++) newDate = newDate.AddOneDay();
        return newDate;
    }
    public static int GetDaysInMonth(int month, int year)
    {
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);

        TimeSpan duration = firstDayOfNextMonth - firstDayOfMonth;
        int daysInMonth = duration.Days;

        return daysInMonth;
    }
    public override string ToString() => $"{day:00}/{month:00}/{year:0000}";
}

public class Program
{
    static void Main(string[] args)
    {
        Date d = new Date(28, 2, 2024);

        d = d + 2;
        //d += 22;

        Console.WriteLine(d);
    }
}