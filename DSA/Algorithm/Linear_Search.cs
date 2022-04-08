using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithm
{
    class Linear_Search
    {
        int[] array = {11,34,56,98,30,45};

        //Time complexity T(n) = O(n)
        public void Do()
        {
            Console.WriteLine("Please enter the number to search in array");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<=array.Length-1; i++)
            {
                if (array[i]==num)
                {
                    Console.WriteLine("Number found at the index: " + i);
                    return;
                }                
            }
            Console.WriteLine("Number not found in the array");
        }
    }
}
