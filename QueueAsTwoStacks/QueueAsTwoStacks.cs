using System;
using System.Collections.Generic;

namespace JJH
{
    class QueueAsTwoStacks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program implements a Queue using two Stacks.");

            Console.WriteLine("Creating queue...");
            QueueV2 q2 = new QueueV2();

            Console.WriteLine("Queue created, adding items:");
            Random r = new Random();
            for (int i = 0; i <= 10; i++)
            {
                q2.Enqueue(i.ToString());
                Console.Write(i.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Emptying queue:");
            while (q2.count != 0)
            {
                Console.Write(q2.Dequeue() + " ");
            }
        }
    }

    public class QueueV2
    {
        // two stacks used to implement queue
        private Stack<string> pri;
        private Stack<string> alt;
        public int count { get; set; }

        // constructor
        public QueueV2()
        {
            pri = new Stack<string>();
            alt = new Stack<string>();
            count = 0;        }

        // The Enqueue method adds an element to the end of
        // the queue
        public void Enqueue(string input)
        {
            // adds new element to pri stack if the
            // queue is empty
            if (pri.Count == 0)
                pri.Push(input);
            else
            {
                // pops the pri stack onto the alt stack
                while (pri.Count != 0)
                {
                    alt.Push(pri.Pop());
                }
                // adds the new element to the pri stack
                pri.Push(input);
                // pops the alt stack back onto the pri stack
                // preserving the queue order
                while (alt.Count != 0)
                {
                    pri.Push(alt.Pop());
                }
            }
            count += 1;
        }

        // The Dequeue method removes and returns the element
        // at the front of the queue
        public string Dequeue()
        {
            count -= 1;
            return pri.Pop();
        }

        // The Peek method returns the element at the
        // front of the queue without removing it
        public string Peek()
        {
            return pri.Peek();
        }
    }
}
