using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts_Implementation
{
    class Aragorn : LotrCharacter
    {
        public string Role { get; set; }

        public Aragorn(string characterName,string role, string characterRace)
            : base(characterName,characterRace)
        {
            this.Role = role;
        }

        protected override string UseWeapon()
        {
            return "My first choice of weapon is always a sword!";
        }

        protected override string UseQuote()
        {
           return "I do not fear death!";
        }

        public override void PresentYourSelf()
        {
            Console.WriteLine("Character name: "  + characterName + "\n" +
                              "Character role: "  + Role + "\n" +
                              "Character race: "  + characterRace + "\n" +
                              "Character weapon:" + UseWeapon() + "\n" +
                              "Character quote: " + UseQuote()
                              );
        }
    }
}
