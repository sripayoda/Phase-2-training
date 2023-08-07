using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    internal class Library
    {
        private readonly Book[] books;

        internal Book[] Books => books;

        public Library(Book[] books) 
        {
            this.books = books;
        }

        public void BorrowBook(String title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title))
                {
                    book.LentItem();
                    break;
                }
            }
        }
        public void ReturnBook(String title) 
        {
            foreach (var book in books) 
            {
                if (book.Title.Equals(title))
                {
                    book.IsAvailable = true;
                    break;
                }
            }
        }

        public void DisplayAvailableBooks()
        {
            int s_no = 1;
            Console.WriteLine("List of available books -\n");
            foreach (var book in books)
            {
                Console.WriteLine($"{s_no++}) ID : {book.BookId}, TITLE : {book.Title}, AUTHOR : {book.Author}, Availability : {book.IsAvailable}");
            }
        }
    }
}
