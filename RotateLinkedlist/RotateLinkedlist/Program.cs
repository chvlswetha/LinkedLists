using System;

namespace RotateLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(10);
            Node two = new Node(20);
            Node three = new Node(30);
            Node four = new Node(40);
            Node five = new Node(50);
            Node six = new Node(60);

             one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;

            Console.WriteLine("Initial List:");
            print(one);

            int k = 3;
            Node head = one;
            Node newhead = one;
            Node prev = new Node(-1);
            for(int i=0; i < k; i++)
            {
                prev = newhead;
                newhead = newhead.next;
            }

            Node rotated = newhead;
            while( newhead != null)
            {
                if (newhead.next == null)
                    newhead.next = head;
                newhead = newhead.next;
                if (newhead == prev)
                {
                    newhead.next = null;
                    break;
                }
            }

            Console.WriteLine("\nrotete List:");
            print(rotated);


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
