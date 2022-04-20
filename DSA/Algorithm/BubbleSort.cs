using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithm
{
    class BubbleSort
    {
        //Time complexity => n square
        int[] array = {99,88,44,33,22,11,5,3 };
        public void Do()
        {
            int n = array.Length;

            //iteration loop
            for (int i=0;i<n-1;i++)
            {
                //swap loop
                for (int j=0; j<n-i-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach(int num in array)
            {
                Console.Write(num + " ");
            }

        }
    }
}
