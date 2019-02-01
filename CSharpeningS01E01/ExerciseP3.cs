using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpeningS01E01
{
    /// <summary>
    /// CSharpening S01E01 exercise part 3.
    /// </summary>
    sealed class ExerciseP3
    {
        /// <summary>
        /// Version 1.
        /// </summary>
        public static void NumbersSummation()
        {
            Console.Write("Insert comma separated numbers for summation: ");
            try
            {
                var input = Console.ReadLine().Split(',');
                var numbersArray = Array.ConvertAll(input, decimal.Parse);
                Console.WriteLine($"The sum of entered numbers is: {numbersArray.Sum()}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was invalid. Please use only numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }

        /// <summary>
        /// Version 2.
        /// </summary>
        public static void NumbersSummation2()
        {
            Console.WriteLine("Insert numbers one by one for summation. Entering empty value ends input process and returns the sum.");
            var numbersList = new List<decimal>();
            while (true)
            {
                Console.Write(">");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                if (!decimal.TryParse(input, out var number))
                {
                    Console.WriteLine($"Invalid input. Please use only numbers below {decimal.MaxValue}");
                }
                numbersList.Add(number);
            }
            try
            {
                Console.WriteLine($"The sum of entered numbers is: {numbersList.Sum()}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The sum exeeds the capabilities of this app.");
            }
        }
    }
}
