using EFDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBF
{
    internal class EmployeeCRUD
    {
        EmployeeManagementContext context = new EmployeeManagementContext();
        public void AddNewEmployee()
        {
            var emp = new Emp()
            {
                Empno = 1,
                Ename = "Sriram",
                Deptno = 11,
                Addr="USA",
            };
            context.Emps.Add(emp);
            context.SaveChanges();
            
        }

        public void UpdateEmployee()
        {
            var seldept = context.Emps.FirstOrDefault(d => d.Empno == 1);
            seldept.Ename = "Sri";
            context.SaveChanges();
        }

        public void DeleteEmployee()
        {
            var seldept = context.Emps.FirstOrDefault(d => d.Empno == 1);
            context.Emps.Remove(seldept);
            context.SaveChanges();
        }
    }
}
