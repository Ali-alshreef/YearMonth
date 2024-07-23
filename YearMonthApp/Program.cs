using YearMonthApp;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt1 = new DateTime(2020, 06, 23);
        DateTime dt2 = new DateTime(2024, 8, 29);

        var yearMonths = YearMonth.GetYearWithListMonths(dt1, dt2);

        Console.WriteLine("First Date = {0}", dt1.Date);
        Console.WriteLine();
        Console.WriteLine("Second Date = {0}", dt2.Date);
        Console.WriteLine();
        Console.WriteLine("=============================================================");
        foreach (var kvp in yearMonths)
        {
            Console.WriteLine($"Year => {kvp.Key}");
            foreach (var month in kvp.Value)
            {
                Console.Write($"{month} ");
            }
            Console.WriteLine();
        }
    }
}