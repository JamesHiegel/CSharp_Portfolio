// SOURCE: https://www.geeksforgeeks.org/implementing-stack-c-sharp/
// AUTHORS: Ankit Sharma

// FILENAME: StackAsArray.cs
// PURPOSE: Implement a stack utilizing an array data structure.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
//

// FUNCTIONAL MODIFICATIONS:
//

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
        private static readonly int MAX = 1000;
        private int top;
        private int[] stack = new int[MAX];

        // Default constructor
        public Stack()
        {
            top = -1;
        }

        public bool IsEmpty()
        {
            return (top < 0);
        }

        // The Push method...
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        // The Pop method...
        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        // The Peek method...
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        // The PrintStack method...
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
