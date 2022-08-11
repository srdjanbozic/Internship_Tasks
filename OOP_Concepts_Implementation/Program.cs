using System;

namespace OOP_Concepts_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presenting the first LOTR character: ");
            LotrCharacter aragorn = new Aragorn("Aragorn", "Future King", "Human");
           
            aragorn.PresentYourSelf();
            Console.WriteLine();

            Console.WriteLine("Presenting the second LOTR character: ");
            LotrCharacter legolas = new Legolas("Legolas", "Gimli","Elf");
            legolas.PresentYourSelf();
            Console.WriteLine();

            Console.WriteLine("Presenting the third LOTR character: ");
            LotrCharacter gandalf = new Gandalf("Gandalf","The Grey", "Wizard");
            gandalf.PresentYourSelf();
            Console.WriteLine();
        }
    }
}
