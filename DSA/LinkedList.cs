using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class LinkedList
    {
        Node head;
        Node firstNode;
        
        public void Do()
        {
            var fn = firstNode = head = new Node(2);
            var node3 = Insert(head, 3);
            var node4 = Insert(head, 4);
            var node5 = Insert(head, 5);
            Print();
            firstNode = fn;
            Delete(node5,node4);
            Print();
            firstNode = fn;
            var node6 = Insert(head, 6);
            var node7 = Insert(head, 7);
            Print();
        }

        Node Insert(Node head, int num)
        {
            Node newNode = new Node(num);
            head.next = newNode;
            this.head = newNode;
            return newNode;
        }

        void Delete(Node nodeToDelete, Node previousNode)
        {
            previousNode.next = nodeToDelete.next;
            this.head = previousNode;
        }

        void Print()
        {
            while(this.firstNode != null)
            {
                Console.Write(firstNode.value + " ");
                firstNode = firstNode.next;
            }
        }
    }

    class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
            next = null;
        }
    }


}
