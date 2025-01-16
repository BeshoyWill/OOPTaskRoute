using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    internal class BorrowedBook : Library
    {
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        public BorrowedBook(int itemId, Book bookDetails, string borrowerName, DateTime borrowedDate)
        {
            ItemID = itemId;
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        public int CalculateBorrowDuration()
        {
            var durationSinceBorrowed =  (DateTime.Now - BorrowedDate).Days;
            return durationSinceBorrowed;   
        }

        public override string ToString()
        {
            return $"Book Details : {BookDetails} \nBorrow Name : {BorrowerName} \nBorrowed Date : {BorrowedDate.ToShortDateString()}, Available : {IsAvailable}";
        }
    }
}
