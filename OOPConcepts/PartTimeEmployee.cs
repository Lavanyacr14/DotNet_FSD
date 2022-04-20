using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    class PartTimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
        public PartTimeEmployee(int ID, string Name, string Department, int hourlySal) : base(ID, Name, Department)
        {
            this.HourlySalary = hourlySal;
        }
    }
}
