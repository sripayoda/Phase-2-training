using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class College
    {
        private string? collegeName, address;

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? Address { get => address; set => address = value; }

        public College(string? collegeName, string? address)
        {
            CollegeName = collegeName;
            Address = address;
        }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine($"{CollegeName} {Address}\n");
        }
    }
}
