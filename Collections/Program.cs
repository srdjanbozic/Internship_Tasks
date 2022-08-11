using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //First we need to create a new stack

            Console.WriteLine("Creating a new stack. ");
           

            Stack<int> newStack = new Stack<int>();

            //Next we'll add some elements in stack using Push() method

            Console.WriteLine("Adding elements to the stack. ");
            
            newStack.Push(10);
            newStack.Push(1);
            newStack.Push(5);
            newStack.Push(23);
            newStack.Push(9);

            // Now lets print elements of the stack

            Console.WriteLine("Printing elements of the stack: ");

            foreach (int el in newStack)
            {
                Console.WriteLine(el);
            }

            // Next we should test Pop() method

            Console.WriteLine("Popping the first elements of the stack.. ");
            newStack.Pop();
            newStack.Pop();

            //Print out elements to see what happend

            foreach (int el in newStack)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("Popping the first element of the stack: {0} ", newStack.Pop());

            //Now letss test Peek() method 

            Console.WriteLine("Peek at the next element: {0} ", newStack.Peek());

            // We should add more elements in to the stack by creating an array and filling the stack with elements of the array


            int[] array = { 2, 3, 43, 54, 65, 342, 65, 786, 32, 55 };

            // Print elements of the array

            Console.WriteLine("Array elements: ");
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }

            // Add elements of the array into the stack

            Console.WriteLine("Add elements of the array to the stack: ");

            foreach (int el in array)
            {
                newStack.Push(el);
            }

            // Print elements of the stack

            Console.WriteLine("Stack elements: ");
            foreach (int el in newStack)
            {
                Console.WriteLine(el);
            }

            // Containts method

            Console.WriteLine("Checking if the stack contains number 43: {0}  ", newStack.Contains(43));

            // Now lets count elements of the stack

            Console.WriteLine("The total number of elements in the stack is: {0} ", newStack.Count);


            // Lets create a second stack using the constructor that accepts an IEnumerable of T

            Stack<int> stack2 = new Stack<int>(newStack);

            Console.WriteLine("\n Elements of the second stack: ");

            foreach (int el in stack2)
            {
                Console.WriteLine(el);
            }

            //Finally, lets clear stack
            Console.WriteLine();
            Console.WriteLine("Clearing the stack.");
            

            stack2.Clear();

            //Check if count = 0

            if (stack2.Count == 0)
            {
                Console.WriteLine("It's empty now: ");
            }
            else
                foreach (int el in stack2)
                {
                    Console.Write(el + " ");
                }


        }
    }
}
