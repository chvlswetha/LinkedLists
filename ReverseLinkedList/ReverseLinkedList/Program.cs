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

            one.next = two;
            two.next = three;
            three.next = four;

            print(one);


            Node prev = one;
            Node cur = one.next;
            prev.next = null;

            while (cur != null)
            {
                Node fut = cur.next;
                cur.next = prev;

                prev = cur;
                cur = fut;
            }
            Console.WriteLine("\n After Reverse:");
            print(prev);
        }
        static void print (Node head)
        {
            while(head != null)
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
