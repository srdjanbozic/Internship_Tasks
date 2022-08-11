using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts_Implementation
{
    class Legolas : LotrCharacter
    {
        public string BestFriend;

        public Legolas(string characterName, string bestFriend, string characterRace)
            : base(characterName, characterRace)
        {
            this.BestFriend = bestFriend;
        }


        protected override string UseWeapon()
        {
            return "My first choice of weapon is always a bow!";
        }

        protected override string UseQuote()
        {
            return "They're taking the hobbits to Isengard!";
        }

        public override void PresentYourSelf()
        {
            Console.WriteLine("Character name: " + characterName + "\n" +
                              "Character best friend: " + BestFriend + "\n" +
                              "Character race: " + characterRace + "\n" +
                              "Character weapon:" + UseWeapon() + "\n" +
                              "Character quote: " + UseQuote()
                              );
        }

    }
}
