using System;
using System.Collections.Generic;

namespace Console_Application
{
    public class Player
    {
        private string name;                // The player's name
        private List<Card> hand;            // The player's hand stores multiple cards.
        private int score;                  // Score property.
        private string declaration;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Card> Hand
        {
            get => hand;
            set => hand = value;
        }

        public int Score
        {
            get => score;
            set => score = value;
        }

        public string Declaration
        {
            get => declaration;
            set => declaration = value;
        }

        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();    // We initialize the hand as an empty list.
            score = 0;
        }

        public void AddCardToHand(Card card)
        {
             hand.Add(card);   // Add the card to the player's hand.
        }

        public void ShowHand()
        {
            Console.WriteLine($"\n{Name}'s hand: {string.Join(", ", Hand)}");
        }

        public void ResetHand()
        {
            hand.Clear();
        }
    }
}