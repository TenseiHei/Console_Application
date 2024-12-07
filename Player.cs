using System;
using System.Collections.Generic;

namespace Console_Application
{
    public class Player
    {
        public string Name { get; set; }             // The player's name
        public List<Card> Hand { get; set; }         // The player's hand stores multiple cards.
        public int Score { get; set; }              // Score property.
        public string Declaration { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();    // We initialize the hand as an empty list.
            Score = 0;
        }

        public void AddCardToHand(Card card)
        {
             Hand.Add(card);   // Add the card to the player's hand.
        }

        public void ShowHand()
        {
            Console.WriteLine($"\n{Name}'s hand: {string.Join(", ", Hand)}");
        }

        public void ResetHand()
        {
            Hand.Clear();
        }
    }
}