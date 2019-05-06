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


// FUNCTIONAL MODIFICATIONS:


// This C# Program Implements Binary Search Tree using Linked List.A Binary tree is a 
// tree data structure in which each node has at most two child nodes, usually 
// distinguished as “left” and “right”.
using System;

namespace JJH
{
    class BinarySearchTree
    {
        // The Main method...
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
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
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        // The Node class...
        class Node
        {
            public int item;
            public Node leftc;
            public Node rightc;
            public void display()
            {
                Console.Write("[");
                Console.Write(item);
                Console.Write("]");
            }
        }

        // The Tree class...
        class Tree
        {
            public Node root;
            public Tree()
            {
                root = null;
            }
            public Node ReturnRoot()
            {
                return root;
            }
            public void Insert(int id)
            {
                Node newNode = new Node();
                newNode.item = id;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (id < current.item)
                        {
                            current = current.leftc;
                            if (current == null)
                            {
                                parent.leftc = newNode;
                                return;
                            }
                        }
                        else
                        {
                            current = current.rightc;
                            if (current == null)
                            {
                                parent.rightc = newNode;
                                return;
                            }
                        }
                    }
                }
            }
            public void Preorder(Node Root)
            {
                if (Root != null)
                {
                    Console.Write(Root.item + " ");
                    Preorder(Root.leftc);
                    Preorder(Root.rightc);
                }
            }
            public void Inorder(Node Root)
            {
                if (Root != null)
                {
                    Inorder(Root.leftc);
                    Console.Write(Root.item + " ");
                    Inorder(Root.rightc);
                }
            }
            public void Postorder(Node Root)
            {
                if (Root != null)
                {
                    Postorder(Root.leftc);
                    Postorder(Root.rightc);
                    Console.Write(Root.item + " ");
                }
            }
        }
    }
}

