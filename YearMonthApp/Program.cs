using YearMonthApp;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt1 = new DateTime(2020, 06, 23);
        DateTime dt2 = new DateTime(2024,8,29);

       var yearMonths = YearMonth.GetYearWithListMonts(dt1,dt2);

        Console.WriteLine("Firest Date = {0}",dt1.Date);
        Console.WriteLine();
        Console.WriteLine("Secound Date = {0}",dt2.Date);
        Console.WriteLine();
        Console.WriteLine("=============================================================");
        foreach (YearMonth yearMonth in yearMonths)
        {
            Console.WriteLine(" Year => {0} ",yearMonth.Year);
            foreach (int month in yearMonth.Months)
            {
                Console.Write(" {0} ", month);
            }
            Console.WriteLine();
        }
    }
}