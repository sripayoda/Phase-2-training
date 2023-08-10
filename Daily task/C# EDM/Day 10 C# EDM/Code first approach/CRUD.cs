using EFCF.Models;
using EFCF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {

        public void AddNewDept()
        {
            using (var context = new EmployeeMgmt())
            {
                var dept = new Dept()
                {
                    Deptno = 11,
                    Deptname = "Hr"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            };
        }

        public void UpdateDept() 
        { 
            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 11);
            seldept.Deptname = "Devi";
            context.SaveChanges();
        }

        public void DeleteDept() 
        {
            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 11);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }
    }
}
