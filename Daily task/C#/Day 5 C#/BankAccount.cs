using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountAssignment;

internal class BankAccount
{
    private readonly int accountNumber;
    private String accountHolderName;
    private Double balance;

    public int AccountNumber => accountNumber;
    public string AccountHolderName { get => accountHolderName; set => accountHolderName = value; }
    public double Balance { get => balance; set => balance = value; }

    public BankAccount(int accountNumber, String accountHolderName)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        Balance = 0;
    }

    public String Deposit(Double amount)
    {
        Balance += amount;
        return $"\nHi '{AccountHolderName}' an amount of rupees {amount} has been credited to your account on {DateTime.Now.ToString("dddd, dd MMMM yyyy hh: mm tt")}" +
            $"\nAvailable Balance : {Balance}";
    }

    public String Withdraw(Double amount)
    {
        String message;
        if(Balance-amount > 0) 
        { 
            Balance -= amount;
            message = $"\nHi '{AccountHolderName}' an amount of rupees {amount} has been debited from your account on {DateTime.Now.ToString("dddd, dd MMMM yyyy hh: mm tt")}" +
                $"\nAvailable Balance : {Balance}";
        }
        else message = $"\nYour widthdrawal amount exceeds your current balance" +
                $"\nAvailable Balance : {Balance}";
        return message;
    }

    public void AccountDetails()
    {
        Console.WriteLine("\nACCOUNT DETAILS -\n");
        Console.WriteLine($"Account number : { AccountNumber}\nName : {AccountHolderName}\nAvailable Balance : {Balance} ");
    }


}
