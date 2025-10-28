using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignments21_10_2025.CustomBooks;

namespace Assignments21_10_2025
{
    public class CustomBooks
    {
        public CustomBooks()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("C#", "rahul", 500));
            books.Add(new Book("Python Adarsh", "Robert C. Martin", 850));
            books.Add(new Book("Java", "Arjun", 600));
            Console.WriteLine("All Books:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title+" "+book.Author+" "+book.Price);
            }
            var highestbookprice = books.Max(book => book.Price);
            Console.WriteLine(highestbookprice);
            books.RemoveAll(book => book.Title=="Java");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title + " " + book.Author + " " + book.Price);
            }
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Price { get; set; }

            public Book(string title, string author, int price)
            {
                Title = title;
                Author = author;
                Price = price;
            }




        }
    }
}
