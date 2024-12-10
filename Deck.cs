using System;
using System.Collections.Generic;

namespace Console_Application
{
    public class Deck
    {
        private List<Card> cards;                                           // List that stores the cards in the deck.
        private readonly Random random;                                     // Random for shuffling.

        public int Count => cards.Count;    // Get the current count of cards in the deck.

        public Deck()
        {
            random = new Random();
            InitializeDeck();
        }

        // Initialize the deck with 52 standard playing cards.
        public void InitializeDeck()
        {
            cards = new List<Card>();

            foreach (var suit in CardUtilization.Suits)
            {
                foreach (var face in CardUtilization.Faces)
                {
                    cards.Add(new Card(face, suit));
                }
            }
        }

        // Shuffle the deck using the Fisher-Yates shuffle algorithm.
        public void Shuffle()
        {
            for (int i = cards.Count - 1;  i > 0; i--)
            {
                int j = random.Next(i + 1);

                // We'll swap cards[i] and [j].
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        // Draw a card from the top of the deck.
        public Card Draw()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No cards left in the deck");
            }

            Card card = cards[cards.Count - 1];      // Get the top card.
            cards.RemoveAt(cards.Count - 1);        // Remove the card from the deck.
            return card;                            // Return the card to the caller.
        }
    }
}