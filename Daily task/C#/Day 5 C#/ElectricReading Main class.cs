
using SimplePrograms; //Package that contains all classes

var electricReading = new ElectricReading(231,"Sriram","Domestic",1100,900);
int billAmount = electricReading.CalculateBill(); // invoking the CalculateBill method inside the class

Console.WriteLine($"\nHi '{electricReading.ConsumerName}' your bill amount for this month is : {billAmount}");


