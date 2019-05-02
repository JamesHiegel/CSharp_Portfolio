﻿// SOURCE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
// AUTHOR: Ankit Sharma,  Senior Software Engineer currently working with IVY Comptech in Hyderabad, 
//   India. He writes articles for multiple platforms, which includes c-sharpcorner, Dzone, Medium and 
//   TechNet Wiki. For his dedicated contribution to the developer’s community, he has been recognized 
//   as c-sharpcorner MVP, Dzone MVB and Top contributor in Technology at Medium.

// FILENAME: LinkedLists_orig.cs
// PURPOSE: Demonstrate how a linked list and doubly linked list works.
// STUDENT: James Hiegel
// DATE: 02 May 2019

// STYLE MODIFICATIONS: Added comments from article into code.

// FUNCTIONAL MODIFICATIONS: none


// A C# program that implements a linked list and doubly linked 
// list and demonstrates various operations on those lists.
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

        // Insert data at front of the Linked List

        // The first node, head, will be null when the linked list is instantiated. When we
        // want to add any node at the front, we want the head to point to it. We will create
        // a new node.The next of the new node will point to the head of the Linked list. The 
        // previous Head node is now the second node of Linked List because the new node is 
        // added at the front.
        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        // To insert the data at front of the doubly linked list, we have to follow 
        // one extra step i.e. point the previous pointer of head node to the new node.
        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }

        // Insert data at the end of Linked List

        // If the Linked List is empty, then we simply add the new node as the Head 
        // of the Linked List. If the Linked List is not empty, then we find the last 
        // node and make next of the last node to the new node.
        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        // To insert the data at the end of a doubly linked list, we have to follow 
        // one extra step; .i.e., point previous pointer of new node to the last node.
        internal void InsertLast(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        // The last node will be the one with its next pointing to null. Hence we will
        // traverse the list until we find the node with next as null and return that 
        // node as last node.
        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal DNode GetLastNode(DoubleLinkedList doubleLinkedList)
        {
            DNode temp = doubleLinkedList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        // Insert data after a given node of Linked List

        // We have to insert a new node after a given node. We will
        // set the next of new node to the next of given node. Then 
        // we will set the next of given node to new node
        internal void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        // To perform this operation on doubly linked list we need to follow two extra steps
        // 1. Set the previous of new node to given node.
        // 2. Set the previous of the next node of given node to the new node.
        internal void InsertAfter(DNode prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
    }
}
