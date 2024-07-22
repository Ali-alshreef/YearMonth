using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearMonthApp;

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
        public static List<YearMonth> GetYearWithListMonts(DateTime FirestDateTime, DateTime SecoundDate)
        {
            List<YearMonth> YearMonths = new List<YearMonth>();
            if (FirestDateTime != SecoundDate)
            {
                List<int> Months;
                int currentYear = 0;
                int countOfYears = 0;
                int currentMonth = 0;
                int countOfMonth = 0;

                DateTime Smallest = FirestDateTime < SecoundDate ? FirestDateTime : SecoundDate;
                DateTime Biggest = FirestDateTime > SecoundDate ? FirestDateTime : SecoundDate;

                currentYear = Smallest.Year;
                countOfYears = Biggest.Year - Smallest.Year; // for years
                countOfMonth = 12 - Smallest.Month;
                currentMonth = Smallest.Month;
                for (int i = 0; i <= countOfYears; i++)
                {
                    Months = new List<int>();
                    for (int j = 0; j <= countOfMonth; j++)
                    {
                        if (currentMonth <= 12)
                        {
                            Months.Add(currentMonth);
                            currentMonth += 1;
                        }
                    }
                    currentYear += 1;
                    currentMonth = 1;
                    countOfMonth = currentYear == Biggest.Year ? Biggest.Month - 1 : 12;
                    YearMonths.Add(new YearMonth { Year = currentYear - 1, Months = Months });
                }
            }
            return YearMonths;
        }
    }
}