using System;

namespace X_less_great_linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(1);
            Node b = new Node(5);
            Node c = new Node(8);
            Node d = new Node(4);
            Node e = new Node(3);
            Node f = new Node(7);
            Node g = new Node(9);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            e.next = f;
            f.next = g;
            Console.WriteLine("Inital List:");
            print(a);

            Node x = new Node(6);
            Console.WriteLine("\nPartition Node :"+x.data);
            Node arranged = SXB(a,x);
            Console.WriteLine("\nAfter arrangement List:\n");
            print(arranged);

        }
        static Node SXB(Node ptr,Node x)
        {
            Node ss = null, se = null, es = null, ee = null, bs = null,be = null;
            while (ptr != null)
            {
                if (ptr.data < x.data)
                {
                    if (ss == null)
                        ss = se = ptr;
                    else
                    {
                        se.next = ptr;
                        se = ptr;
                    }
                }
                else if (ptr.data == x.data)
                {
                    if (es == null)
                        es = ee = ptr;
                    else
                    {
                        ee.next = ptr;
                        ee = ptr;
                    }
                }
                else if (ptr.data > x.data)
                {
                    if (bs == null)
                        bs = be = ptr;
                    else
                    {
                        be.next = ptr;
                        be = ptr;
                    }
                }
                ptr = ptr.next;
            }
                if (se != null)
                    se.next = null;
                if (ee != null)
                    ee.next = null;
                if (be != null)
                    be.next = null;

                if (ss != null && es !=null && es != null)
                {
                    se.next = es;
                    ee.next = bs;
                }
                else if(ss == null)
                    ee.next = bs;
                else if (es == null)
                    se.next = bs;
                else if (bs == null)
                    be.next = null;
            return (ss);
            }
        

        static void print(Node aa)
        {
            while (aa != null)
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
