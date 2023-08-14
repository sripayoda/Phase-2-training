using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StudentMarks: StudentDetails
    {
        private int m1, m2, m3;

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }

       public StudentMarks(int m1, int m2, int m3, int r_no , string name, string address, string? collegeName, string? caddress)
            : base(r_no,name,address,collegeName,caddress)
        {
            M1 = m1;
            M2 = m2;
            M3 = m3;
        }

        public int CalculateTotal()
        {
            return M1+M2+M3;
        }

        public Double CalculateAverage()
        {
            return CalculateTotal()/3;
        }
    }
}
