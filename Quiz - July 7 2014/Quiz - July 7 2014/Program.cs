using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz___July_7_2014
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter another number:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("The smaller of the two numbers is: " + num2);
            else if (num1 < num2)
                Console.WriteLine("The smaller of the two numbers is: " + num1);
            else
                Console.WriteLine("Sorry, your numbers are the same.");

            Console.WriteLine("Question 1 is complete. Moving on to Question 2...");
            Console.ReadLine(); //End of program
        }
    }
}