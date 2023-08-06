
using Inheritance;

StudentGrade studentMarks = new(67,90,34,231,"Sri","Coimbatore","SREC","Kovai"); 
//dont need to use Class name after new if we declare the object with class name instead of var
studentMarks.DisplayCollegeDetails();
Console.WriteLine($"{ studentMarks.Name} mark details ");
Console.WriteLine($"Total = {studentMarks.CalculateTotal()} and Average = {studentMarks.CalculateAverage()} " +
    $"and grade = {studentMarks.CalculateGrade()}\n");

TeachingStaff teachingStaff = new(40,25,10,5,"ECE",10000,101,"Sriram","Kovai","SREC","Kovai");
NonTeachingStaff nonTeachingStaff = new(8000, 30, 20, 15, 6, 301, "Hari", "Salem","CIT","Goa");

Console.WriteLine($"{teachingStaff.Name} {teachingStaff.Department} {teachingStaff.BasicSalary}");
Console.WriteLine(teachingStaff.CalculateSalary());

Console.WriteLine($"\n{nonTeachingStaff.Name} {nonTeachingStaff.BasicSalary}");
Console.WriteLine(nonTeachingStaff.CalculateSalary());