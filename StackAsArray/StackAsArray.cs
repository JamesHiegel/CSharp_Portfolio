// SOURCE: https://www.geeksforgeeks.org/implementing-stack-c-sharp/
// AUTHORS: Ankit Sharma

// FILENAME: StackAsArray.cs
// PURPOSE: Implement a stack utilizing an array data structure.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added comments to classes, methods and code blocks to describe what is occuring in the program
// Added descriptive writelines to main method to clarify the demonstration

// FUNCTIONAL MODIFICATIONS:
// Replaced instances of (top < 0) with IsEmpty().
// Added access modifiers on classes and methods.
// Extracted underflow checks into a seperate method

// A Stack is a linear data structure. It follows LIFO(Last In First Out) pattern 
// for Input/output. Following three basic operations are performed in the stack:
// Push: Adds an item in the stack.If the stack is full, then it is said to be a 
// stack Overflow condition.
// Pop: Removes an item from the stack. The items are popped in the reversed order 
// in which they are pushed. If the stack is empty, then it is said to be a stack 
// Underflow condition.
// Peek : Return the topmost element of stack.

using System;

namespace JJH
{
    public class StackAsArray
    {
        // The Main method...
        public static void Main(string[] args)
        {
            // creates an empty stack for demonstration purposes
            Stack myStack = new Stack();

            Console.WriteLine("Is the stack empty?: {0}\n", myStack.IsEmpty());

            // adds multiple values to the stack
            Console.WriteLine("Let's add some data to it.\nAdding...");
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);

            Console.WriteLine("\nIs the stack empty?: {0}", myStack.IsEmpty());

            // displays contents of stack to the console
            myStack.PrintStack();

            Console.WriteLine("\nLet's peek at the top element of the stack.");

            // displays the top element of the stack, without removing it
            myStack.Peek();

            // pops the topmost element off the stack
            Console.WriteLine("\nNow let's pop the top element.");
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());

            Console.WriteLine("\nWhat's in the stack now?");

            // displays the contents of the stack showing the new stack
            myStack.PrintStack();
        }
    }

    // The Stack class...
    internal class Stack
    {
        // creates integer array with MAX size
        private static readonly int MAX = 1000;
        private int top;
        private int[] stack = new int[MAX];

        // Default constructor
        // top is marked as negative number so IsEmpty method returns false
        public Stack()
        {
            top = -1;
        }

        internal bool IsEmpty()
        {
            return (top < 0);
        }

        // Helper method that consolidates some repetive code
        internal bool CheckForUnderflow()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return true;
            }
            return false;
        }

            // The Push method increments the top variable and adds an integer to the array at the top index
            internal bool Push(int data)
        {
            // checks to see if stack is full
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                // since top starts at -1, pre-increment is used to set correct array index
                stack[++top] = data;
                return true;
            }
        }

        // The Pop method returns the value at the top of the stack
        internal int Pop()
        {
            // checks to see if stack is empty
            if (!CheckForUnderflow())
            {
                // saves the value of the top index
                // post -increment moves top to previous index in the array
                int value = stack[top--];
                return value;
            }
            else
            {
                return 0;
            }
        }

        // The Peek method returns the value at the top index, without remove it from the stack
        internal void Peek()
        {
            // checks to see if stack is empty
            if (!CheckForUnderflow())
            {
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
            }
        }

        // The PrintStack method displays the contents of the stack to the console
        internal void PrintStack()
        {
            // checks to see if stack is empty
            if (!CheckForUnderflow())
            {
                // iterates over array, outputting values
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
