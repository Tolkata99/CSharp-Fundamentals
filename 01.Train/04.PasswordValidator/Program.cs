using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = ValidateLenght(password);
            bool isValidLetterAndDigits = ValidateLetterAndDigits(password);
            bool isValidTwoDigits = ValidateTwoDigits(password);

            PrintValidPassword(isValidTwoDigits, isValidLetterAndDigits, isValid);
        }

        private static bool ValidateLetterAndDigits(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLetterOrDigit(c))
                {
                    return true;
                }
                

            }
            return false;
        }

        private static void PrintValidPassword(bool isValid,
                                bool isValidLetterAndDigits,
                                bool isValidTwoDigits)
        {
            int counter = 0; ;
            if(isValid)
            {
                counter++;

            }
            else
            {
                
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (isValidLetterAndDigits)
            {
                counter++;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (isValidTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
                
            }
            else
            {
                counter++;
            }

            if(counter >= 3)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidateTwoDigits(string password)
        {
            int counter = 0;
            foreach (char numbers in password)
            {
                if(char.IsDigit(numbers))
                {
                    counter++;
                }
                
            }
            if(counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

       

        private static bool ValidateLenght(string password)
        {
            if (password.Length <= 10 && password.Length >= 6)
            {
                
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
