using System;

namespace TwoLinkedList_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a1 = new Node(0);
            Node a2 = new Node(6);

            Node b1 = new Node(0);
            Node b2 = new Node(5);
            Node b3 = new Node(7);

            a1.next = a2;

            b1.next = b2;
            b2.next = b3;

            Console.WriteLine("\n List 1:");
            print(a1);

            Console.WriteLine("\n List 2: \n");
            print(b1);

            Node summed = Sumlist(a1, b1);

            Console.WriteLine("\n Summed List : \n");
            print(summed);
            Console.WriteLine("\n");

        }

        static Node Sumlist(Node h1, Node h2)
        {
            string s= (NodetoInt(h1) + NodetoInt(h2)).ToString();
            Console.WriteLine("Total:" + s);
            Node prev =new Node(-1), sum1;
            Node dummy = prev;
            for (int i= s.Length - 1; i>=0; i--)
            {
                sum1 = new Node((int)char.GetNumericValue(s[i]));
                prev.next = sum1;
                prev = prev.next;
            }
            return dummy.next;
        }

        static int NodetoInt(Node h)
        {
            int count = 0, val_int = 0;
            while(h != null)
            {
                int val = h.data;
                val = val * (int)Math.Pow(10, count);
                val_int += val;
                count++;
                h = h.next;
            }
            Console.WriteLine("\nInteger values:" + val_int);
            return val_int;
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
