using System;

namespace Two_Classes_One_Interface
{
    class Program
    {
        public static void PrintWingFlaps(IWings butterfly, IWings eagle)
        {
            Console.WriteLine("The butterfly approximately flaps its wings {0} times every second.  ", butterfly.WingsFlapBySecond()); 
            Console.WriteLine("The eagle approximately flaps its wings {0} times every second.  ", eagle.WingsFlapBySecond());
        }

        static void Main(string[] args)
        {
            // Butterfly butterfly = new Butterfly();
            IWings butterfly = new Butterfly();
            IWings eagle = new Eagle();
            PrintWingFlaps(butterfly, eagle);
           // Eagle eagle = new Eagle();
            //PrintWingFlaps(butterfly, eagle);
        }
    }
}
