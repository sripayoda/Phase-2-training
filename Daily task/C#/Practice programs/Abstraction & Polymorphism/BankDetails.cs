using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class BankDetails
    {
        private int customerId;
        private string? customerName,status;
        private long accountNumber;
        private double balance;

        public BankDetails(int customerId, string? customerName, string? status, long accountNumber, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            Status = status;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string? CustomerName { get => customerName; set => customerName = value; }
        public string? Status { get => status; set => status = value; }
        public long AccountNumber { get => accountNumber; set => accountNumber = value; }
        public double Balance { get => balance; set => balance = value; }

        public void FetchAccountDetails(int customerId)
        {
            if (CustomerId == customerId)
                Console.WriteLine(AccountNumber+CustomerName+Status+Balance);
        }

        public void FetchAccountDetails(long accountNumber)
        {
            if (CustomerId == customerId)
                Console.WriteLine(CustomerId+ CustomerName + Status + Balance);
        }

        public void FetchAccountDetails(string customerName)
        {
            if (CustomerId == customerId)
                Console.WriteLine(CustomerId + AccountNumber + Status + Balance);
        }
    }
}
