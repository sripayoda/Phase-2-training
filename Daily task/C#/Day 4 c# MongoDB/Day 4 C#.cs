/*
double num1, num2;
int result;
Console.Write("Enter num1 : ");
num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter num2 : ");
num2 = Convert.ToDouble(Console.ReadLine());
result = (int)(num1 + num2);
Console.WriteLine("Sum of two numbers = "+result);
*/

/*
int number,temp,sum=0;
Console.Write("Enter number : ");
number=Convert.ToInt32(Console.ReadLine());
temp = number;
while (number > 0)
{
    sum += Convert.ToInt32(Math.Pow((number % 10),3));
    number /= 10;
}
Console.WriteLine("\n The given number is "+((sum==temp)?"an Amstrong number":"not an Amstrong number"));
*/

/*
int number,sum=1;
Console.Write("Enter number : ");
number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number/2; i++)
    sum += (number % i == 0) ? i : 0;
Console.WriteLine((sum==number)?"{0} is a perfect number": "{0} is not a perfect number", number);
*/

/*
int number1,number2,count=0;
Console.Write("Enter number1 : ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2 : ");
number2 = Convert.ToInt32(Console.ReadLine());
int startpoint=(number1 < number2)?number1:number2;
int endpoint = (number1 > number2) ? number1 : number2;
Console.Write("\n Prime number between given two numbers are : ");
for (int i=startpoint;i<=endpoint;i++)
{
    for(int j=1;j<=i/2;j++)
        count += (i % j == 0) ? 1 : 0;
    if(count==1)
    Console.Write(i+" ");
    count = 0;
}
*/


