using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class Teacher_Crud
    {
        public void Do()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Enter A for Add; U for Update; R for remove; D for Display; S for sort; E for Exit");
                string option = Console.ReadLine();
                if (option == "A")
                {
                    new Teacher_Crud().AddData();
                }
                else if (option == "U")
                {
                    new Teacher_Crud().UpdateData();
                }
                else if (option == "R")
                {
                    new Teacher_Crud().RemoveData();
                }
                else if (option == "D")
                {
                    new Teacher_Crud().DisplayData();
                }
                else if (option == "S")
                {
                    new Teacher_Crud().SortData();
                }
                else if (option == "E")
                {
                    keepRunning = false;
                    break;
                }
            }
        }
        public void AddData()
        {
            Console.WriteLine("Enter the teacher record in format (ID, Name, Class, Section)");
            string teacher = Console.ReadLine();
            teacher += "\n";
            File.AppendAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt", teacher);
            Console.WriteLine("Record Added!");
        }

        public void DisplayData()
        {
            string content = File.ReadAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt");
            Console.WriteLine(content);
        }

        public void UpdateData()
        {
            Console.WriteLine("Enter the record to Update");
            string input = Console.ReadLine();
            string[] input1 = input.Split(",");
            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt");
            string resultContent = string.Empty;
            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                if (str1[0] == input1[0])
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
            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt", resultContent);
            Console.WriteLine("Record Updated!");


        }

        public void RemoveData()
        {
            Console.WriteLine("Enter the ID to remove");
            string input = Console.ReadLine();
            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt");
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
            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt", resultContent);
            Console.WriteLine("Record Deleted!");
        }

        /// <summary>
        /// 
        /// </summary>
        public void SortData()
        {
            //store ids into an array
            string[] contents = File.ReadAllLines("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt");
            int[] idArray = new int[10];
            int k = 0;

            foreach (string str in contents)
            {
                string[] str1 = str.Split(",");
                idArray[k] = Convert.ToInt32(str1[0]);
                k++;
            }
            
            foreach(int num in idArray)
            {
                Console.Write("Ids " + num);
            }
            
            //sord ids
            int n = idArray.Length;

                //iteration loop
                for (int i = 0; i < n - 1; i++)
                {
                    //swap loop
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (idArray[j] > idArray[j + 1])
                        {
                            int temp = idArray[j];
                            idArray[j] = idArray[j + 1];
                            idArray[j + 1] = temp;
                        }
                    }
                }

                foreach (int num in idArray)
                {
                    Console.Write("Sorted Array: " + num + " ");
                }

            string resultContent = string.Empty;

            foreach (int num in idArray)
            {
                foreach (string str in contents)
                {
                    string[] str1 = str.Split(",");
                    if (Convert.ToInt32(str1[0]) == num)
                    {
                        resultContent += str;
                        resultContent += "\n";
                        
                    }
                }

            }

            File.WriteAllText("C:/Users/Lavanya_r5/OneDrive - Dell Technologies/Documents/CPP/Dot_Net_Learning/Teacher.txt", resultContent);
            Console.WriteLine("Record Sorted!");
        }
    }
}
