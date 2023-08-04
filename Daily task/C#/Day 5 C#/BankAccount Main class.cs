
using BankAccountAssignment;

Console.Write("Enter Account number : ");
int accountNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Account name : ");
String? accountName = Console.ReadLine();
var account = new BankAccount(accountNumber, accountName);
bool flag;
do
{
    String? option;
    Console.WriteLine("\nMENU :");
    Console.WriteLine("1 for Deposit\n2 for Widthdraw\n3 to view Account details\n");
    Console.Write("Enter your choice : ");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                Console.Write("\nEnter the amount to deposit : ");
                Double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(account.Deposit(amount));
                break;
            }
        case 2:
            {
                Console.Write("\nEnter the amount to widthdraw : ");
                Double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(account.Withdraw(amount));
                break;
            }
        case 3:
            account.AccountDetails();
            break;
    }
    Console.Write($"\n{account.AccountHolderName} do you want continue any operations (yes/no) : ");
    option = Console.ReadLine();
    flag = option.Equals("yes");
} while (flag);
