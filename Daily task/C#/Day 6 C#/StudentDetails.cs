using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StudentDetails : College
    {
        private int rNo;
        private string? name,address;

        public StudentDetails(int rNo, string? name, string? address, string? collegeName, string? caddress)
            : base(collegeName, caddress)
        {
            RNo = rNo;
            Name = name;
            Address = address;
        }

        public int RNo { get => rNo; set => rNo = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }


    }
}
