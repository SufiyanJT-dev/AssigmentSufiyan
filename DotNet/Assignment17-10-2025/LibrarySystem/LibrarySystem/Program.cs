// See https://aka.ms/new-console-template for more information
using LibrarySystem;
using LibrarySystem.Books;
using LibrarySystems.Books;
using LibrarySystems.Members;

using LibrarySystems.Transactions;

    Librarian librarian = new Librarian("Adarsh");

    Members members = new Members();
    Book book = new Book("Dark","Rahul");
Magazine magazine = new Magazine("Dark", "Rahul");
    Journal journal = new Journal("Dark","Rahul");
    BorrowTransaction borrowTransaction = new BorrowTransaction();
    ReturnTransactioncs returnTransactioncs = new ReturnTransactioncs();
