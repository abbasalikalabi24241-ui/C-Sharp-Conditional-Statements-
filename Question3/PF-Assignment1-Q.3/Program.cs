using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Assignment1_Q._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Year = 2024 (Leap year)
            // Test Case 2: Year = 1900 (Not a leap year)
            // Test Case 3: Year = 2000 (Leap year)

            Console.WriteLine("ClassID: 120703 | Registration ID: 66458 | Name: M.Abbas Ali Kalabi | Submission Date: 28-10-2026");

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("It is a leap year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("It is not a leap year.");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("It is a leap year.");
            }
            else
            {
                Console.WriteLine("It is not a leap year.");
            }
        }
    }
}
