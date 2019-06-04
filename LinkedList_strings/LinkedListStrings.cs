using System;

namespace JJH
{
    class LinkedListStrings
    {
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
            ll.DisplayList();
        }

        public class Node
        {
            public string data;
            public Node next;

            public Node(string value)
            {
                data = value;
                next = null;
            }
        }

        public class LinkedList
        {
            private Node first;

            public LinkedList()
            {
                first = null;
                Console.WriteLine("List created!");
            }

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
                Console.WriteLine("Success: Node added!");
            }

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
                    Node newNode = new Node(value);

                    Node prev = first;
                    Node current = first.next;

                    while (current.next != null)
                    {
                        // checks if the newNode preceds the current node
                        if (current.data.CompareTo(value) > 0)
                        {
                            prev.next = newNode;
                            newNode.next = current;
                            break;
                        }
                        current = current.next;
                        prev = prev.next;
                    }
                    Console.WriteLine("Success: Node inserted.");
                }
            }

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
                        Console.WriteLine("Error: No nodes have the requested value! {0}: ", value);
                }
                Console.WriteLine("Success: Node deleted.");
            }

            public void DisplayList()
            {
                if (IsEmpty())
                    Console.WriteLine("List is empty!");
                else
                {
                    Node current = first;

                    Console.Write("List contents: ");
                    Console.Write(current.data + " ");

                    while (current.next != null)
                    {
                        current = current.next;
                        Console.Write(current.data + " ");
                    }
                    Console.WriteLine();
                }
            }

            public bool IsEmpty()
            {
                return (first == null);
            }

            public void AddBack(string value)
            {
                AppendNode(value);
            }

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
                Console.WriteLine("Success: Node added!");
            }

            public void ReverseList()
            {
                // checks if list is empty
                if (IsEmpty())
                    Console.WriteLine("Error: Can't reverse empty list!");
                // checks if list only has one node
                else if (first.next == null)
                    Console.WriteLine("Success: List is reversed!");
                else
                {
                    Node prev = null;
                    Node current = first;
                    Node next = current.next;

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
                }
                Console.WriteLine("Success: List is reversed!");
            }

            public void DeleteList()
            {
                first = null;
            }

            public void Sort()
            {
                // checks if list is empty
                if (IsEmpty())
                    Console.WriteLine("Error: Can't sort empty list!");
                // checks if list is just a single node
                else if (first.next == null)
                    Console.WriteLine("Success: List is sorted!");
                else
                {
                    LinkedList lltmp = new LinkedList();

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

                        if (first != null)
                        {
                            minNode = first;
                            current = first.next;
                        }
                    }
                    lltmp.AppendNode(minNode.data);
                    // points old list to new list
                    first = lltmp.first;
                }
                Console.WriteLine("Success: List is sorted!");
            }
        }
    }
}

