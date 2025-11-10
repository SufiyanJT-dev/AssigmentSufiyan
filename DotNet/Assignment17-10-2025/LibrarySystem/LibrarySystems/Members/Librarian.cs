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
        private static int _nextId = 1;
        public int LibrarianId { get; private set; }

        public Librarian(string librarianName)
        {
            LibrarianId = _nextId++;
            LibrarianName = librarianName;
            Console.WriteLine($"Librarian ID: {LibrarianId}, Name: {LibrarianName}");
        }


    }
}
