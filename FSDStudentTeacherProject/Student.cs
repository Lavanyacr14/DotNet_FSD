using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDStudentTeacherProject
{
    class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }

        public void GetData()
        {
            Console.WriteLine($"ID:{ID} StudentName:{StudentName} Class:{ClassName}");
        }

        public void SetData(int ID, string StudentName, string ClassName)
        {
            this.ID = ID;
            this.StudentName = StudentName;
            this.ClassName = ClassName;
        }
    }
}
