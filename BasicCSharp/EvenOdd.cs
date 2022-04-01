using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class EvenOdd
    {
        public void Do()
        {

            bool keepRunning = true;
            while (keepRunning)
                {
                    Console.WriteLine("Please enter a number to find out if it is odd or even or 0 to exit");
                    string input = Console.ReadLine();
                    int value = Convert.ToInt32(input);
                    

                    if (value == 0)
                        {
                            keepRunning = false;
                            break;
                        }
                        if (value % 2 == 0)
                        {
                            Console.WriteLine("Number is even");
                        }
                        else
                        {
                            Console.WriteLine("Number is odd");
                        }
                    }

               
        }
    }
}
