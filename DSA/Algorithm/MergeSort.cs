using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MergeSort
    {
        public void Do()
        {
            int[] array = { 92, 23, 41, 7, 32, 61, 12, 3 };             
            Divide(array, 0, array.Length - 1);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        void Divide(int[] array, int left, int right)//log n iterations
        {
            
            if (left < right)
            {
                
                //Find mid
                int mid = (left + right) / 2;
                //Console.WriteLine(" mid "+ array[mid] + " left "+ array[left] + " mid "+ array[mid] + " mid+1 " + array[mid+1] + " right " + array[right]);
                //Divide left array(create pointers for left array)
                Divide(array, left, mid);

                //Divide right array(create pointers for right array)
                Divide(array, mid + 1, right);

                //Merge and Sort
                MergeAndSort(array, left, right, mid);
            }

        }

        void MergeAndSort(int[] array, int left, int right, int mid)
        {
            // 1. Create Left and Right array based on pointers.

            // 1.1 Length of arrays.
            int leftArrayLength = mid - left + 1;
            int rightArrayLength = right - mid;

            // 1.2 Create arrays left and right
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            int i, j;
            for (i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[left + i];
            }

            for (j = 0; j < rightArrayLength; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }

            // 2. Merge and Sort.
            i = 0; j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)//n
            {
                if (leftArray[i] < rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArrayLength)//n
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArrayLength)//n
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }

        }
    }
}
