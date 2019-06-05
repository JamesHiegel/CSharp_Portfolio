// AUTHOR: James Hiegel
// FILENAME: LinkedListStrings.cs
// PURPOSE: Implement a singly linked list that handles strings.
// DATE: 03 June 2019

using System;
using System.Collections.Generic;

namespace JJH
{
    class LinkedListStrings
    {
        // driver method
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            ll.DisplayList();

            ll.AppendNode("Math");
            ll.DisplayList();

            ll.AddFront("History");
            ll.DisplayList();

            ll.AddBack("Engineering");
            ll.DisplayList();

            ll.DeleteNode("Math");
            ll.DisplayList();

            ll.DeleteNode("Astronomy");
            ll.DisplayList();

            ll.AppendNode("Math");
            ll.AppendNode("Astronomy");
            ll.DisplayList();

            ll.ReverseList();
            ll.DisplayList();

            ll.Sort();
            ll.DisplayList();

            ll.InsertNode("Chemistry");
            ll.InsertNode("Algebra");
            ll.InsertNode("Physics");
            ll.InsertNode("Algebra");
            ll.InsertNode("Physics");
            ll.DisplayList();

            ll.RemoveDuplicates();
            ll.DisplayList();

            Console.WriteLine("Is list a palindrome? {0}", ll.IsPalindrome());

            ll.DeleteList();
            ll.DisplayList();

            ll.AppendNode("Alligator");
            ll.AppendNode("Toast");
            ll.AppendNode("Toast");
            ll.AppendNode("Alligator");
            ll.DisplayList();

            Console.WriteLine("Is list a palindrome? {0}", ll.IsPalindrome());

            Console.ReadLine();
        }

        // Each Node of a linked list contains data and
        // reference to the next node
        // Creating a Node takes O(1) time
        public class Node
        {
            public string data;
            public Node next;

            // constructor
            public Node(string value)
            {
                data = value;
                next = null;
            }
        }

        // The LinkedList class only holds a reference
        // to the first Node in the list
        // Creating a LinkedList takes O(1) time
        public class LinkedList
        {
            private Node first;

            // constructor
            public LinkedList()
            {
                first = null;
                //Console.WriteLine("List created!");
            }

            // The AppendNode method adds a new Node to the end of the
            // list and updates the previous node's next reference
            // Appending a Node takes O(1) time best case, and O(n) time worst case
            public void AppendNode(string value)
            {
                // create the new node
                Node newNode = new Node(value);

                // if the list is empty the new node becomes the first node
                if (IsEmpty())
                    first = newNode;
                // otherwise iterate over the list until the end
                // then add the new node to the end of the list
                else
                {
                    // sets current node to first
                    Node current = first;

                    // iterates over the list until the last node
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    // links the last node to the new node, there by extending the list
                    current.next = newNode;
                }
                //Console.WriteLine("Success: Node added!");
            }

            // The InsertNode class inserts a new Node in sorted order.
            // This method assumes the list is sorted, Using it on an 
            // unsorted list is not recommended.
            // Inserting a Node takes O(1) time best case, and O(n) time worst case
            public void InsertNode(string value)
            {
                // checks if list is empty, if so adds node
                if (IsEmpty())
                    AppendNode(value);
                // checks if newNode precedes first node,
                // if so adds newNode to the front of list
                else if (first.data.CompareTo(value) > 0)
                    AddFront(value);
                // checks if there is only one node in the list,
                // and adds it to the end of the list
                else if (first.next == null)
                    AddBack(value);
                // otherwise find where to insert it in the list
                else
                {
                    // creates the new node
                    Node newNode = new Node(value);
                    // sets two pointers
                    Node prev = first;
                    Node current = first.next;

                    // iterates over the list until the end
                    while (current.next != null)
                    {
                        // checks if the newNode preceds the current node
                        if (current.data.CompareTo(value) > 0)
                        {
                            // puts the node in the correct spot
                            prev.next = newNode;
                            newNode.next = current;
                            break;
                        }
                        // updates pointers
                        current = current.next;
                        prev = prev.next;
                    }
                    // handles if node to be inserted has to go at the end
                    if (current.next == null && current.data.CompareTo(value) <= 0)
                    {
                        current.next = newNode;
                    }
                    //Console.WriteLine("Success: Node inserted.");
                }
            }

            // The DeleteNode method searches for a Node whose data 
            // equals the specified value.
            // Deleting a Node takes O(1) time best case, and O(n) time worst case
            public void DeleteNode(string value)
            {
                // checks if list is empty
                if (IsEmpty())
                    Console.WriteLine("Error: List is empty!");
                // checks if first node has the requested value
                else if (first.data == value)
                {
                    // removes the reference to the first node
                    first = first.next;
                }
                else
                {
                    // sets two reference pointers
                    Node prev = first;
                    Node current = first.next;

                    // iterates over list until the requested value is found or the end of the list
                    while (current.data != value && current.next != null)
                    {
                        current = current.next;
                        prev = prev.next;
                    }

                    // if the value is found, remove the reference to that node
                    if (current.data == value)
                        prev.next = current.next;
                    // otherwise notify user requested value was not found
                    else
                        Console.WriteLine("Error: No nodes have the requested value!: {0}", value);
                }
                //Console.WriteLine("Success: Node deleted.");
            }

            // The DisplayList method prints out the contents of a list
            // to the console
            // Displaying the contents of a list takes O(n) time
            public void DisplayList()
            {
                if (IsEmpty())
                    Console.WriteLine("List is empty!");
                else
                {
                    Node current = first;
                    // header and first node data
                    Console.Write("List contents: ");
                    Console.Write(current.data + " ");

                    // iterates over remaining nodes and outputs their data
                    while (current.next != null)
                    {
                        current = current.next;
                        Console.Write(current.data + " ");
                    }
                    Console.WriteLine();
                }
            }

