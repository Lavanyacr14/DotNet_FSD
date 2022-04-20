using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithm
{
    class Binary_Search
    {
        static int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        public  void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 10);
            Console.WriteLine("Element at index "+ result);
            result = binarySearch(array, 0, array.Length - 1, 11);
            Console.WriteLine("Element at index " + result);
        }

        public  int binarySearch(int[] array,int left, int right, int num)
        {
            if (right>=left)
            {
                //Step 1: Find Mid element
                int mid = (left + right) / 2;
                //Step 2: Check if the mid element is the required num
                if (array[mid]==num)
                {
                    return mid;
                }
                //Step 3: Find if the num is less than mid element
                if (num < array[mid])
                {
                    //mid = mid - 1;//new right
                    int newRight = mid - 1;
                    return binarySearch(array, left, newRight, num);
                }
                //Step 4: Find if the num is greater tha mid element
                else
                {
                    //mid = mid + 1;//new left
                    int newLeft = mid + 1;
                    return binarySearch(array, newLeft, right, num);
                }                
            }
            return -1;
        }
    }
}
