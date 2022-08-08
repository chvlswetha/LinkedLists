using System;

namespace K_from_Last_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(5);
            Node b = new Node(6);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(8);
            Node f = new Node(7);
            Node g = new Node(2);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;
            f.next = g;
            Node ptr = a;
            int count = 0;

            int k = 8;
            while ( ptr != null)
            {
                Console.Write(ptr.data + "->");
                count++;
                ptr = ptr.next;
            }
            Console.WriteLine("No.of nodes" + count);
            if (count < k)
                Console.WriteLine("Invalid");
            return;
            Node temp = a;
             for(int i=1; i< count -k +1; i++)
            {
                temp = temp.next;
            }

            Console.Write("Kth to last elemnt " +temp.data);

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
