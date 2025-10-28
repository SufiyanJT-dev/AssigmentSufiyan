using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystems.Members
{
    public class Librarian
    {   
        public String? LibrarianName { get; set; }

        public Librarian(string librarianName)
        {
            LibrarianName = librarianName;
            Console.WriteLine("Librarian Name: " +LibrarianName);
            
        }

    }
}
