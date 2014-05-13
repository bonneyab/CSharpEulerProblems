using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems
{
    //TODO: This is all a bit messy but...functional maybe give it some love if I get bored later
    //Note: I considered using the regular old datetime to be cheating.
    //You are given the following information, but you may prefer to do some research for yourself.

    //1 Jan 1900 was a Monday.
    //Thirty days has September,
    //April, June and November.
    //All the rest have thirty-one,
    //Saving February alone,
    //Which has twenty-eight, rain or shine.
    //And on leap years, twenty-nine.
    //A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    //How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    public class Problem19
    {
        public int GetTotalSundays()
        {
            var date = new MyOwnDate {Month = 1, DayOfWeek = 1, Year = 1900, DayOfMonth = 1};
            while (date.Year < 1901)
            {
                date.MoveToNextDay();
            }
            int totalSundays = 0;
            while (date.Year < 2001)
            {
                date.MoveToNextDay();
                if (date.DayOfMonth == 1 && date.DayOfWeek == 7)
                    totalSundays++;
            }
            return totalSundays;
        }
    }

    public class MyOwnDate
    {
        public MyOwnDate()
        {
			//TODO: this dictionary really isn't needed.
            Dictionary<int, int> monthMap = new Dictionary<int, int>();
            monthMap.Add(1, 31);
            monthMap.Add(2, 28);
            monthMap.Add(3, 31);
            monthMap.Add(4, 30);
            monthMap.Add(5, 31);
            monthMap.Add(6, 30);
            monthMap.Add(7, 31);
            monthMap.Add(8, 31);
            monthMap.Add(9, 30);
            monthMap.Add(10, 31);
            monthMap.Add(11, 30);
            monthMap.Add(12, 31);

            DaysInMonths = new Dictionary<int, Func<int>>();
            foreach (var month in Enumerable.Range(1, 12))
            {
                if (month == 2)
                {
                    DaysInMonths.Add(month, () => IsLeapYear(Year) ? 29 : 28);
                    continue;
                }
                DaysInMonths.Add(month, () => monthMap[month]);
            }
        }
        public Dictionary<int, Func<int>> DaysInMonths { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }
        public int DayOfMonth { get; set; }
        public int DayOfWeek { get; set; }

        public void MoveToNextDay()
        {
            if (DayOfWeek < 7)
                DayOfWeek++;
            else DayOfWeek = 1;
            if (DayOfMonth < DaysInMonths[Month].Invoke())
            {
                DayOfMonth++;
            }
            else
            {
                DayOfMonth = 1;
                if (Month < 12)
                {
                    Month++;
                }
                else
                {
                    Year++;
                    Month = 1;
                }
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            return year % 4 == 0;
        }
    }
}
