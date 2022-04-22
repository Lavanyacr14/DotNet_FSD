using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace OOPConcepts
{
    class PartTimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
        public PartTimeEmployee(int ID, string Name, string Department, int hourlySal, IFinanceTeam team,IITTeam itTeam) : base(ID, Name, Department,team,itTeam)
        {
            this.HourlySalary = hourlySal;
        }
    }
}
