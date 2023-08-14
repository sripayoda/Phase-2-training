using Abstraction;

/*MyPets myPet1 = new(2, 2, 4, "Dog");
MyPets myPet2 = new(2, 2, 4, "Cat");

Animal.Eat();
Animal.Sleep();

myPet1.Aboutme();
myPet1.Sound();
myPet2.Aboutme();
myPet2.Sound();*/

/*
 
 MyPetsWithInterface myPet1 = new(2, 2, 4, "Dog");
MyPetsWithInterface myPet2 = new(2, 2, 4, "Cat");

IAnimal myPet3 = new MyPetsWithInterface(2, 2, 2, "dog");
    
myPet1.Eat();
myPet1.Sleep();
myPet3.Sound();
myPet1.Aboutme();
myPet2.Aboutme();

myPet1.Sound();
*/

BankDetails bankDetails = new(12345, "Sriram", "Active", 76628949873, 1030.45);
Console.WriteLine("Enter 1.CustomerId 2.AccountNumber 3.Name");
int choice=Convert.ToInt32(Console.ReadLine());
bool cont=true;

while(cont)
{
    switch (choice)
    {
        case 1:
            int custid = Convert.ToInt32(Console.ReadLine());
            bankDetails.FetchAccountDetails(custid);
            break;
        case 2:
            long id = Convert.ToInt64(Console.ReadLine());
            bankDetails.FetchAccountDetails(id);
            break;
        case 3:
            string? name = Console.ReadLine();
            bankDetails.FetchAccountDetails(name);
            break;
        case 4:
            cont = false;
            break;
    }
} 