            // The IsEmpty method returns true if the
            // list is empty
            // The method takes O(1) time
            public bool IsEmpty()
            {
                return (first == null);
            }

            // The AddBack method adds a Node to the end of a list
            // It calls the AppendNode method as it is the same operation
            // Appending a Node takes O(1) time best case, and O(n) time worst case
            public void AddBack(string value)
            {
                AppendNode(value);
            }

            // The AddFront method adds a Node to the front of the list
            // Adding a Node to the front takes O(1) time
            public void AddFront(string value)
            {
                // create the new node
                Node newNode = new Node(value);

                // if the list is empty then the new node becomes the first node
                if (IsEmpty())
                    first = newNode;
                // otherwise point the new node to the first node
                else
                {
                    newNode.next = first;

                    // point first to the new node
                    first = newNode;
                }
                //Console.WriteLine("Success: Node added!");
            }

            // The ReverseList method reverses the order of the 
            // Nodes in a list
            // Reversing the nodes takes O(n) time
            public void ReverseList()
            {
                // checks if list is empty
                if (IsEmpty())
                    Console.WriteLine("Error: Can't reverse empty list!");
                // checks if list only has one node
                else if (first.next == null)
                    ;
                //Console.WriteLine("Success: List is reversed!");
                else
                {
                    // create pointers
                    Node prev = null;
                    Node current = first;
                    Node next = current.next;

                    // iterates over list until the end
                    while (current.next != null)
                    {
                        // points reference to previous node
                        current.next = prev;
                        // advances pointers to next nodes in the window
                        prev = current;
                        current = next;
                        next = current.next;
                    }
                    // links last node to prev
                    current.next = prev;
                    // points first and the new front of the list
                    first = current;
                    //Console.WriteLine("Success: List is reversed!");
                }
            }

            // The DeleteList method empties the list
            // The method takes O(1) time
            public void DeleteList()
            {
                first = null;
            }

            // The Sort method sorts the list using String.CompareTo
            // Sorting the list takes O(n^2) time
            public void Sort()
            {
                // only runs if list is not empty and is more than one node,
                // otherwise it is sorted already
                if (!IsEmpty() && !(first.next == null))
                {
                    // creates temporary list to hold sorted nodes
                    LinkedList lltmp = new LinkedList();
                    // create pointers
                    Node minNode = first;
                    Node current = first.next;

                    // loops until the list is empty
                    while (current != null)
                    {
                        // checks if current node data is smaller than minNode data
                        if (minNode.data.CompareTo(current.data) > 0)
                            // reassigns current to minNode if true
                            minNode = current;

                        // iterates over the list
                        while (current.next != null)
                        {
                            current = current.next;

                            // checks if current node data is smaller than minNode data
                            if (minNode.data.CompareTo(current.data) > 0)
                                // reassigns current to minNode if true
                                minNode = current;
                        }

                        // adds minNode to new temp list
                        lltmp.AppendNode(minNode.data);
                        // removes old node
                        DeleteNode(minNode.data);

                        // updates pointers
                        if (first != null)
                        {
                            minNode = first;
                            current = first.next;
                        }
                    }
                    lltmp.AppendNode(minNode.data);
                    // points old list to new list
                    first = lltmp.first;
                    //Console.WriteLine("Success: List is sorted!");
                }
            }

            // The RemoveDuplicates method deletes any duplicates it finds in the list
            // Removing duplicates takes O(n^2) time
            public void RemoveDuplicates()
            {
                // only runs if not empty and has more than one node,
                // otherwise no duplicates
                if (!IsEmpty() && !(first.next == null))
                {
                    // create pointers
                    Node index = first;
                    Node current;

                    // iterates index over list
                    while (index.next != null)
                    {
                        current = index.next;

                        // iterates current over list
                        while (current.next != null)
                        {
                            // checks for duplicate values and
                            // removes a node if a duplicate is found
                            if (index.data.CompareTo(current.data) == 0)
                                // This does NOT remove the current Node
                                // it removes the index node
                                DeleteNode(current.data);
                            // updates index pointer if it was removed
                            if (index == null)
                                index = first;
                            current = current.next;
                        }
                        // handles last node in the list
                        if (current.next == null)
                        {
                            if (index.data.CompareTo(current.data) == 0)
                                DeleteNode(current.data);
                        }

                        index = index.next;
                    }
                }
            }

            // The IsPalindrome method utilizes a stack to check if the list
            // is a palindrome and returns true if it is, false if it is not
            // The method takes O(n) time
            public bool IsPalindrome()
            {
                // empty lists are not palindromes
                if (IsEmpty())
                    return false;
                else
                {
                    // creates a stack to store list in reverse order
                    Stack<string> st = new Stack<string>();

                    Node current = first;
                    // iterates over list
                    while (current.next != null)
                    {
                        // adds value of each node to the stack
                        st.Push(current.data);
                        current = current.next;
                    }
                    // adds value of last node
                    st.Push(current.data);

                    // resets pointer
                    current = first;
                    // iterates over list as long as the values match and the list is not empty
                    while (current.data == st.Pop() && current.next != null)
                    {
                        current = current.next;
                    }

                    // returns false if list is not empty
                    // i.e. above loop stopped because the two values did not match
                    if (current.next != null)
                        return false;
                    // returns true if everything worked out
                    else
                        return true;
                }
            }
        }
    }
}

