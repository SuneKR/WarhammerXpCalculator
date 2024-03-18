using Microsoft.AspNetCore.Components;
using WarhammerXpCalculator.Models;

namespace WarhammerXpCalculator.Components.Pages
{
    public partial class CharacterSheet : ComponentBase
    {
        [Parameter]
        public Character? Character { get; set; }

        protected override void OnInitialized()
        {
            Character = GetCharacter();
        }

        private Character GetCharacter()
        {




            return new Character("Test", "Human", "Burger", "Rat Catcher", "Sewer Jack", "average", 21, "1,67 m", "Brown", "Brown", "Mummit the Fool", "Catching rats", "Catching a rat bigger than my brother", "Switch that rat with my brother and make him live in the sewers of Bögenhafen", 3, 3, 4);

            /*
            *
            * public Character("Test", "Human", "Burgers", "Rat Catcher",  "SewerJack", "average", 21, "1,67 m", "Brown", "Brown", "Mummit the Fool", GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), GetCharacteristics(), "Catching some rat", "Catching bigger than my brother", "Convincing my parents, that the rat bigger than brother is actually my brother, and make my brother live in the sewers of Bogenhafen", 3, 3, 4)
            * public Character(string name, string species, string @class, string career, string careerTier, string size, int age, string height, string hair, string eyes, string starSign, Characteristic wS, Characteristic bS, Characteristic s, Characteristic t, Characteristic i, Characteristic ag, Characteristic dex, Characteristic @int, Characteristic wP, Characteristic fel, string motivation, string shortTermAmbition, string longTermAmbition, int fate, int resilience, int move)
        */
        }
    }
}
