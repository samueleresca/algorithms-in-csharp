using System;

namespace HandsOn.Algorithms.LinkedLists
{
    internal class LinkedList
    {
        private Node head;

        // function to add a new node at  
        // the end of the list 
        public void AddNode(Node node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                var temp = head;
                while (temp.next != null) temp = temp.next;
                temp.next = node;
            }
        }

        // function to reverse the list 
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }

        //function to print the list data 
        public void PrintList()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }

            Console.WriteLine();
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
}