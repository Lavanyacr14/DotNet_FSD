using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDStudentTeacherProject
{
    class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string ClassName { get; set; }

        public void GetData()
        {
            Console.WriteLine($"ID:{ID} Name:{Name} Subject:{Subject} Class:{ClassName}");
        }

        public void SetData(int ID,string Name, string Subject,string ClassName)
        {
            this.ID = ID;
            this.Name = Name;
            this.Subject = Subject;
            this.ClassName = ClassName;
        }
    }
}
