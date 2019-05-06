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
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
        }
    }

    // The Stack class...
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        // Default constructor
        public Stack()
        {
            top = -1;
        }

        // The IsEmpty method...
        bool IsEmpty()
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
