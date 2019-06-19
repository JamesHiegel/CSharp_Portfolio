using System;

namespace JJH
{
    /// <summary>
    /// The BinarySearchTreeDriver demonstrates the methods of the BinarySearchTree class.
    /// </summary>
    public class BinarySearchTreeDriver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates a Binary Search Tree");

            // create new tree
            BinarySearchTree bst = new BinarySearchTree();
            Console.WriteLine("Tree created.");

            Console.WriteLine("Is it empty? " + bst.IsEmpty());

            // data for adding three nodes to the tree
            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";
            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";
            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            Console.WriteLine();

            // add three nodes to the tree
            Console.WriteLine("Adding three nodes to the tree.");
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);

            Console.WriteLine("Contents of tree:\n" + bst.InOrderTraversal());

            Console.WriteLine("Is Mel Brooks in the list? " + bst.Search("Mel Brooks"));

            Console.WriteLine("How tall is the tree? " + bst.Height());

            Console.WriteLine("How many leaves are in the tree? " + bst.NumLeafNodes());

            Console.WriteLine();

            // data for adding two nodes to the tree
            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";
            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            // data for adding two nodes to the tree, this time as Student objects
            Console.WriteLine("Adding two more nodes to the tree.");
            Student stu1 = new Student(name4, major4, state4);
            Student stu2 = new Student(name5, major5, state5);
            bst.Insert(stu1);
            bst.Insert(stu2);

            Console.WriteLine("Contents of tree:\n" + bst.InOrderTraversal());

            Console.WriteLine("Is Mel Brooks in the list now? " + bst.Search("Mel Brooks"));

            Console.WriteLine("How tall is the tree now? " + bst.Height());

            Console.WriteLine("How many leaves are in the tree now? " + bst.NumLeafNodes());
        }
    }

    /// <summary>
    /// The Student class represents student data at a school
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student's full name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Student's academic major
        /// </summary>
        public string Major { get; set; }
        /// <summary>
        /// Student's home state or country if not US
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Creates a Student object
        /// </summary>
        /// <param name="name">Student's full name</param>
        /// <param name="maj">Student's academic major</param>
        /// <param name="state">Student's home state or country if not US</param>
        public Student(string name, string maj, string state)
        {
            this.Name = name;
            this.Major = maj;
            this.State = state;
        }

        /// <summary>
        /// The ToString method returns a string displaying the student's name and major
        /// </summary>
        /// <returns>The student's name and major.</returns>
        public override string ToString()
        {
            return Name + ": " + Major;
        }
    }

    /// <summary>
    /// The Node class represents the node in a tree
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Contains a single Student object
        /// </summary>
        public Student Data { get; set; }
        /// <summary>
        /// Reference to the Left child Node
        /// </summary>
        public Node Left { get; set; }
        /// <summary>
        /// Reference to the Right child Node
        /// </summary>
        public Node Right { get; set; }

        /// <summary>
        /// Creates a Node object
        /// </summary>
        /// <param name="name">Student's full name</param>
        /// <param name="major">Student's academic major</param>
        /// <param name="state">Student's home state or country if not US</param>
        public Node(string name, string major, string state)
        {
            Data = new Student(name, major, state);
            Left = null;
            Right = null;
        }

        /// <summary>
        /// Creates a Node object from a Student Object
        /// </summary>
        /// <param name="newStudent"></param>
        public Node(Student newStudent)
        {
            Data = newStudent;
            Left = null;
            Right = null;
        }

        /// <summary>
        /// The ToString method returns a string displaying the student's name and major
        /// </summary>
        /// <returns>The student's name and major.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }

    }

    /// <summary>
    /// The BinarySearchTree class represents a binary search tree
    /// </summary>
    public class BinarySearchTree
    {
        /// <summary>
        /// The Root is the topmost node of the tree
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Creates an empty Binary Search Tree
        /// </summary>
        public BinarySearchTree()
        {
            Root = null;
        }

        /// <summary>
        /// The IsEmpty method returns true if empty, false if not
        /// </summary>
        /// <returns>true if empty, false if not</returns>
        public bool IsEmpty()
        {
            return Root == null;
        }

        /// <summary>
        /// This Insert method takes a Student object and adds it in alphabetical name order into the tree
        /// </summary>
        /// <param name="newStudent">Student object to be inserted</param>
        public void Insert(Student newStudent)
        {
            Node newNode = new Node(newStudent);

            // if tree is empty, the new Node is now the root
            if (IsEmpty())
                Root = newNode;
            // otherwise create a new node and find the right spot for it
            else
            {
                Node curr = Root;
                // loops until an empty spot is found
                while (curr != null)
                {
                    // puts the new node is the correct alphabetical name order
                    if (string.Compare(newNode.Data.Name, curr.Data.Name) <= 0)
                    {
                        if (curr.Left != null)
                            curr = curr.Left;
                        else
                        {
                            // adds the new node and exits the while loop
                            curr.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        if (curr.Right != null)
                            curr = curr.Right;
                        else
                        {
                            // adds the new node and exits the while loop
                            curr.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// This Insert method takes the data for a Student object, creates one and adds it in alphabetical name order into the tree
        /// </summary>
        /// <param name="name">Student's full name</param>
        /// <param name="major">Student's academic major</param>
        /// <param name="state">Student's home state or country if not US</param>
        public void Insert(string name, string major, string state)
        {
            // calls the other Insert method passing a new Student object
            Insert(new Student(name, major, state));
        }

        /// <summary>
        /// The InOrderTraversal method returns a string with the values of each node in alphabetical order
        /// </summary>
        /// <returns>A multi-line string with the values of all nodes in the tree, in alphabetical order</returns>
        public string InOrderTraversal()
        {
            // temporary string to collect output
            string ret = "";
            // checks if tree is empty
            if (IsEmpty())
                ret = "Tree is empty!";
            else
            {
                // calls recursive helper method,
                // passing a string by reference
                InOrder(Root, ref ret);
            }
            return ret;
        }

        /// <summary>
        /// The InOrder is a recursive helper method that appends the value of each node to a provided string parameter
        /// </summary>
        /// <param name="currNode">The current Node object</param>
        /// <param name="ret">A string parameter passed by reference to it can be appended to</param>
        private void InOrder(Node currNode, ref string ret)
        {
            // recursive call to the left child node
            if (currNode.Left != null)
                InOrder(currNode.Left, ref ret);
            // appends current node date to string passed by reference
            ret += currNode.ToString() + "\n";
            // recursive call to the right child node
            if (currNode.Right != null)
                InOrder(currNode.Right, ref ret);
        }

        /// <summary>
        /// The PreOrderTraversal method returns a string with the values of each node in pre order form
        /// </summary>
        /// <returns>A multi-line string with the values of all nodes in the tree, in pre order form</returns>
        public string PreOrderTraversal()
        {
            // temporary string to collect output
            string ret = "";
            // checks if tree is empty
            if (IsEmpty())
                ret = "Tree is empty!";
            else
            {
                // calls recursive helper method,
                // passing a string by reference
                PreOrder(Root, ref ret);
            }
            return ret;
        }

        /// <summary>
        /// The PreOrder is a recursive helper method that appends the value of each node to a provided string parameter
        /// </summary>
        /// <param name="currNode">The current Node object</param>
        /// <param name="ret">A string parameter passed by reference to it can be appended to</param>
        private void PreOrder(Node currNode, ref string ret)
        {
            // appends current node date to string passed by reference
            ret += currNode.ToString() + "\n";
            // recursive call to the left child node
            if (currNode.Left != null)
                PreOrder(currNode.Left, ref ret);
            // recursive call to the right child node
            if (currNode.Right != null)
                PreOrder(currNode.Right, ref ret);
        }

        /// <summary>
        /// The PostOrderTraversal method returns a string with the values of each node in post order form
        /// </summary>
        /// <returns>A multi-line string with the values of all nodes in the tree, in post order form</returns>
        public string PostOrderTraversal()
        {
            // temporary string to collect output
            string ret = "";
            // checks if tree is empty
            if (IsEmpty())
                ret = "Tree is empty!";
            else
            {
                // calls recursive helper method,
                // passing a string by reference
                PostOrder(Root, ref ret);
            }
            return ret;
        }

        /// <summary>
        /// The PostOrder is a recursive helper method that appends the value of each node to a provided string parameter
        /// </summary>
        /// <param name="currNode">The current Node object</param>
        /// <param name="ret">A string parameter passed by reference to it can be appended to</param>
        private void PostOrder(Node currNode, ref string ret)
        {
            // recursive call to the left child node
            if (currNode.Left != null)
                PostOrder(currNode.Left, ref ret);
            // recursive call to the right child node
            if (currNode.Right != null)
                PostOrder(currNode.Right, ref ret);
            // appends current node date to string passed by reference
            ret += currNode.ToString() + "\n";
        }

        /// <summary>
        /// The Search method returns a bool value if the search term is found in the Name property of a Node
        /// </summary>
        /// <param name="key">A string that is compared to the Name property of Nodes</param>
        /// <returns>True is key is found, false if not</returns>
        public bool Search(string key)
        {
            // temp variable
            bool ret;
            // check if tree is empty
            if (IsEmpty())
                ret = false;
            else
            {
                // start search at Root of tree
                Node curr = Root;
                // loops until a match is found or at bottom of tree
                while (curr != null && curr.Data.Name != key)
                {
                    // searchs left or right based on alphabetical order
                    if (string.Compare(key, curr.Data.Name) <= 0)
                        curr = curr.Left;
                    else
                        curr = curr.Right;
                }
                // is only false if no match was found
                ret = curr != null;
            }
            return ret;
        }

        /// <summary>
        /// The Height method returns the number of edges in the tree
        /// </summary>
        /// <returns>An int which is equal to the number of edges in the tree</returns>
        public int Height()
        {
            // temp variable
            int ret;
            // checks if empty
            if (IsEmpty())
                ret = 0;
            else
                // calls recursive helper method
                ret = HeightHelper(Root);
            return ret;
        }

        /// <summary>
        /// The HeightHelper method is a recursive helper method used to count the number of edges in a tree
        /// </summary>
        /// <param name="curr">The current Node object</param>
        /// <returns>An int indicating the current count of edges</returns>
        private int HeightHelper(Node curr)
        {
            // temp variable
            int ret;
            // checks if there are no child Nodes
            if (curr.Left == null && curr.Right == null)
                ret = 0;
            else
            {
                // counter used to see which branch is larger
                int left = 0;
                int right = 0;

                // recursive call to child Node(s) if present,
                // increments respective counter
                if (curr.Left != null)
                    left = HeightHelper(curr.Left) + 1;
                if (curr.Right != null)
                    right = HeightHelper(curr.Right) + 1;
                
                // compares both sub counts and returns the larger once
                if (left > right)
                    ret = left;
                else
                    ret = right;
            }
            return ret;
        }

        /// <summary>
        /// The NumLeafNodes method returns the number of leaf nodes in a tree
        /// </summary>
        /// <returns>An int indicating the current count of leaf nodes</returns>
        public int NumLeafNodes()
        {
            // temp variable
            int ret;
            // checks if the tree is empty or if the Root has no child Nodes
            if (IsEmpty() || (Root.Left == null && Root.Right == null))
                ret = 0;
            else
                // calls recursive helper method
                ret = LeafNodes(Root);
            return ret;
        }

        /// <summary>
        /// The LeafNodes method is a recursive helper method used to count the number of leaf nodes in a tree 
        /// </summary>
        /// <param name="curr">The current Node</param>
        /// <returns>An int indicating the current count of leaf nodes</returns>
        private int LeafNodes(Node curr)
        {
            // temp variable
            int ret = 0;
            // checks if there are no child Nodes, if true then it's a leaf node
            if (curr.Left == null && curr.Right == null)
                ret = 1;
            else
            {
                // recursive calls that can add to the leaf node count
                if (curr.Left != null)
                    ret += LeafNodes(curr.Left);
                if (curr.Right != null)
                    ret += LeafNodes(curr.Right);
            }
            return ret;
        }
    }
}
