using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace OOPConcepts
{
    abstract class Employee
    {
        public IITTeam ITTeam { get; set; }
        public IFinanceTeam FinanceTeam { get; set; }
        
        public Employee(int ID,string Name, string Department)
        {
            this.ID = ID;
            this.Name = Name;
            this.Department = Department;
            //ITTeam = new ITTeam();//still incorrect way
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public void DoWork()
        {
            ITTeam.SolveProblem();
        }

        public void GetSalary()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine("Salary credited");
            FinanceTeam.TakeRequestFromEmployee();
        }
    }
}
