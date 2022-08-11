using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // First we create an empty queue

            Console.WriteLine("Create a new queue.");

            Queue<int> queue = new Queue<int>();


            Console.WriteLine("Add elements to the queue ");

            // Next we will add elements in the queue with Enqueue() method

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine("Print elements of the queue: ");

            // Print elements

            foreach (int el in queue)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine("Add more elements to the queue: ");

            // Lets add more elements into queue by creating an array

            int[] array = { 11, 22, 33, 44, 55, 66, 77, 88, 99, };

            Console.WriteLine("Add elements from the array to the queue: ");

            //Add elements of an array into queue

            foreach (int el in array)
            {
                queue.Enqueue(el);
            }

            Console.WriteLine("Queue members: ");

            foreach (int el in queue)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();

            Console.WriteLine("Deleting members of the queue. ");

            // Dequeue() method for deleting elements in the queue

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("Queue members after dequeue method:");

            foreach (int el in queue)

            {
                Console.WriteLine(el);
            }

            // Let's test Peek() method and see what it will return?

            Console.WriteLine("Peeking at the first element of the queue: {0} ", queue.Peek());

            Console.WriteLine("Queue after Peeking: ");


            foreach (int el in queue)

            {
                Console.WriteLine(el);
            }

            // Same elements in the queue after Peek() -> Peek() returns top elements without deleting it

            //Next we will check if there is some element with user input in queue

            int user_input;

            Console.WriteLine("Type the element you want to check if it is available in the queue");

            user_input = int.Parse(Console.ReadLine());

            if (queue.Contains(user_input))
            {
                Console.WriteLine("Queue contains the number {0} : ", user_input);
            }
            else
            {
                Console.WriteLine("No element in the queue... try again");
                user_input = int.Parse(Console.ReadLine());
            }

            //Let's clear the queue

            Console.WriteLine("Queue before clear method..");

            queue.Clear();

            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.. ");

            }
            else
            {
                foreach (int el in queue)

                {
                    Console.WriteLine(el);
                }

            }
            
            













        }
    }
}
