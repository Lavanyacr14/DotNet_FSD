using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            DataTypes d = new DataTypes();
            d.Do();
            */

            /*EvenOdd eo = new EvenOdd();
            eo.Do();*/

            /*StringReverse sr = new StringReverse();
            sr.Do();*/

            //new ArrayOfNumbers().Do();
            //new File_Operation().WriteFile();
            //new File_Operation().UpdateFile();
            //new File_Operation().ReadFile();
            //new File_Operation().DeleteFile();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Enter A for Add; U for Update; R for remove; D for Display; E for Exit");
                string option = Console.ReadLine();
                if (option == "A")
                {
                    new StudentCrud().AddData();                    
                }
                else if (option == "U")
                {
                    new StudentCrud().UpdateData();
                }
                else if (option == "R")
                {
                    new StudentCrud().RemoveData();
                }
                else if (option == "D")
                {
                    new StudentCrud().DisplayData();
                }
                else if (option == "E")
                {
                    keepRunning = false;
                    break;
                }
            }
                
        }
    }
}
