using System;

namespace CSharpeningS01E01
{
    /// <summary>
    /// CSharpening S01E01 exercise part 1.
    /// </summary>
    sealed class ExerciseP1
    {
        private static bool IsLeapYearStartingWithTuesday(int year)
        {
            if (!DateTime.IsLeapYear(year))
            {
                return false;
            }
            var firstDayOfTheYear = new DateTime(year, 1, 1).DayOfWeek;
            if (firstDayOfTheYear != DayOfWeek.Tuesday)
            {
                return false;
            }
            return true;
        }

        public static void DateTask()
        {
            // Current date (year, month, day only)
            Console.WriteLine($"Current date: {DateTime.Now.ToShortDateString()}");

            // Number of days elapsed since start of the year
            var firstDayOfTheYear = new DateTime(DateTime.Now.Year, 1, 1);
            var elapsedTime = DateTime.Now - firstDayOfTheYear;
            Console.WriteLine($"Days elapsed since start of the year: {elapsedTime.TotalDays:N2}");

            // What is the next leap year that starts with a Tuesday
            var year = DateTime.Now.Year;
            do
            {
                year++;
            } while (!IsLeapYearStartingWithTuesday(year));
            Console.WriteLine($"The next leap year starting with Tuesday is: {year}");
        }
    }
}
