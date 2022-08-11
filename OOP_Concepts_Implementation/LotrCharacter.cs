using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Concepts_Implementation
{
     abstract class LotrCharacter
    {
        // Protected access modifiers for inheritance

        protected string characterName;
        protected string characterRace;
      
        // Constructor for encapsulation and abstraction ?

        public LotrCharacter(string characterName, string characterRace)
        {
            this.characterName = characterName;
            this.characterRace = characterRace;
          
        }

        // Overriding for polymorphysm

        protected abstract string UseWeapon();
        protected abstract string UseQuote();
        public abstract void PresentYourSelf();
    }
}
