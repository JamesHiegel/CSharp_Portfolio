using NUnit.Framework;

namespace JJH
{
    /// <summary>
    /// The BinarySearchTreeTests class contains a series of tests 
    /// that verify the BinarySearchTree class functions correctly
    /// </summary>
    public class BinarySearchTreeTests
    {
        /// <summary>
        /// StudentCtorTest verifies the Student constructor 
        /// </summary>
        [Test]
        public void StudentCtorTest()
        {
            // Given
            string name = "Bill Nye";
            string major = "Mechanical Engineering";
            string state = "DC";

            // When
            Student stu = new Student(name, major, state);

            // Then
            Assert.IsTrue(stu.Name == name && stu.Major == major && stu.State == state);
        }

        /// <summary>
        /// StudentToStringTest verfies the ToString method of the Student class
        /// </summary>
        [Test]
        public void StudentToStringTest()
        {
            // Given
            string name = "Bill Nye";
            string major = "Mechanical Engineering";
            string state = "DC";

            // When
            Student stu = new Student(name, major, state);

            //Then
            Assert.AreEqual(stu.ToString(), name + ": " + major);
        }

        /// <summary>
        /// NodeCtorTest verifies the Node constructor
        /// </summary>
        [Test]
        public void NodeCtorTest()
        {
            //Given
            string name = "Bill Nye";
            string major = "Mechanical Engineering";
            string state = "DC";

            // When
            Node myNode = new Node(name, major, state);

            // Then
            Assert.IsTrue(myNode.Data.Name == name && myNode.Data.Major == major 
                && myNode.Data.State == state && myNode.Left == null && myNode.Right == null);
        }

        /// <summary>
        /// NodeToStringTest verifies the ToString method of the Student class
        /// </summary>
        [Test]
        public void NodeToStringTest()
        {
            // Given
            string name = "Bill Nye";
            string major = "Mechanical Engineering";
            string state = "DC";

            // When
            Node myNode = new Node(name, major, state);

            //Then
            Assert.AreEqual(myNode.ToString(), name + ": " + major);
        }

        /// <summary>
        /// BinarySearchTreeCtorTest verifies the BinarySearchTree constructor
        /// </summary>
        [Test]
        public void BinarySearchTreeCtorTest()
        {
            // Given, When
            BinarySearchTree bst = new BinarySearchTree();

            //Then
            Assert.IsNull(bst.Root);
        }

        /// <summary>
        /// BinarySearchTreeIsEmptyTest verifies the IsEmpty method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreeIsEmptyTest()
        {
            // Given, When
            BinarySearchTree bst = new BinarySearchTree();

            // Then
            Assert.IsTrue(bst.IsEmpty());
        }

        /// <summary>
        /// BinarySearchTreeInsertTest verifies the Insert method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreeInsertTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name = "Bill Nye";
            string major = "Mechanical Engineering";
            string state = "DC";

            // When
            bst.Insert(name, major, state);

            // Then
            Assert.AreEqual(bst.Root.ToString(), name + ": " + major);
        }

        /// <summary>
        /// BinarySearchTreeInsertLeftTest verifies the Insert method of the BinarySearchTree class with a left child node
        /// </summary>
        [Test]
        public void BinarySearchTreeInsertLeftTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";
            
            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            // When
            bst.Insert(name1, major1, state1);
            // this Node should be the left child
            bst.Insert(name2, major2, state2);

