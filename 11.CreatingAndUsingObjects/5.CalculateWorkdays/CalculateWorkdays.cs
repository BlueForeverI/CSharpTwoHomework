using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.CalculateWorkdays
{
    class CalculateWorkdays
    {
        static int GetNumberOfWorkdays(DateTime endDate)
        {
            //month = key, day = value
            KeyValuePair<int, int>[] publicHolidays = {new KeyValuePair<int, int>(1, 1),
                                                       new KeyValuePair<int, int>(3, 3),
                                                       new KeyValuePair<int, int>(5, 6),
                                                       new KeyValuePair<int, int>(5, 24),
                                                       new KeyValuePair<int, int>(9, 6),
                                                       new KeyValuePair<int, int>(9, 22),
                                                       new KeyValuePair<int, int>(12, 25),
                                                       new KeyValuePair<int, int>(12, 31), };

            DateTime startDate = DateTime.Now;
            int count = 0;

            for (; startDate.Date <= endDate.Date; startDate = startDate.AddDays(1))
            {
                if(startDate.DayOfWeek >= DayOfWeek.Monday && startDate.DayOfWeek <= DayOfWeek.Friday)
                {
                    bool isHoliday = false;
                    foreach (var holiday in publicHolidays)
                    {
                        if (startDate.Month == holiday.Key && startDate.Day == holiday.Value)
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if(!isHoliday)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter end date: ");
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            int workdays = GetNumberOfWorkdays(endDate);
            Console.WriteLine("From now to {0} there are {1} workdays",
                endDate, workdays);

            Console.ReadLine();
        }
    }
}
