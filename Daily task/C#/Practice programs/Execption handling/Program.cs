
using SimplePrograms;

ExceptionHandling exceptionHandling = new(10, 0, 0,17);
Console.WriteLine(exceptionHandling.Add());

try
{
    Console.WriteLine(exceptionHandling.Divide());
    exceptionHandling.CheckAge();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}