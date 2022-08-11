using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {


            // First lets create new dictionary
            // Keys must be unique

            Console.WriteLine("Create a new dictionary: ");

            Dictionary<string, string> fighters = new Dictionary<string, string>();


            // Now we will add some elements to the dictionary

            Console.WriteLine("Add fighters with countries they represent into the dictionary: ");

            fighters.Add("Ireland", "Conor McGregor");
            fighters.Add("Usa", "Jon Jones");
            fighters.Add("Russia", "Khabib Nurmagomedov");
            fighters.Add("Poland", "Jan Blachowicz");
            fighters.Add("New Zeland", "Alexander Volkanovski");
            fighters.Add("Sweden", "Khamzat Chimaev");
            fighters.Add("France", "Cyril Gane");
            fighters.Add("Brasil", "Charles Oliviera");
            fighters.Add("Canada", "GSP");

            // Lets see how many elements are in our dictionary

            Console.WriteLine("There are {0} professional fighters in our dictionary: ", fighters.Count);
            Console.WriteLine();

            //Next we will print all elements 

            Console.WriteLine("Print elements of the dictionary: ");
            Console.WriteLine();

            foreach (KeyValuePair<string, string> keyValue in fighters)
            {
                Console.WriteLine("{0} with its representative {1}: ", keyValue.Key, keyValue.Value);
            }

            // Lets remove fighters from Ireland 

            Console.WriteLine("Deleting fighters from Ireland.");
          
                if (fighters.ContainsKey("Ireland"))
                {
                    fighters.Remove("Ireland");
                }

            Console.WriteLine();
            

            //Now to see if deletion worked properly

            Console.WriteLine("Dictionary after deleting fighters from Ireland :");
            Console.WriteLine("Now we are left with {0} fighters: ", fighters.Count);
            Console.WriteLine();

            foreach (KeyValuePair<string, string> keyValue in fighters)
            {
                Console.WriteLine("{0} with its representative {1}: ", keyValue.Key, keyValue.Value);
            }

            // Lets try to update a value of some element in the dictionary

            Console.WriteLine("Updating element in the dictionary: ");
            Console.WriteLine();
            fighters["Poland"] = "Matius Gamrot";
            fighters["Brasil"] = " Jose Aldo";

            Console.WriteLine("After updating dictionary: ");
            Console.WriteLine();

            foreach (KeyValuePair<string, string> keyValue in fighters)
            {
                Console.WriteLine("{0} with its representative {1}: ", keyValue.Key, keyValue.Value);
            }

            Console.WriteLine("Update was successfully done ");
            Console.WriteLine();

            // Finally, lets clear the dictionary

            Console.WriteLine("Clearing the dictionary: ");
            fighters.Clear();

            if (fighters.Count == 0)
            {
                Console.WriteLine("Dictionary was successfully cleared");
            }
            else {
                foreach (KeyValuePair<string, string> keyValue in fighters)
                {
                    Console.WriteLine("{0} with its representative {1}: ", keyValue.Key, keyValue.Value);
                }
            }







        }
    }
}
