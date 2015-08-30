using System;

namespace HW_CSharp_26_08
{
    class Library
    {
        public event LibraryEventHandler evt;

        private BooksList<Book> booksList = new BooksList<Book>();

        public void AddBook(Book b)
        {

            booksList.Add(b);
            if (evt != null)
                evt(b, true);
        }

        public Book TakeBook(string bookName)
        {
            Book currentBook = null;
            for (int i = 0; i < booksList.ElementsCount; i++)
            {
                if (booksList[i].BookName.Equals(bookName)) currentBook = booksList[i];
            }
            Book[] books = booksList.Remove(currentBook);

            booksList = new BooksList<Book>();
            for (int i = 0; i < books.Length; i++)
            {
                booksList.Add(books[i]);
            }

            Console.WriteLine(bookName + " is already taken!");

            if (evt != null)
                evt(currentBook, false);
            return currentBook;
        }

        public void PrintAllBooks()
        {
            Console.WriteLine("\nAvailable books: ");
            for (int i = 0; i < booksList.ElementsCount; i++)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", i+1,
                    booksList[i].BookName, booksList[i].AuthorName, booksList[i].BookGenre);
            }
            Console.WriteLine("\n");
        }
    }
}
