// SOURCE: https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/
// AUTHOR: Ankit Sharma,  Senior Software Engineer currently working with IVY Comptech in Hyderabad, 
//   India. He writes articles for multiple platforms, which includes c-sharpcorner, Dzone, Medium and 
//   TechNet Wiki. For his dedicated contribution to the developer’s community, he has been recognized 
//   as c-sharpcorner MVP, Dzone MVB and Top contributor in Technology at Medium.

// FILENAME: LinkedLists_orig.cs
// PURPOSE: Demonstrate how a linked list and doubly linked list works.
// STUDENT: James Hiegel
// DATE: 02 May 2019

// STYLE MODIFICATIONS: 
// Added comments from article into code.

// FUNCTIONAL MODIFICATIONS:
// Added ToString methods to SinglyLinkedList and DoublyLinkedList classes.
// Added GetLastNode method for DoublyLinkedList.
// Added ReverseList method for DoublyLinkedList.


// A C# program that implements a linked list and doubly linked 
// list and demonstrates various operations on those lists.
using System;

namespace LinkedLists
{
    public class LinkedLists_orig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SinglyLinkedList Examples");
            SingleLinkedList singleLinkList = new SingleLinkedList();
            Console.WriteLine("\nAdd 81 to front of list");
            InsertFront(singleLinkList, 81);
            Console.WriteLine(singleLinkList.ToString());

            Console.WriteLine("\nAdd 54 to front of list");
            InsertFront(singleLinkList, 54);
            Console.WriteLine(singleLinkList.ToString());

            Console.WriteLine("\nAdd 27 to back of list");
            InsertLast(singleLinkList, 27);
            Console.WriteLine(singleLinkList.ToString());

            Console.WriteLine("\nReverse list");
            ReverseLinkedList(singleLinkList);
            Console.WriteLine(singleLinkList.ToString());

            Console.WriteLine("\nDoublyLinkedList Examples");

            DoubleLinkedList doubleLinkList = new DoubleLinkedList();
            Console.WriteLine("\nAdd 81 to front of list");
            InsertFront(doubleLinkList, 81);
            Console.WriteLine(doubleLinkList.ToString());

            Console.WriteLine("\nAdd 54 to front of list");
            InsertFront(doubleLinkList, 54);
            Console.WriteLine(doubleLinkList.ToString());

            Console.WriteLine("\nAdd 27 to back of list");
            InsertLast(doubleLinkList, 27);
            Console.WriteLine(doubleLinkList.ToString());

            Console.WriteLine("\nReverse list");
            ReverseLinkedList(doubleLinkList);
            Console.WriteLine(doubleLinkList.ToString());

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

            // The ToString method iterates over the list from head to tail and returns a formatted string for output
            public override string ToString()
            {
                Node temp = head;
                string output = "[" + head.data;
                while (temp.next != null)
                {
                    output += ", " + temp.next.data;
                    temp = temp.next;
                }
                output += "]";
                return output;
            }
        }

        // The DoublyLinkedList class will contain nodes of type DNode class.
        internal class DoubleLinkedList
        {
            internal DNode head;

            // The ToString method iterates over the list from head to tail and returns a formatted string for output
            public override string ToString()
            {
                DNode temp = head;
                string output = "[" + head.data;
                while (temp.next != null)
                {
                    output += ", " + temp.next.data;
                    temp = temp.next;
                }
                output += "]";
                return output;
            }
        }

        // Insert data at front of the Linked List

        // The first node, head, will be null when the linked list is instantiated. When we
        // want to add any node at the front, we want the head to point to it. We will create
        // a new node.The next of the new node will point to the head of the Linked list. The 
        // previous Head node is now the second node of Linked List because the new node is 
        // added at the front.
        internal static void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        // To insert the data at front of the doubly linked list, we have to follow 
        // one extra step i.e. point the previous pointer of head node to the new node.
        internal static void InsertFront(DoubleLinkedList doubleLinkedList, int data)
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
        internal static void InsertLast(SingleLinkedList singlyList, int new_data)
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
        internal static void InsertLast(DoubleLinkedList doubleLinkedList, int data)
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
        internal static Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal static DNode GetLastNode(DoubleLinkedList doubleLinkedList)
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
        internal static void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        // To perform this operation on doubly linked list we need to follow two extra steps
        // 1. Set the previous of new node to given node.
        // 2. Set the previous of the next node of given node to the new node.
        internal static void InsertAfter(DNode prev_node, int data)
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

        // Delete a node from Linked List using a given key value

        // First step is to find the node having the key value.  We will traverse through the Linked list,
        // and use one extra pointer to keep track of the previous node while traversing the linked list.
        // If the node to be deleted is the first node, then simply set the Next pointer of the Head to 
        // point to the next element from the Node to be deleted. 
        // If the node is in the middle somewhere, then find the node before it, and make the Node before it
        // point to the Node next to it. 
        // If the node to be deleted is last node, then find the node before it, and set it to point to null.
        internal static void DeleteNodebyKey(SingleLinkedList singlyList, int key)
        {
            Node temp = null;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        // To perform this operation on doubly linked list we don't need any extra pointer 
        // for previous node as Doubly linked list already have a pointer to previous node.
        internal static void DeleteNodebyKey(DoubleLinkedList doubleLinkedList, int key)
        {
            DNode temp = doubleLinkedList.head;
            if (temp != null && temp.data == key)
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

        // Reverse a Singly Linked list

        // We need two extra pointers to keep track of previous and next node, initialize them to null.
        // Start traversing the list from head node to last node and reverse the pointer of one node in each iteration.
        // Once the list is exhausted, set last node as head node.
        internal static void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            singlyList.head = prev;
        }
        internal static void ReverseLinkedList(DoubleLinkedList doublyLinkedList)
        {
            DNode prev = null;
            DNode current = doublyLinkedList.head;
            DNode temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            doublyLinkedList.head = prev;
        }
    }
}
