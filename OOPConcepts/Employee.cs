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
        
        public Employee(int ID,string Name, string Department, IFinanceTeam team, IITTeam itTeam)
        {
            this.ID = ID;
            this.Name = Name;
            this.Department = Department;
            FinanceTeam = team;
            //ITTeam = new IITTeam();//still incorrect way
            ITTeam = itTeam;
        }

        private bool Validate(int id)
        {
            if(id < 1)
            {
                return false;
            }
            return true;
        }

        //getter & setter demo
        private int _ID;

        public int ID 
        {
            
            set
            {
                if(!this.Validate(value))
                    {
                    throw new Exception("Invalid Value");
                }
                _ID = value;
            }
            get
            {
                return this._ID;
            }

        }
        public string Name { get; set; }
        public string Department { get; set; }

        public void DoWork()
        {
            Console.WriteLine(this.ID); 
            ITTeam.SolveProblem();
            Console.WriteLine("Problem solved");
        }

        public virtual void GetSalary()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine("Salary credited");
            FinanceTeam.TakeRequestFromEmployee();
            
        }
    }
}
