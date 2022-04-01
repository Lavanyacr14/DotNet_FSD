using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Queue
    {
        int[] array;
        int front, rear;
        int maxSize;

        public Queue()
        {
            front = rear = -1;
            maxSize = 5;
            array = new int[maxSize];
        }

        public void Do()
        {
            this.Insert(1);
            this.Insert(2);
            this.Insert(3);
            this.Print();
            this.Delete();
            this.Print();
            this.Insert(4);
            this.Insert(5);
            this.Print();
        }

        void Print()
        {
            for (int i=front; i <=rear;i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();

        }

        void Insert(int num)
        {
            if (rear == maxSize - 1 && front == 0)
            {
                Console.WriteLine("Queue is full!");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear = rear + 1;
                array[rear] = num;
            }
        }

        int Delete()
        {
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is empty!");
                return -1;
            }
            else
            {
                int num = array[front];
                if (front >= rear)
                {
                    front = rear = -1;
                }
                else
                {
                    front = front + 1;
                }
                return num;
            }
        }
    }
}
