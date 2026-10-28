using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Assignment1_Q._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: 10 + 5 = 15
            // Test Case 2: 10 - 5 = 5
            // Test Case 3: 10 * 5 = 50
            // Test Case 4: 10 / 5 = 2
            // Test Case 5: Division by zero

            Console.WriteLine("ClassID: 120703 | Registration ID: 66458 | Name: M.Abbas Ali Kalabi | Submission Date: 28-10-2026");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        valid = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    valid = false;
                    break;
            }

            if (valid)
            {
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