            // Then
            Assert.AreEqual(bst.Root.Left.ToString(), name2 + ": " + major2);
        }

        /// <summary>
        /// BinarySearchTreeInsertRightTest verifies the Insert method of the BinarySearchTree class with a left child node
        /// </summary>
        [Test]
        public void BinarySearchTreeInsertRightTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Daniel Craig";
            string major2 = "Acting";
            string state2 = "England";

            // When
            bst.Insert(name1, major1, state1);
            // this Node should be the right child
            bst.Insert(name2, major2, state2);

            // Then
            Assert.AreEqual(bst.Root.Right.ToString(), name2 + ": " + major2);
        }

        /// <summary>
        /// BinarySearchTreeInsertStudentTest verifies the Insert method of the BinarySearchTree class,
        /// using a Student object
        /// </summary>
        [Test]
        public void BinarySearchTreeInsertStudentTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";
            
            Student myStudent = new Student(name1, major1, state1);

            // When
            // uses the overriden Insert method that takes a Student object
            bst.Insert(myStudent);

            // Then
            Assert.AreEqual(bst.Root.ToString(), name1 + ": " + major1);
        }

        /// <summary>
        /// BinarySearchTreeInOrderTraversalEmptyTest verifies the InOrderTraversal method of the BinarySearchTree class,
        /// when the tree is empty.
        /// </summary>
        [Test]
        public void BinarySearchTreeInOrderTraversalEmptyTest()
        {
            // Given, When
            BinarySearchTree bst = new BinarySearchTree();

            string expected = "Tree is empty!";
            
            // Then
            Assert.AreEqual(bst.InOrderTraversal(), expected);
        }

        /// <summary>
        /// BinarySearchTreeInOrderTraversalFullTest verifies the InOrderTraversal method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreeInOrderTraversalFullTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            string expected = name2 + ": " + major2 + "\n"
                            + name4 + ": " + major4 + "\n"
                            + name1 + ": " + major1 + "\n"
                            + name3 + ": " + major3 + "\n"
                            + name5 + ": " + major5 + "\n";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);
            bst.Insert(name5, major5, state5);

            // Then
            Assert.AreEqual(bst.InOrderTraversal(), expected);
        }

        /// <summary>
        /// BinarySearchTreePreOrderTraversalFullTest verifies the PreOrderTraversal method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreePreOrderTraversalFullTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            string expected = name1 + ": " + major1 + "\n"
                            + name2 + ": " + major2 + "\n"
                            + name4 + ": " + major4 + "\n"
                            + name3 + ": " + major3 + "\n"
                            + name5 + ": " + major5 + "\n";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);
            bst.Insert(name5, major5, state5);

            // Then
            Assert.IsTrue(bst.PreOrderTraversal() == expected);
        }

        /// <summary>
        /// BinarySearchTreePostOrderTraversalFullTest verifies the PostOrderTraversal method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreePostOrderTraversalFullTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            string expected = name4 + ": " + major4 + "\n" 
                            + name2 + ": " + major2 + "\n"
                            + name5 + ": " + major5 + "\n"
                            + name3 + ": " + major3 + "\n"
                            + name1 + ": " + major1 + "\n";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);
            bst.Insert(name5, major5, state5);

            // Then
            Assert.IsTrue(bst.PostOrderTraversal() == expected);
        }

        /// <summary>
        /// BinarySearchTreeEmptySearchTest verifies the Search method of the BinarySearchTree class,
        /// on an empty tree
        /// </summary>
        [Test]
        public void BinarySearchTreeEmptySearchTest()
        {
            // Given, When
            BinarySearchTree bst = new BinarySearchTree();
            // Then
            Assert.IsFalse(bst.Search("Bill Nye"));
        }

        /// <summary>
        /// BinarySearchTreeValidSearchTest verifies the Search method of the BinarySearchTree class,
        /// with a search term in an existing tree
        /// </summary>
        [Test]
        public void BinarySearchTreeValidSearchTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);
            bst.Insert(name5, major5, state5);

            // Then
            Assert.IsTrue(bst.Search("Bill Nye"));
        }

        /// <summary>
        /// BinarySearchTreeInvalidSearchTest verifies the Search method of the BinarySearchTree class,
        /// with search term that is not in an existing tree
        /// </summary>
        [Test]
        public void BinarySearchTreeInvalidSearchTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            string name5 = "Mel Brooks";
            string major5 = "Psychology";
            string state5 = "NY";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);
            bst.Insert(name5, major5, state5);

            // Then
            Assert.IsFalse(bst.Search("David Letterman"));
        }

        /// <summary>
        /// BinarySearchTreeHeightTest verifies the Height method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreeHeightTest()
        {
            // Given
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);

            // Then
            Assert.AreEqual(2, bst.Height());
        }

        /// <summary>
        /// BinarySearchTreeLeafNodesTest verifies the NumLeafNodes method of the BinarySearchTree class
        /// </summary>
        [Test]
        public void BinarySearchTreeLeafNodesTest()
        {
            BinarySearchTree bst = new BinarySearchTree();

            string name1 = "Bill Nye";
            string major1 = "Mechanical Engineering";
            string state1 = "DC";

            string name2 = "Adam West";
            string major2 = "Literature";
            string state2 = "WA";

            string name3 = "Daniel Craig";
            string major3 = "Acting";
            string state3 = "England";

            string name4 = "Arnold Schwarzenegger";
            string major4 = "Fitness";
            string state4 = "England";

            // When
            bst.Insert(name1, major1, state1);
            bst.Insert(name2, major2, state2);
            bst.Insert(name3, major3, state3);
            bst.Insert(name4, major4, state4);

            // Then
            Assert.AreEqual(2, bst.NumLeafNodes());
        }
    }
}