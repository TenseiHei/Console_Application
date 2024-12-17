using System.Collections.Generic;

namespace Console_Application
{
    public static class CardUtilization
    {
        private static readonly List<string> FaceOrder = new List<string>()
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"
        };

        public static int GetCardValue(string face) => FaceOrder.IndexOf(face);

        private static readonly string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        private static readonly string[] faces = FaceOrder.ToArray();

        public static string[] Suits => suits;
        public static string[] Faces => faces;
    }
}
