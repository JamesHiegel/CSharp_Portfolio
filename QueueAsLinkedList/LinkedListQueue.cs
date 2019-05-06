﻿// SOURCE: https://www.geeksforgeeks.org/queue-set-2-linked-list-implementation/
// AUTHORS: Gaurav Kumar, Bhupendra Rathore

// FILENAME: LinkedListQueue.cs
// PURPOSE: Implement a queue utilizing a linked list data structure.
// STUDENT: James Hiegel

// STYLE MODIFICATIONS: 

// FUNCTIONAL MODIFICATIONS:

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

namespace QueueAsLinkedList
{
    class LinkedListQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}