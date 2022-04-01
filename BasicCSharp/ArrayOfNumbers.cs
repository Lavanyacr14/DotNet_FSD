using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharp
{
    class ArrayOfNumbers
    {
        public void Do()
        {
            int[] array = { 10, 11, 12, 13, 14, 15 };

            foreach(int num in array)
            {
                Console.Write(num);
                Console.Write(" ");
            }
        }
    }
}
