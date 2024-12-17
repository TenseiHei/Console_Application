using System.Collections.Generic;

namespace Console_Application
{
    public class Card
    {
        // This represents the face and suit of the card
        private string face { get; }
        private string suit { get; }

        public string Face => face;
        public string Suit => suit;

        // This is a constructor to initialize the card with face and suit
        public Card(string face, string suit)
        {
            this.face = face;
            this.suit = suit;
        }

        // Method to display the card as a string
        public override string ToString() => $"{Face} of {Suit}";
    }
}