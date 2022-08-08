using System;

namespace DeleteNode_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(2);
            Node b = new Node(5);
            Node c = new Node(4);
            Node d = new Node(3);
            Node e = new Node(6);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            Console.WriteLine("Inital List:");
            print(a);

            Node ND = d;

            Console.WriteLine("\n After deletion of Node: "+ ND.data + "\n");
            ND.data = ND.next.data;
            ND.next = ND.next.next;

            print(a);

        }

        static void print (Node aa)
        {
            while(aa != null)
            {
                Console.Write(aa.data + "->");
                aa = aa.next;
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
