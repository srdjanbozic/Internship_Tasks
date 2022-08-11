using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // First, we create a new list

            Console.WriteLine("Create a list with 10 elements ");
            Console.WriteLine();

            List<int> list = new List<int>() { 4, 8, 3, 2, 5, 6, 27, 8, 19, 140 };

            // Lets print elements in the list

            Console.WriteLine("List contains following elements: ");
            Console.WriteLine();

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();

            // Next, lets sort elements in the list

            Console.WriteLine("Sorted list: ");
            Console.WriteLine();
            list.Sort();

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();

            // Lets reverse elements

            Console.WriteLine("Reversed elements: ");
            Console.WriteLine();

            list.Reverse();

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }

            // Next we will create an array and add it to the list

            int[] array = new int[5] { 23, 43, 54, 65, 75 };

            Console.WriteLine("Add element of the array in to the list: ");
            Console.WriteLine();

            list.AddRange(array);

            Console.WriteLine();

            // Lets print elements of the newly created list

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }

            // Accessing an element with index

            Console.WriteLine("Element on [4] position is: {0} ", list[4]);
            Console.WriteLine("Element on [0] position is: {0} ", list[0]);

            // Remove element from index and range

            list.Remove(2);
            list.RemoveRange(5, 2);

            Console.WriteLine("Print elements after removing elements from specified positions : ");
            Console.WriteLine();

            foreach (int el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("Clear list:");

            list.Clear();

            if(list.Count == 0)
            {
                Console.WriteLine("You successfully deleted all elements from the list!");
            }





        }
    }
}
