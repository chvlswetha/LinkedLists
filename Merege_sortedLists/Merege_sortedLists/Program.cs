using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(10);
            Node two = new Node(20);
            Node three = new Node(30);

            Node  second1 = new Node(15);
            Node second2 = new Node(17);
      

            one.next = two;
            two.next = three;

            second1.next = second2;

            Console.WriteLine("List1:");
            print(one);

            Console.WriteLine("\nList2:");
            print(second1);

            Node Merge = Sorted(one, second1);

            Console.WriteLine("\nMerged");
            print(Merge);

        }
        static Node Sorted(Node h1, Node h2)
        {
            Node ptr = new Node(-1);
            Node dummy = ptr;

            while (true)
            {
                if (h1 == null)
                {
                    ptr.next = h2;
                    break;
                }
                if (h2 == null)
                {
                    ptr.next = h1;
                    break;
                }

                if (h1.data <= h2.data)
                {
                    ptr.next = h1;
                    h1 = h1.next;
                }
                else if (h1.data > h2.data)
                {
                    ptr.next = h2;
                    h2 = h2.next;
                }

                ptr = ptr.next;
            }
            return dummy.next;

        }
        static void print(Node head)
        {
            while (head != null)
            {
                Console.Write(head.data + "->");
                head = head.next;
            }
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
