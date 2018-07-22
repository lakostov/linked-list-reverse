using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Reverse
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        class LinkedList
        {
            public Node Head { get; set; }

            public void Push(int data)
            {
                Node newNode = new Node(data);
                newNode.Next = Head;
                Head = newNode;
            }

            public void Reverse()
            {
                Node previous = null;
                Node current = Head;
                Node next = null;

                while (current != null)
                {
                    next = current.Next;
                    current.Next = previous;
                    previous = current;
                    current = next;
                }
                Head = previous;
            }

            public void PrintList()
            {
                Node temp = Head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Push(10);
            list.Push(20);
            list.Push(30);
            list.Push(40);
            list.Push(50);
            list.Push(60);
            Console.WriteLine("The initial list is:");
            list.PrintList();
            Console.WriteLine("The reverse list is:");
            list.Reverse();
            list.PrintList();
        }
    }
}
