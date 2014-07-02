using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Book
    {
        public int Price = 5;
    }
    
    Book book1 = new Book;
    Book book2 = new Book;
    
    if(book1 > book2)
        return 1;
    else if (book2 > book 1)
        return -1;
    else if (book1 == book2)
        return 0;
    else
        return string("Sorry, I don't understand.");
}
