using System.Collections.Generic;

namespace Console_Application
{
    public class Card
    {
        // This represents the face and suit of the card
        public string Face { get; }
        public string Suit { get; }

        // This is a constructor to initialize the card with face and suit
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        // Method to display the card as a string
        public override string ToString() => $"{Face} of {Suit}";
    }
}