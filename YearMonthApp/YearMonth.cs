namespace YearMonthApp
{
    public class YearMonth
    {
        public int Year { get; set; }
        public List<int> Months { get; set; } = new List<int>();
        /// <summary>
        /// This Methode Return each year with Months as List Of int Data type
        /// </summary>
        /// <param name="FirestDateTime"></param>
        /// <param name="SecoundDate"></param>
        /// <returns></returns>
        public static Dictionary<int, List<int>> GetYearWithListMonths(DateTime firstDateTime, DateTime secondDate)
        {
            var yearMonths = new Dictionary<int, List<int>>();
            
            DateTime smallest = firstDateTime < secondDate ? firstDateTime : secondDate;
            DateTime biggest = firstDateTime > secondDate ? firstDateTime : secondDate;
            
            int currentYear = smallest.Year;
            int currentMonth = smallest.Month;
            
            while (currentYear <= biggest.Year)
            {
                if (!yearMonths.ContainsKey(currentYear))
                    yearMonths[currentYear] = new List<int>();
                
                yearMonths[currentYear].Add(currentMonth);
                
                currentMonth++;
                
                if (currentMonth > 12)
                {
                    currentMonth = 1;
                    currentYear++;
                }

                if (currentYear > biggest.Year || (currentYear == biggest.Year && currentMonth > biggest.Month))
                    break;
            }

            return yearMonths;
        }
    }
}