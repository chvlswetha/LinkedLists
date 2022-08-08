using System;

namespace ReverseLinkedList_Recurssion
{
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four = new Node(4);
     

            one.next = two;
            two.next = three;
            three.next = four;

            Console.WriteLine("Initial List:");
            print(one);

            Node reverse = reversed(one);
            Console.WriteLine("\nReverse  List:");
            print(reverse);

        }
        static Node reversed(Node one)
        {
            if(one == null || one.next == null)
                    return one;
           Node reverse = reversed(one.next);

            one.next.next = one;
            one.next = null;
            return reverse;
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
