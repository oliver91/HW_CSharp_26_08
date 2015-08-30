using System;

namespace HW_CSharp_26_08
{
    class Book
    {
        private string bookName;
        private string authorName;
        private string bookGenre;

        public string BookName {
            get { return bookName; }
        }

        public string AuthorName {
            get { return authorName; }
        }

        public string BookGenre {
            get { return bookGenre;}
        }

        public Book(string name, string author, string genre)
        {
            bookName = name;
            authorName = author;
            bookGenre = genre;
        }
    }
}
