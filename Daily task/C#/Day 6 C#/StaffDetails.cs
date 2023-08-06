using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class StaffDetails : College
    {
        private int eNo;
        private string? name, address;

        public int ENo { get => eNo; set => eNo = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }

        public StaffDetails(int eNo, string? name, string? address, string? collegeName, string? caddress)
            : base(collegeName, caddress)
        {
            ENo = eNo;
            Name = name;
            Address = address;
        }
    }
}
