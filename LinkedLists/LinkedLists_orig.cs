// SOURCE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
// AUTHOR: Ankit Sharma,  Senior Software Engineer currently working with IVY Comptech in Hyderabad, 
//   India. He writes articles for multiple platforms, which includes c-sharpcorner, Dzone, Medium and 
//   TechNet Wiki. For his dedicated contribution to the developer’s community, he has been recognized 
//   as c-sharpcorner MVP, Dzone MVB and Top contributor in Technology at Medium.

// FILENAME: LinkedLists_orig.cs
// PURPOSE: Demonstrate how a linked list and doubly linked list works.
// STUDENT: James Hiegel
// DATE: 02 May 2019

// STYLE MODIFICATIONS: none

// FUNCTIONAL MODIFICATIONS: none

/*
* A C# program that implements a linked list and doubly linked 
* list and demonstrates various operations on those lists. 
*/
using System;

namespace LinkedLists
{
    class LinkedLists_orig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // The node of a singly linked list contains a data part and a link part. 
        // The link will contain the address of next node and is initialized to null. 
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        // The node for a Doubly Linked list will contain one data part 
        // and two link parts - previous link and next link.
        internal class DNode
        {
            internal int data;
            internal DNode prev;
            internal DNode next;
            public DNode (int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }

        // When a new Linked List is instantiated, it just has the head, 
        // which is Null.The SinglyLinkedList class will contain nodes 
        // of type Node class. 
        internal class SingleLinkedList
        {
            internal Node head;
        }

        // The DoublyLinkedList class will contain nodes of type DNode class.
        internal class DoubleLinkedList
        {
            internal DNode head;
        }
    }
}
