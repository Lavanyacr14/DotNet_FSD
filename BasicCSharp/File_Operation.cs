using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class File_Operation
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt", content);
        }

        public void UpdateFile()
        {
            string employee = "\nEmployee1, 1, Admin";
            File.AppendAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt", employee);
        }

        public void ReadFile()
        {
            string content = File.ReadAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt");
            Console.WriteLine(content);

            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt");
            foreach(string str in contents)
            {
                Console.WriteLine(str);
            }
        }

        public void DeleteFile()
        {
            if (File.Exists("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt"))
            {
                File.Delete("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/File_Operation.txt");
            }
            else
            { Console.WriteLine("File do not exist");
            }
        }
    }
}
