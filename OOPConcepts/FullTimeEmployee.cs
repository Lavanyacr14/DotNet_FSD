using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace OOPConcepts
{
    class FullTimeEmployee : Employee, IEmployeeBenefits
    {
        public int MonthlySalary { get; set; }
        public FullTimeEmployee(int ID, string Name,string Department,int monthlySal,IFinanceTeam team,IITTeam itTeam):base(ID,Name, Department,team,itTeam)
        {
            this.MonthlySalary = monthlySal;
        }

        public void GetBenefit()
        {
            
        }

        //compile time polymorphism or method overloading
        public void GetBenefit(int testNumber,string benefitName)
        {
            Console.WriteLine("public int GetBenefit(int testNumber,string benefitName)");
            
        }

        public void GetBenefit(string benefitName,int testNumber)
        {
            Console.WriteLine("public int GetBenefit(string benefitName,int testNumber)");
            
        }

        //RunTime Polymorphism or method overriding
        public override void GetSalary()
        {
            Console.WriteLine("Salary credited i fulltime employee class");
        }
    }
}
