using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDStudentTeacherProject
{
    class Subject
    {
        public string SubjectName { get; set; }
        public string ClassName { get; set; }

        public void GetData()
        {
            Console.WriteLine($"SubjectName:{SubjectName} ClassName:{ClassName}");
        }

        public void SetData(string SubjectName, string ClassName)
        {
            this.SubjectName = SubjectName;
            this.ClassName = ClassName;
        }
    }
}
