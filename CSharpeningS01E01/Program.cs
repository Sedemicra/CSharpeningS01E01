using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CSharpeningS01E01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSharpening S01E01 exercise divided into the following parts:");
            Console.WriteLine("1 - Date task.");
            Console.WriteLine("2 - Email address verifier.");
            Console.WriteLine("3.1 - Numbers list summation.");
            Console.WriteLine("3.2 - Numbers list summation v2 (amount of input numbers not limited by console input limit).");

            do
            {
                Console.Write("Call the part by writing part number e.g. '3.1': ");
                switch (Console.ReadLine())
                {
                    case "1":
                        ExerciseP1.DateTask();
                        break;
                    case "2":
                        ExerciseP2.EmailVerifier();
                        break;
                    case "3.1":
                        ExerciseP3.NumbersSummation();
                        break;
                    case "3.2":
                        ExerciseP3.NumbersSummation2();
                        break;
                    default:
                        Console.WriteLine("Press ESC key to exit or ENTER to continue.");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
