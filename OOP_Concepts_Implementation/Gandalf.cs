using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts_Implementation
{
    class Gandalf : LotrCharacter
    {
        public string Title { get; set; }

        public Gandalf(string characterName, string title, string characterRace)
            : base(characterName, characterRace)
        {
            this.Title = title;
        }

        protected override string UseWeapon()
        {
            return "My first choice of weapon is always a staff!";
        }

        protected override string UseQuote()
        {
            return "You shall not pass!";
        }

        public override void PresentYourSelf()
        {
            Console.WriteLine("Character name: " + characterName + "\n" +
                              "Character role: " + Title + "\n" +
                              "Character race: " + characterRace + "\n" +
                              "Character weapon:" + UseWeapon() + "\n" +
                              "Character quote: " + UseQuote()
                              );
        }
    }
}
