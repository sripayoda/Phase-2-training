using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePrograms
{
    internal class ElectricReading
    {
        private int consumerNumber, previousReading, currentReading;
        private String consumerName, consumerType; //in C# we cant give access specifier as specific block for all variables
        private readonly int _subsidy; //if u give both private and readonly should give _

        public ElectricReading(int consumerNumber, string consumerName, string consumerType, int currentReading, int previousReading)
        {
            ConsumerNumber = consumerNumber;
            PreviousReading = previousReading;
            CurrentReading = currentReading;
            ConsumerName = consumerName;
            ConsumerType = consumerType;
            _subsidy = 50;
        }

        public int CalculateBill()
        {
           
            int billAmount=0;
            int consumption = CurrentReading - PreviousReading;
            if (ConsumerType.Equals("Domestic")) 
            {
                if( consumption <=100 ) 
                {
                    billAmount = 0 ;
                }
                else if( consumption > 100 && consumption <= 200)
                {
                    billAmount = (consumption-100)*2 ;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billAmount = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billAmount = (consumption - 100) * 10;
                }
            }
            else if (ConsumerType.Equals("Commercial")) 
            {
                if (consumption > 100 && consumption <= 200)
                {
                    billAmount = consumption * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billAmount = consumption * 5;
                }
                else if (consumption > 500)
                {
                    billAmount = consumption * 10;
                }
            }
            return billAmount;
        }

        public int ConsumerNumber { get => consumerNumber; set => consumerNumber = value; }
        public int PreviousReading { get => previousReading; set => previousReading = value; }
        public int CurrentReading { get => currentReading; set => currentReading = value; }
        public string ConsumerName { get => consumerName; set => consumerName = value; }
        public string ConsumerType { get => consumerType; set => consumerType = value; }
        public int Subsidy => _subsidy;
    }
}
