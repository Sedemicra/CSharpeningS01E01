using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpeningS01E01
{
    /// <summary>
    /// CSharpening S01E01 exercise part 2.
    /// </summary>
    sealed class ExerciseP2
    {
        private static bool IsValidEmail(string targetEmail)
        {
            try
            {
                var email = new System.Net.Mail.MailAddress(targetEmail);
                // A comparison for just to have a value to return and just in case the untinkable happens and the method modifies the input.
                return email.Address == targetEmail;
            }
            catch
            {
                return false;
            }
        }

        public static void EmailVerifier()
        {
            Console.Write("Enter an email address for verification: ");
            var email = Console.ReadLine();

            // Validation 1 seems to be a basic check that some types of invalid emails can pass
            Console.Write("Validation 1: ");
            if (new EmailAddressAttribute().IsValid(email))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            // Validation 2 seems to be more strict validation
            Console.Write("Validation 2: ");
            if (IsValidEmail(email))
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
