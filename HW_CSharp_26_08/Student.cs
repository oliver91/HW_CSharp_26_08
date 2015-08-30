using System;

namespace HW_CSharp_26_08
{
    class Student
    {
        private string name;

        public Student(string n)
        {
            name = n;
        }

        public void ComputerLiteratureHandler(Book b, bool flag)
        {
            if(b.BookGenre.Equals("Computer literature") & flag)
                Console.WriteLine(name +": "+ "I'm going to the library!");
            //if (!b.BookGenre.Equals("Computer literature") & !flag)
            //    Console.WriteLine(name + ": " + "I'm not going to read it!");
        }

        public void ScienceFictionHandler(Book b, bool flag)
        {
            if(b.BookGenre.Equals("Science fiction") & flag)
                Console.WriteLine(name + ": " + "I want to order the book delivery!");
            if (!b.BookGenre.Equals("Science fiction") & !flag)
                Console.WriteLine(name + ": " + "I'm not going to read it!");
        }
    }
}
