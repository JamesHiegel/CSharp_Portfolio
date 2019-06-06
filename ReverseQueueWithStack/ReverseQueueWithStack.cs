using System;
using System.Collections.Generic;

namespace JJH
{
    class ReverseQueueWithStack
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program utilizes a Stack to reverse a Queue.");
            Console.WriteLine("Creating and filling the Queue...");

            // create and fill Queue with randome integers
            Queue<int> newQueue = new Queue<int>();
            Random r = new Random();
            for (int i = 0; i <= 20; i++)
            {
                // generates a random number from 1 to 100, inclusive
                newQueue.Enqueue(r.Next(0, 100) + 1);
            }

            Console.WriteLine("Queue created: ");
            foreach(int i in newQueue)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("Reversing Queue.");
            Utility.ReverseQueue(newQueue);

            Console.WriteLine("Queue reversed: ");
            foreach(int i in newQueue)
            {
                Console.Write(i + " ");
            }
        }
    }

    public static class Utility
    {
        public static void ReverseQueue(Queue<int> q)
        {
            // temporary stack used to reverse the queue
            Stack<int> st = new Stack<int>();

            // Dequeue's each element from the queue and
            // pushes it onto the stack
            while (q.Count != 0)
            {
                st.Push(q.Dequeue());
            }

            // Pop's each element from the stack and
            // enqueue;s into the queue
            while(st.Count != 0)
            {
                q.Enqueue(st.Pop());
            }
        }
    }
}
