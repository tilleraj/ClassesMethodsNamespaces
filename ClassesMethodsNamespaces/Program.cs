using ClassesMethodsNamespaces.FavoriteThings;
using System;

namespace ClassesMethodsNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the title of a book followed by a ',' and the number of pages in the book");
            var input = Console.ReadLine();
            string[] splitInput = input.Split(",");
            var book1 = new Book(int.Parse(splitInput[1]), splitInput[0]);

            var book2 = new Book(123, "Book2: The Title");

            book1.Read(20);
            book1.Status();

            book2.Read(200);
            book2.Status();

        }
    }
}
