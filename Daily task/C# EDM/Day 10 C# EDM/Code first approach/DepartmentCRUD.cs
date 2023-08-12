using EFCF.Models;
using EFCF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class DepartmentCRUD
    {
       
        public void AddNewDept()
        {
            using (var context = new EmployeeMgmt())
            {
                var dept = new Dept()
                {
                    Deptno = 13,
                    Deptname = "Hr"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }

        public void UpdateDept() 
        { 
            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            seldept.Deptname = "Dev";
            context.SaveChanges();
        }

        public void DeleteDept() 
        {
            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Deptno == 10);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }
    }
}
