using System;

namespace HW_CSharp_26_08
{
    delegate void LibraryEventHandler(Book b, bool flag); // flag indicates the type of operation (add or take)

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("The Great Gatsby", "Scott Fitzgerald", "Novel");
            Book book2 = new Book("C# 4.0 The Complete Reference", "Herbert Schildt", 
                "Computer literature");
            Book book3 = new Book("Armada", "Ernest Cline", "Science fiction");
            Book book4 = new Book("All We Have Is Now", "Lisa Schroeder", "Science fiction");
            Book book5 = new Book("Rebel Mechanics", "Shanna Swendson", "Science fiction");
            Book book6 = new Book("Java The Complite Reference", "Herbert Schildt", 
                "Computer literature");

            Library bookStore = new Library();

            Student st1 = new Student("Oleg");
            Student st2 = new Student("Andrew");

            bookStore.evt += st1.ComputerLiteratureHandler;
            bookStore.evt += st2.ScienceFictionHandler;

            bookStore.AddBook(book1);
            bookStore.AddBook(book2);
            bookStore.AddBook(book3);
            bookStore.AddBook(book4);
            bookStore.AddBook(book5);
            bookStore.AddBook(book6);

            bookStore.PrintAllBooks();

            bookStore.TakeBook("Armada");
            bookStore.PrintAllBooks();

            bookStore.TakeBook("The Great Gatsby");
            bookStore.PrintAllBooks();

            Console.ReadKey();
        }
    }
}
