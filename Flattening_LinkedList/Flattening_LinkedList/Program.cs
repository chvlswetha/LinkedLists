using System;

namespace Flattening_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node a5 = new Node(5);
            Node a7 = new Node(7);
            Node a8 = new Node(8);
            Node a30 = new Node(30);

            a5.bottom = a7;
            a7.bottom = a8;
            a8.bottom = a30;

            Node a10 = new Node(10);
            Node a20 = new Node(20);

            a5.next = a10;

            a10.bottom = a20;

            Node a19 = new Node(19);
            Node a22 = new Node(22);
            Node a50 = new Node(50);

            a10.next = a19;

            a19.bottom = a22;
            a22.bottom = a50;


            Node a28 = new Node(28);
            Node a35 = new Node(35);
            Node a40 = new Node(40);
            Node a45 = new Node(45);

            a19.next = a28;

            a28.bottom = a35;
            a35.bottom = a40;
            a40.bottom = a45;

            print(a5);

            Node sorted = Flatten(a5);

            Console.Write("\nFalttened List:\n");
            while (sorted != null)
            {
                Console.Write(sorted.data + "->");
                sorted = sorted.bottom;
            }
        }

        static Node Flatten(Node root)
        {
            if(root == null || root.next == null)
                return root;
            return (Merge(root, Flatten(root.next)));
        }
        static Node Merge(Node a, Node b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;
            Node result;
            if(a.data <= b.data)
            {
                result = a;
                result.bottom = Merge(a.bottom, b);
            }
            else
            {
                result = b;
                result.bottom = Merge(a, b.bottom);
            }
            result.next = null;
            return result;
        }
        static void print(Node head)
        {
            Node Next_ptr = head;
            


            while (Next_ptr != null)
            {
                Node btm_ptr = Next_ptr;
                Console.Write("\n|");
                while (btm_ptr != null)
                {
                    Console.Write(btm_ptr.data + "->");
                    btm_ptr = btm_ptr.bottom;
                }
                Next_ptr = Next_ptr.next;
            }

        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node bottom;
        public Node(int d)
        {
            data = d;
            next = null;
            bottom = null;
        }

        public Node()
        {
            data = 10;
            next = null;
            bottom = null;
        }
    }
}
