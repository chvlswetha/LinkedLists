using System;
using System.Collections.Generic;

//Check if a linkedlist is a palindrome

namespace Palindrome_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            Node one = new Node(1);
            Node two = new Node(2);
            Node three= new Node(3);
            Node four = new Node(4);
            Node three_1 = new Node(3);
            Node two_1 = new Node(2);
            Node one_1 = new Node(1);
            Node one_2 = new Node(1);

            one.next = two;
            two.next = three;
            three.next = four;
            four.next = three_1;
            three_1.next = two_1;
            two_1.next = one_2;
            one_2.next = one_1;

            bool palin = IsPalindrome(one);
            Console.WriteLine("\nPalindrome Linkedlist: " + palin);

        }
        static bool IsPalindrome(Node head)
        {
            Node ptr = head;
            bool palin = false;
            Stack<int> s = new Stack<int>();

            while (ptr != null)
            {
                s.Push(ptr.data);
                Console.Write(ptr.data + "->");
                ptr = ptr.next;
            }

            while(head != null)
            {
                var i= s.Pop();
     
                if (i == head.data)
                    palin = true;
                else
                {
                    palin = false;
                    break;
               }
              head = head.next;
                
           }
            return palin;

        }

    }

    public class Node
    {
       public  int data;
       public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
     }
    }

