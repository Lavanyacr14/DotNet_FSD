using System;

namespace FSDStudentTeacherProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            Subject sub = new Subject(); 
            Teacher t = new Teacher();
            Student stud = new Student();
            
            while (keepRunning)
            {
                Console.WriteLine("Enter 1 to go to Teachers module; 2 to go to Subject module; 3 to go to Student module; -1 to exit");
                string option = Console.ReadLine();
                if (option=="1")
                {
                    Console.WriteLine("Enter Teacher ID!");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Teacher Name!");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Teacher Subject!");
                    string Subject = Console.ReadLine();
                    Console.WriteLine("Enter Teacher ClassName!");
                    string ClassName = Console.ReadLine();
                    t.SetData(ID, Name, Subject, ClassName);
                    t.GetData();
                }
                else if (option=="2")
                {
                    Console.WriteLine("Enter Subject!");
                    string SubjectName = Console.ReadLine();
                    Console.WriteLine("Enter ClassName!");
                    string ClassName = Console.ReadLine();
                    sub.SetData(SubjectName, ClassName);
                    sub.GetData();
                }
                else if (option=="3")
                {
                    Console.WriteLine("Enter Student ID!");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter StudentName!");
                    string StudentName = Console.ReadLine();
                    Console.WriteLine("Enter ClassName!");
                    string ClassName = Console.ReadLine();
                    stud.SetData(ID,StudentName, ClassName);
                    stud.GetData();
                }
                else if (option=="-1")
                {
                    keepRunning=false;
                    break;
                }
            }
            
        }
    }
}
