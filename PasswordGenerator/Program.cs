using System;
using System.Text;

namespace PasswordGenerator
{
    internal class Program
    {
        static Random random = new Random(); //Random object used to generate random characters for the password.

        /// <summary>
        /// Method that generates the password based on length and strenth.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="strength"></param>
        /// <returns></returns>
        static string GeneratePassword(int length, int strength)
        {
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            const string numbers = "0123456789";
            const string specialChars = "!@#$%^&*()_+";

            string weakPassword = lowerCase; //Weak password
            if (strength == 2)               //Medium password
            {
                weakPassword += upperCase + numbers;
            }
            if (strength == 1)               //Strong password
            {
                weakPassword += upperCase + numbers + specialChars;
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(weakPassword[random.Next(weakPassword.Length)]);
            }

            return password.ToString();
        }

        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int passwordStrength, passwordLength;
            Console.WriteLine("What kind of password do you need? (1 - Strong, 2 - Medium, 3 - Weak)");
            if (int.TryParse(Console.ReadLine(), out passwordStrength))
            {
                if (passwordStrength > 3 || passwordStrength < 1)
                {
                    Console.WriteLine("Please enter a number from 1 to 3. Try again.");
                    Console.WriteLine();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Please enter a number. Try again.");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("How long should the password be? (enter numbers only)");
            if (int.TryParse(Console.ReadLine(), out passwordLength))
            { }
            else
            {
                Console.WriteLine("Please enter a number. Try again.");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Generated Password: " + GeneratePassword(passwordLength, passwordStrength));
            Console.WriteLine();
        }
    }
}
