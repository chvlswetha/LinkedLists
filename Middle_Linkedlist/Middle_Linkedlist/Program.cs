using System;

namespace Middle_LinkedList
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
            Node six= new Node(6);


            one.next = two;
            two.next = three;
            three.next = four;
            four.next = five;
            five.next = six;
        

            Console.WriteLine("Initial List:");
            print(one);

            Node mid = FindMid(one);

            Console.WriteLine("\n  Mid Element is:" + mid.data);

        }
        static Node FindMid(Node head)
        {            Node slow = head, fast = head;
            while (fast != null  && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

            }
            return slow;
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
