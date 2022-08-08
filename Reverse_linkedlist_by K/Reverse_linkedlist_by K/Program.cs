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

            print(one);

            int k = 4;

            Node reverse = ReverseK(one, k);

            Console.WriteLine("\n Reverse List by K nodes:" + k +":");
            print(reverse);

        }

       static Node ReverseK(Node head, int k)
        {
            Node Prev = null;
            Node curr = head;
            Node fut;
            int count = 0;
            while (curr != null && count < k)
            {
                fut = curr.next;
                curr.next = Prev;

                Prev = curr;
                curr = fut;

                count++;

          }
            if (curr != null)
            {
                head.next = ReverseK(curr, k);
            }
            return Prev;
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
