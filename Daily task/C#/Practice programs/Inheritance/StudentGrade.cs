using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StudentGrade : StudentMarks
    {
        public StudentGrade(int m1, int m2, int m3, int r_no, string name, string address
            , string? collegeName, string? caddress) 
            : base(m1, m2, m3, r_no, name, address, collegeName, caddress)
        {
        }

        public char CalculateGrade()
        {
            double average=CalculateAverage();
            char grade='C';
            if (average >= 90) grade = 'A';
            else if (average >= 80 && average <= 90) grade = 'B';
            return grade;
        }
    }
}
