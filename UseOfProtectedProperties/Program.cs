using System;

namespace UseOfProtectedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formula 1 vehicles are known for its high speed: ");
            Console.WriteLine();
            Formula formula1 = new Formula(2.6,"McLaren", "M23", 241.4, 1.609344);
            
            formula1.ReadSpeed();
            Console.WriteLine();
        }
    }
}
