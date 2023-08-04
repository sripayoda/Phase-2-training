
using LibraryAssignment;
using System.Security.Principal;

var book1 = new Book(206, "Physics", "Yogi", true);
var book2 = new Book(123, "Maths", "Ram", true);
var book3 = new Book(234, "Chemistry", "Sri", false);
var book4 = new Book(879, "Biology", "Sam", true);
var book5 = new Book(901, "C#", "Jim", false);

Book[] books = {book1,book2,book3,book4,book5};

var library = new Library(books);
String? option;
Console.WriteLine("List of available books -\n");
printBooks();

do
{

    Console.WriteLine("\nMENU :");
    Console.WriteLine("1 to Borrow Book \n2 to Return Book\n");
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
                Console.Write("\nEnter the Title of te book to borrow : ");
                String? title = Console.ReadLine();
                library.ReturnBook(title);
                break;
            }
    }
    Console.Write("\ndo you want continue any operations (yes/no) : ");
    option = Console.ReadLine();
} while (option.Equals("yes"));

Console.WriteLine("\nUpdated list of Books-\n");
printBooks();
void printBooks()
{
    int s_no = 1;
    foreach (var book in books)
    {

        if (book.IsAvailable)
            Console.WriteLine($"{s_no}) ID : {book.BookId}, TITLE : {book.Title}");
    }
}