using System;
using System.Collections.Generic;


//check if a linkedlist is circular.
//Determine where the circle meets.

namespace Circular_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node A = new Node('a');
            Node B = new Node('b');
            Node C = new Node('c');
            Node D = new Node('d');
            Node E = new Node('e');

            A.next = B;
            B.next = C;
            C.next = D;
            D.next = E;
            E.next = B;

            IsCircular(A);

        }
        static void IsCircular(Node ptr)
        {
            Dictionary<Node, int> d = new Dictionary<Node, int>();

            while(ptr != null)
            {
                if (d.ContainsKey(ptr))
                {
                    Console.WriteLine("Linked list is circular: and meets at : " + ptr.data);
                    break;
                }
                else
                    d.Add(ptr, 1);
                ptr = ptr.next;
            }

        }
    }

    public class Node
    {
        public char data;
        public Node next;
        public Node(char c)
        {
            data = c;
            next = null;
        }
    }
}


