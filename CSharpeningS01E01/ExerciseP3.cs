using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpeningS01E01
{
    sealed class ExerciseP3
    {
        /// <summary>
        /// CSharpening S01E01 exercise part 3 version 1.
        /// </summary>
        public static void NumbersSummation()
        {
            Console.Write("Insert comma separated numbers for summation: ");
            try
            {
                var input = Console.ReadLine().Split(',');
                var listOfNumbers = Array.ConvertAll(input, decimal.Parse).ToList();
                Console.WriteLine($"The sum of entered numbers is: {listOfNumbers.Sum()}");
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
        /// CSharpening S01E01 exercise part 3 version 2.
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
                    Console.WriteLine("Invalid input. Please use numbers only.");
                }
                numbersList.Add(number);
            }
            Console.WriteLine($"The sum of entered numbers is: {numbersList.Sum()}");
        }
    }
}
