using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibrarySystem.Books
{
    public class Book
    {
        public string BookAuthorName { get; set; }
        public string BookTitle { get; set; }
        public string BookId { get; set; }
        public static int TotolBook = 0;
        public    Book(string booktitle, string bookAuthorname)
        {
            TotolBook = TotolBook + 1;
            BookAuthorName = bookAuthorname;
            BookId = "B" + ( 1000 + TotolBook);
            BookTitle =booktitle;

            DisplayBookDetails();
        }
        public void  DisplayBookDetails()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine("\nBook Id:"+BookId+" \nBook Name:"+BookTitle+" \nBook Details:"+BookAthorName);
        }


    }
}
