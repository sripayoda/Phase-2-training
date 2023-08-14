using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    internal class NonTeachingStaff : StaffDetails
    {
        private double basicSalary;
        private readonly int _da, _hra, _cca, _pf;

        public NonTeachingStaff(double basicSalary, int da, int hra, int cca, int pf
            ,int eNo,string name,string address, string? collegeName, string? caddress)
            : base(eNo, name, address, collegeName, caddress)
        {
            this.basicSalary = basicSalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float netSalary = (float)(BasicSalary + BasicSalary * (Da / 100)
                + BasicSalary * ((float)Hra / 100)
                + BasicSalary * ((float)Cca / 100)
                - BasicSalary * ((float)Pf / 100));
            return netSalary;
        }
    }
}
