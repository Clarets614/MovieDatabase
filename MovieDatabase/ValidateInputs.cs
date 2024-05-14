using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MovieDatabase
{
    public static class ValidateInputs
    {
        public static int GetInputInt()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Invalid input. Try again.");
            }
            return result;
        }


        public static int GetPositiveInputInt()
        {
            int result = -1;
            while (int.TryParse(Console.ReadLine(), out result) == false || result <= 0)
            {
                Console.WriteLine("Invalid input. Try again with a positive number");
            }
            return result;
        }

        public static bool GetContinue()
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }

        //overloading
        public static bool GetContinue(string msg)
        {
            bool result = false;
            while (true)
            {
                Console.WriteLine($"{msg} y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }
    }
}
