using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
            Node five = new Node(5);
            Node six = new Node(6);
            Node seven = new Node(7);
            Node eight = new Node(8);

            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
            six.next = seven;

            seven.next = eight;

            Console.WriteLine("List:");
            print(one);

            Node Swapped = Swap(one);

            Console.WriteLine("\n Swapped List:");
            print(Swapped);
        }

        static Node Swap(Node head)
        {
            Node swapped = head;
            while(head != null && head.next != null)               
            {
                    
                    int temp = head.data;
                    head.data = head.next.data;
                    head.next.data = temp;

                    head = head.next.next;
             
            }

            return swapped;
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
