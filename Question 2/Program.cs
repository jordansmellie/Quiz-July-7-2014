using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Books
    {
        public string name {get; set;}
        public decimal price {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books(){name = "The Art of War", price = 3.99M};
            Books book2 = new Books(){name = "Cooking at War", price = 4.99M};

            if (book1.price == book2.price)
                Console.WriteLine("0");
            else if (book1.price > book2.price)
                Console.WriteLine("1");
            else if (book2.price > book1.price)
                Console.WriteLine("-1");
            else
                Console.WriteLine("Sorry, I don't understand.");
        
            Console.WriteLine("Question 2 is complete. Moving on to Question 3...");
            Console.ReadLine(); //End of program
        }
    }
}
