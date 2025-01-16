using static System.Console;

namespace OOP_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Der Herr Der Ringe", "J.R.R. Tolkien", "978-3608939828 ");

            BorrowedBook borrowedBook = new BorrowedBook(1, book, "Beshoy William", DateTime.Now.AddDays(-10));

            WriteLine($"The Borrowed Book : \n{borrowedBook}\n");

            WriteLine("---------------------");
            borrowedBook.CheckOut();
            borrowedBook.ReturnItem();
            WriteLine("---------------------");

            WriteLine($"\nThe number of days the book has been borrowed : \n{borrowedBook.CalculateBorrowDuration()}");
        }
    }
}
