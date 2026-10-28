using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Assignment1_Q._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1: Amount = 6000, Discount = 20%
            // Test Case 2: Amount = 3000, Discount = 10%
            // Test Case 3: Amount = 1500, Discount = 0%

            Console.WriteLine("ClassID: 120703 | Registration ID: 66458 | Name: M.Abbas Ali Kalabi | Submission Date: 25-10-2026");

            Console.Write("Enter purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double discountPercent;

            if (amount >= 5000)
            {
                discountPercent = 20;
            }
            else if (amount >= 2000)
            {
                discountPercent = 10;
            }
            else
            {
                discountPercent = 0;
            }

            double discountAmount = amount * discountPercent / 100;
            double finalAmount = amount - discountAmount;

            Console.WriteLine("Discount Percentage: " + discountPercent + "%");
            Console.WriteLine("Discount Amount: " + discountAmount);
            Console.WriteLine("Final Amount: " + finalAmount);
        }
    }
}
