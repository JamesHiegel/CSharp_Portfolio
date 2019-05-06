// SOURCE: https://www.sanfoundry.com/csharp-program-binary-search-tree-linked-list/
// AUTHOR: Manish Bhojasia, a technology veteran with 20+ years @ Cisco & Wipro, is 
// Founder and CTO at Sanfoundry. He is Linux Kernel Developer & SAN Architect and is 
// passionate about competency developments in these areas. He lives in Bangalore 
// and delivers focused training sessions to IT professionals in Linux Kernel, Linux
// Debugging, Linux Device Drivers, Linux Networking, Linux Storage, Advanced C 
// Programming, SAN Storage Technologies, SCSI Internals & Storage Protocols such as 
// iSCSI & Fiber Channel.

// FILENAME: BinarySearchTree.cs
// PURPOSE: C# Program to Implement Binary Search Tree using Linked List
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added header comments for classes and methods and comments for code blocks

// FUNCTIONAL MODIFICATIONS:
// Reduced display() method in Node class to single line.

// This C# Program Implements Binary Search Tree using Linked List.A Binary tree is a 
// tree data structure in which each node has at most two child nodes, usually 
// distinguished as “left” and “right”.
using System;
using System.Collections.Generic;

namespace JJH
{
    public class BinarySearchTree
    {
        // The Main method creates a binary search tree and then displays the output via three different traversal techniques
        public static void Main(string[] args)
        {
            // creates and empty tree
            Tree theTree = new Tree();

            // populates tree with data
            Console.WriteLine("Tree created, adding data...\n");
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(99);
            theTree.Insert(91);
            Console.WriteLine("...complete.\n");

            // displays tree contents using different traversal methods
            Console.WriteLine("Depth First Traversals ");

            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine("\n");

            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine("\n");

            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine();
        }

        // The Node class contains a single integer data field, and a reference
        // to the left and right sub-nodes
        internal class Node
        {
            public int data;
            public Node leftc;
            public Node rightc;

            // Outputs the integer data field to the console
            public void display()
            {
                Console.Write("[ {0} ]", data);
            }
        }

        // The Tree class containes the root node and it's sub-nodes
        internal class Tree
        {
            // the root is the topmost node of a tree
            private Node root;

            // Default contructor
            // creates an empty tree
            public Tree()
            {
                root = null;
            }

            public Node ReturnRoot()
            {
                return root;
            }

            // The Insert method adds an integer value to the tree
            public void Insert(int id)
            {
                // creates a new node and stores the provided integer value in it
                Node newNode = new Node();
                newNode.data = id;

                // sets the newly create node as the root if there is no root already
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    // creates a new reference to the root Node
                    Node current = root;

                    // creates a new node
                    Node parent;

                    // infinite loop
                    while (true)
                    {
                        // sets parent to reference the same node as current
                        parent = current;

                        // checks if the new node's integer field is smaller than the current node's integer field
                        if (id < current.data)
                        {
                            // sets current to it's own left sub-node
                            current = current.leftc;

                            // creates a new node if the current node is empty
                            if (current == null)
                            {
                                parent.leftc = newNode;
                                // exits the while-loop
                                return;
                            }
                        }
                        else
                        // otherwise the new node's integer field is greater than or equal to the current node's integer field
                        {
                            // sets current to it's own right sub-node
                            current = current.rightc;

                            // creates a new node if the current node is empty
                            if (current == null)
                            {
                                parent.rightc = newNode;
                                // exits the while-loop
                                return;
                            }
                        }
                    }
                }
            }

            // Depth first traversals

            // The PreOrder method traverses the Tree in the following order: root, left, right
            public void Preorder(Node Root)
            {
                // checks to ensure root is not null
                if (Root != null)
                {
                    // 1) prints root data
                    Console.Write(Root.data + " ");

                    // 2 & 3) recursive calls to left node and then right node
                    Preorder(Root.leftc);
                    Preorder(Root.rightc);
                }
            }

            // The InOrder method traverses the Tree in the following order: left, root, right
            public void Inorder(Node Root)
            {
                // checks to ensure root is not null
                if (Root != null)
                {
                    // 1) recursive calls to left node
                    Inorder(Root.leftc);

                    // 2) and then prints root data
                    Console.Write(Root.data + " ");

                    // 3) and then recursive call to right node
                    Inorder(Root.rightc);
                }
            }

            // The PostOrder method traverses the Tree in the following order: left, right, root
            public void Postorder(Node Root)
            {
                // checks to ensure root is not null
                if (Root != null)
                {
                    // 1) recursive calls to left node
                    Postorder(Root.leftc);

                    // 2) and then recursive call to right node
                    Postorder(Root.rightc);

                    // 3) and then prints root data
                    Console.Write(Root.data + " ");
                }
            }
        }
    }
}

