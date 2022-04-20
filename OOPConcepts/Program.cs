using System;

namespace OOPConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract class instance can not be created
            //Employee emp1 = new Employee(1,"John","Finance"); 
            //emp1.GetSalary();
            FullTimeEmployee fe = new FullTimeEmployee(1, "John", "Finance",200000);
            fe.GetSalary();
            PartTimeEmployee pe = new PartTimeEmployee(2, "David", "IT", 200000);
            pe.GetSalary();
        }
    }
}
