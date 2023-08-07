
using LibraryAssignment;
using System.Security.Principal;

var book1 = new Book(206, "Physics", "Yogi");
var book2 = new Book(123, "Maths", "Ram");
var book3 = new Book(234, "Chemistry", "Sri");
var book4 = new Book(879, "Biology", "Sam");
var book5 = new Book(901, "C#", "Jim");

Book[] books = {book1,book2,book3,book4,book5};

var library = new Library(books);
library.DisplayAvailableBooks();
String? option;


do
{

    Console.WriteLine("\nMENU :");
    Console.WriteLine("Enter 1 to Borrow Book \nEnter 2 to Return Book\nEnter 3 to Search a Book");
    Console.Write("Enter your choice : ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.Write("\nEnter the Title of te book to borrow : ");
                String? title = Console.ReadLine();
                library.BorrowBook(title);
                break;
            }
        case 2:
            {
                Console.Write("\nEnter the Title of te book to return : ");
                String? title = Console.ReadLine();
                library.ReturnBook(title);
                break;
            }
        case 3:
            {
                Console.WriteLine("\nSearch Book By :");
                Console.WriteLine("1. Title or Author  \n2. Id");
                Console.Write("Enter your choice : ");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        {
                            Console.Write("\nEnter the Title or Author of te book to Search: ");
                            String? value = Console.ReadLine();
                            foreach(var book in library.Books)
                            {
                                if (book.Title.Equals(value) || book.Author.Equals(value))
                                {
                                    book.SearchBook(value);
                                    break;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("\nEnter the Id of te book to Search : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            foreach (var book in library.Books)
                            {
                                if (book.BookId == id)
                                {
                                    book.SearchBook(id);
                                    break;
                                }
                            }
                            break;
                        }
                }
                break;
            }
    }
    Console.Write("\ndo you want continue any operations (yes/no) : ");
    option = Console.ReadLine();
} while (option.Equals("yes"));
Console.WriteLine();
library.DisplayAvailableBooks();

