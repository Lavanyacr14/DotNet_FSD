using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class StudentCrud
    {
        public void AddData()
        {
            Console.WriteLine("Enter the student record in format (ID, Name, Dept)");
            string student = Console.ReadLine();
            student += "\n";
            File.AppendAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt",student);
        }

        public void DisplayData()
        {
            string content = File.ReadAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt");
            Console.WriteLine(content);
        }

        public void UpdateData()
        {
            Console.WriteLine("Enter the record to Update");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt");
            string resultContent = string.Empty;
            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                if (str1[0]==input1[0])
                {
                    resultContent += input;
                    resultContent += "\n";
                }
                else
                {
                    resultContent += str;
                    resultContent += "\n";
                }
            }
            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt",resultContent);
            Console.WriteLine("Record Updated!");
           

        }

        public void RemoveData()
        {
            Console.WriteLine("Enter the ID to remove");
            string input = Console.ReadLine();
            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt");
            string resultContent = string.Empty;
            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                if (str1[0] != input)
                {
                    resultContent += str;
                    resultContent += "\n";
                }
                
            }
            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Student.txt", resultContent);
            Console.WriteLine("Record deleted!");
        }
    }
}
