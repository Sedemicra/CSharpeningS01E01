using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpeningS01E01
{
    sealed class ExerciseP2
    {
        /// <summary>
        /// Validate email format.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Boolena value of email validity.</returns>
        private static bool IsValidEmail(string targetEmail)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(targetEmail);
                return email.Address == targetEmail;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// CSharpening S01E01 exercise part 2.
        /// </summary>
        public static void EmailVerifier()
        {
            Console.Write("Enter an email address for verification: ");
            var email = Console.ReadLine();

            Console.Write("Validation 1: ");
            if (IsValidEmail(email))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            Console.Write("Validation 2: ");
            if (new EmailAddressAttribute().IsValid(email))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
