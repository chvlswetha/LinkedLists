using System;
namespace RandomPointer_Linkedlist
{
      //Clone Linkedlist wikth Random pointers.
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node(1);
            Node two = new Node(2);
            Node three = new Node(3);
            Node four  = new Node(4);

            one.next = two;
            two.next = three;
            three.next = four;

            one.rand = three;
            two.rand = one;
            three.rand = null;
            four.rand = two;

            Node i = one;
            Console.WriteLine("next");
            while (i != null)
            {
                if (i.next != null)
                    Console.WriteLine(i.data + "->" + i.next.data);

                else
                    Console.WriteLine(i.data + "->" + "null");
                i = i.next;
            }

            i = one;
            Console.WriteLine("Random");
            while ( i != null)
            {
                 if(i.rand != null)
                               Console.WriteLine(i.data + "->" + i.rand.data);
                
                 else
                    Console.WriteLine(i.data + "->" + "null");
                i = i.next;
            }

            step1(one);
            step2(one);
           Node copy =  step3(one);

            i = copy;
            Console.WriteLine("After copy -Next");
            while (i != null)
            {
                if (i.next != null)
                    Console.WriteLine(i.data + "->" + i.next.data);

                else
                    Console.WriteLine(i.data + "->" + "null");
                i = i.next;
            }

            i = copy;
            Console.WriteLine("After copy -Random");
            while (i != null)
            {
                if (i.rand != null)
                    Console.WriteLine(i.data + "->" + i.rand.data);

                else
                    Console.WriteLine(i.data + "->" + "null");
                i = i.next;
            }
        }
        static void step1(Node head)
        {
            Node itr = head;
            Node front = head;

            while(itr != null)
            {
                front = itr.next;
                Node copy = new Node(itr.data);
                itr.next = copy;
                copy.next = front;
                itr = front;
            }

        }
        static void step2(Node head)
        {
            Node itr = head;
            while(itr != null)
            {
                if (itr.rand != null)
                {
                    itr.next.rand = itr.rand.next;
                }
                itr = itr.next.next;
            }
        }

        static Node step3(Node head)
        {
            Node itr = head;
            Node new1 = head.next ;
            Node copy = head.next;
            while (itr != null && new1.next != null)
            {
                itr.next = new1.next;
                new1.next = new1.next.next;
                itr = itr.next;
                new1 = new1.next;
            }
            return copy;
        }
    }

    public class Node
    {
        public int data;
        public Node next;
        public Node rand;
        public Node(int d)
        {
            data = d;
            next = null;
            rand=null;
        }
    }

}
