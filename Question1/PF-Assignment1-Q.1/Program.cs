using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Assignment1_Q._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Input = 1, Expected Output = Monday
            // Test Case 2: Input = 8, Expected Output = Invalid number
            // Test Case 3: Input = hello, Expected Output = Invalid number

            // Display student information first
            Console.WriteLine("ClassID: 120703 | Registration ID: 66458 | Name: M.Abbas Ali Kalabi | Submission Date: 25-10-2026");

            // Ask the user to enter a day number
            Console.Write("Enter day number (1-7): ");

            // Read input and check whether it is an integer
            string input = Console.ReadLine();

            if (int.TryParse(input, out int day))
            {
                // Check the day number
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;

                    case 2:
                        Console.WriteLine("Tuesday");
                        break;

                    case 3:
                        Console.WriteLine("Wednesday");
                        break;

                    case 4:
                        Console.WriteLine("Thursday");
                        break;

                    case 5:
                        Console.WriteLine("Friday");
                        break;

                    case 6:
                        Console.WriteLine("Saturday");
                        break;

                    case 7:
                        Console.WriteLine("Sunday");
                        break;

                    default:
                        Console.WriteLine("Invalid number");
                        break;
                }
            }
            else
            {
                // Handle text or other non-integer input
                Console.WriteLine("Invalid number");
            }
        }
    }
}
