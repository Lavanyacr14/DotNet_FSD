using System;
using BLL;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract class instance can not be created
            //Employee emp1 = new Employee(1,"John","Finance"); 
            //emp1.GetSalary();
            FullTimeEmployee fe = new FullTimeEmployee(1, "John", "Finance",200000,(IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"),(IITTeam)DependencyResolver.GetInstance("IITTeam"));
            fe.GetSalary();
            fe.DoWork();
            //compile time polymorphism or method overloading
            fe.GetBenefit("test",1);
            fe.GetBenefit(1,"test");
            PartTimeEmployee pe = new PartTimeEmployee(2, "David", "IT", 200000, (IFinanceTeam)DependencyResolver.GetInstance("IFinanceTeam"), (IITTeam)DependencyResolver.GetInstance("IITTeam"));
            pe.GetSalary();
        }
    }
}
