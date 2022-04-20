using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    class FullTimeEmployee : Employee
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int ID, string Name,string Department,int monthlySal):base(ID,Name, Department)
        {
            this.MonthlySalary = monthlySal;
        }
    }
}
