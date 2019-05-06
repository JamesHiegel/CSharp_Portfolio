// SOURCE: https://www.geeksforgeeks.org/queue-set-2-linked-list-implementation/
// AUTHORS: Rajput-Ji, Gaurav Kumar, Bhupendra Rathore

// FILENAME: LinkedListQueue.cs
// PURPOSE: Implement a queue utilizing a linked list data structure.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 
// Added comments throughout program describing what is occuring in each method and code block

// FUNCTIONAL MODIFICATIONS:
// Adjusted Enqueue and Dequeue methods to utilize if-else statement and removed extraneous return statement. 
// Added a custom ToString method to show what the queue looks like during demonstration

// A Queue is a linear structure which follows a particular order in which the 
// operations are performed.The order is First In First Out(FIFO).  A good example 
// of queue is any queue of consumers for a resource where the consumer that came 
// first is served first.

// Queue is used when things don’t have to be processed immediatly, but have to be 
// processed in First InFirst Out order like Breadth First Search. This property of 
// Queue makes it also useful in following kind of scenarios.
// 1) When a resource is shared among multiple consumers.Examples include CPU 
// scheduling, Disk Scheduling.
// 2) When data is transferred asynchronously (data not necessarily received at same 
// rate as sent) between two processes. Examples include IO Buffers, pipes, file IO, etc.

using System;
using System.Text;

namespace QueueAsLinkedList
{
    public class LinkedListQueue
    {
        public static void Main(string[] args)
        {
            // creates Queue object
            Queue q = new Queue();

            // displays empty queue
            Console.WriteLine("Queue contents: {0}", q.ToString());

            Console.WriteLine("Enqueueing elements");
            q.Enqueue(10);
            q.Enqueue(20);

            // displays queue with two elements, showing enqueue worked
            Console.WriteLine("Queue contents: {0}", q.ToString());

            Console.WriteLine("Dequeueing elements");
            q.Dequeue();
            q.Dequeue();

            // displays empty queue showing dequeue worked
            Console.WriteLine("Queue contents: {0}", q.ToString());

            Console.WriteLine("Enqueueing elements");
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            // displays queue with elements in it
            Console.WriteLine("Queue contents: {0}", q.ToString());

            // displays key of queue node that has been dequeued
            Console.WriteLine("Dequeued item is " + q.Dequeue().key);
        }

        // The QNode class represents each node in the queue, it contains an integer 
        // as the key and a reference to the next QNode in the queue
        public class QNode
        {
            public int key;
            public QNode next;

            // constructor to create a new node
            public QNode(int key)
            {
                this.key = key;
                this.next = null;
            }
        }

        // The Queue class utilizes the QNode class to create a queue
        public class Queue
        {
            // references to the nodes the are at the front and rear of the queue
            QNode front, rear;

            // constructor that points both the front and rear variable to the same node and then sets it to null
            public Queue()
            {
                this.front = this.rear = null;
            }

            // The enqueue method adds a new node at the end of the queue.
            public void Enqueue(int key)
            {

                // Create a new queue node 
                QNode temp = new QNode(key);

                // If queue is empty then new node is both at the front and rear of the queue
                if (this.rear == null)
                {
                    this.front = this.rear = temp;
                }
                else
                // otherwise add new node to the end of the queue.
                {
                    this.rear.next = temp;
                    this.rear = temp;
                }
            }

            // The Dequeue method returns the front node of the queue and then removes it from the queue. 
            public QNode Dequeue()
            {
                // If queue is empty, return NULL. 
                if (this.front == null)
                    return null;

                // Store current front node
                QNode temp = this.front;

                // If the next node in the queue is null,
                // then set the front and rear to null
                if (this.front.next == null)
                {
                    this.front = this.rear = null;
                }
                else
                // Advance the front node to the next node in the queue
                {

                    this.front = this.front.next;
                }

                return temp;
            }

            // The ToString method prints out the contents of the queue to the console
            public override string ToString()
            {
                // if front node is null, then queue is empty
                if (front == null)
                {
                    return "[Empty]";
                }
                // otherwise iterate through queue and appends values to stringbuilder object
                else
                {
                    StringBuilder sb = new StringBuilder();

                    // adds open bracket and front key value
                    sb.Append("[");
                    sb.Append(front.key);

                    // saves reference to next node
                    QNode temp = front.next;

                    // loops until next node is null
                    while (temp != null)
                    {
                        // adds key values to stringbuilder oject
                        sb.Append(", ");
                        sb.Append(temp.key);

                        // advances node to the next one in the queue
                        temp = temp.next;
                    }

                    // adds close bracket and returns stringbuilder object
                    sb.Append("]");
                    return sb.ToString();
                }
            }
        }
    }
}
