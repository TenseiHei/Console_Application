using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_Application
{
    public class CardGame
    {
        private readonly Deck deck;
        private readonly List<Player> players;
        private List<string> roundHistory;
        private const int WinningScore = 4;     // Number of rounds needed to win the game.
        private int roundCounter;               // Tracks the current round number.
        public CardGame()
        {
            deck = new Deck ();
            players = new List<Player> ();
            roundHistory = new List<string> ();
            roundCounter = 0;   // Initialize the round counter.
        }

        public void StartGame()
        {
            // Title of the game.
            Console.WriteLine("Welcome to High Card!\n");

            // Explain the rules.
            Console.WriteLine("Rules:");
            Console.WriteLine("- Declare 'highest' and draw the highest card in the round if not you lose.");
            Console.WriteLine("- Declare 'lowest' and draw the lowest card in the round if not you lose.");
            Console.WriteLine("- Declare 'middle' and draw a card that falls between the highest and the lowest cards, If not you lose.");

            // Initialize the game.
            InitializeGame();

            // Continuous rounds until someone wins.
            while (true)
            {
                // Shows the playes info.
                DisplayPlayerStatus();

                // Play a round.
                PlayRound();

                // Check declarations.
                EvaluateDeclarations();

                var winners = players.Where(player => player.Score >= WinningScore).ToList();
                if (winners.Count > 0)
                {
                    AnnounceWinners(winners);

                    // Ask to start another game.
                    if (AskToPlayAgain())
                    {
                        InitializeGame();
                    }
                    else
                    {
                        ShowRoundHistory();
                        Console.WriteLine("\nHope you had fun. Sayonara!\n");
                        Console.WriteLine("Press Enter to exit the program.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }

        private void InitializeGame()
        {
            deck.InitializeDeck();  // Reset the deck.
            deck.Shuffle();         // Shuffle the new deck.
            players.Clear();        // Clears all the players.
            roundHistory.Clear();   // Clears the game history.
            roundCounter = 0;       // Reset the round counter.

            int playerCount = GetPlayerCount();
            players.AddRange(CollectPlayerNames(playerCount));

            foreach (var player in players)
            {
                player.ResetHand(); // Resets each player's hand.
                player.Score = 0;   // Reset scores for all players.
            }
                
            Console.WriteLine("\nThe deck has been shuffled. Let's start the game!\n");
        }

        private void DisplayPlayerStatus()
        {
            Console.WriteLine("\nPlayers: ");
            foreach (var player in players)    // Displaying the names of all the players.
                Console.WriteLine($"- {player.Name} (Score: {player.Score}");
        }

        private void PlayRound()
        {
            roundCounter++; // We increment the round counter at the start of the round.
            Console.WriteLine($"\nRound {roundCounter}: Drawing cards...");

            foreach (var player in players)
            {
                Console.WriteLine($"\n{player.Name}, press Enter to draw your card...");
                Console.ReadLine();

                var drawnCard = deck.Draw();
                player.AddCardToHand(drawnCard); // Using player names.
                Console.WriteLine($"{player.Name} drew {drawnCard}\n");

                player.Declaration = GetPlayerDeclaration(player.Name);
            }

            foreach (var player in players)
            {
                player.ShowHand(); // Displays player's hand.
            }
        }

        private int GetPlayerCount()
        {
            while (true)
            {
                Console.WriteLine("\nWhat are the number of players for this game (minimum 2):\n");
                if (int.TryParse(Console.ReadLine(), out int playerCount) && playerCount > 1)
                    return playerCount;

                Console.WriteLine("\nInvalid input. Please enter a number greater than 1.\n");
            }
        }

        private List<Player> CollectPlayerNames(int playerCount)
        {
            var players = new List<Player>();

            for (int i = 1; i <= playerCount; i++)
            {
                while (true)    // The loop ensures valid name inputs.
                {
                    Console.WriteLine($"\nEnter the name for player {i}: ");
                    string playerName = Console.ReadLine()?.Trim();  // Trim removes unnecessary whitespaces around the input.

                    // The validation ensures that the name is not empty, contains only letters and are not identical.
                    if (!string.IsNullOrEmpty(playerName) && playerName.All(char.IsLetter) && !players.Exists(p => string.Equals(p.Name, playerName, StringComparison.OrdinalIgnoreCase)))   // Case-insensitive check.
                    {
                        players.Add(new Player(playerName));
                        break;  // Valid input, we'll then exit the loop.
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input or duplicate name. Plaese try again.\n");
                    }
                }
            }
            return players;
        }

        private string GetPlayerDeclaration(string playerName)
        {
            while (true)
            {
                Console.WriteLine($"{playerName}, declare the state of your card: 'lowest', 'middle', or 'highest':");
                string declaration = Console.ReadLine()?.Trim();  // Trim removes unnecessary whitespaces around the input.

                if (declaration == "lowest" || declaration == "middle" || declaration == "highest")
                    return declaration;

                Console.WriteLine("Invalid declaration. Please enter one of: 'lowest', 'middle', or 'highest'.");
            }
        }

        private void EvaluateDeclarations()
        {
            Console.WriteLine("\nEvaluating declarations...");

            // Get the highest and lowest cards across all players.
            int highestValue = players.SelectMany(p => p.Hand).Max(card => CardUtilization.GetCardValue(card.Face));
            int lowestValue = players.SelectMany(p => p.Hand).Min(card => CardUtilization.GetCardValue(card.Face));

            foreach (var player in players)
            {
                bool result = false;
                string reason = string.Empty;
                string roundResult = $"Round {roundCounter}: {player.Name}'s Declaration: {player.Declaration}";

                // Evaluate the player's declaration.
                switch (player.Declaration)
                {
                    case "highest":
                        result = player.Hand.Any(card => CardUtilization.GetCardValue(card.Face) == highestValue);
                        reason = result ? $"{player.Name} correctly declared 'highest'!" : $"{player.Name} declared 'highest' incorrectly.";
                        break;

                    case "lowest":
                        result = player.Hand.Any(card => CardUtilization.GetCardValue(card.Face) == lowestValue);
                        reason = result ? $"{player.Name} correctly declared 'lowest'!" : $"{player.Name} declared 'lowest' incorrectly.";
                        break;

                    case "middle":
                        result = highestValue != lowestValue && player.Hand.Any(card => CardUtilization.GetCardValue(card.Face) > lowestValue && CardUtilization.GetCardValue(card.Face) < highestValue);
                        reason = result ? $"{player.Name} correctly declared 'middle'!" : $"{player.Name} declared 'middle' incorrectly.";
                        break;
                }

                Console.WriteLine(reason);

                // Handles result.
                if (result)
                {
                    player.Score++;
                    roundHistory.Add($"Round {roundCounter}: {player.Name} declared '{player.Declaration}' correctly.");
                }
                else
                {
                    roundHistory.Add($"Round {roundCounter}: {player.Name} declared '{player.Declaration}' incorrectly.");
                }

                player.ResetHand();
            }

            foreach (var player in players)
            {
                player.ResetHand(); // Reset the losers hand after evaluation.
            }
        }

        public void ShowRoundHistory()
        {
            Console.WriteLine("\nRound History");

            if (!roundHistory.Any())
            {
                Console.WriteLine("No rounds played yet.");
                return;
            }

            foreach (var entry in roundHistory)
            {
                Console.WriteLine(entry);
            }
        }

        private static void AnnounceWinners(List<Player> winners)
        {
            if (winners.Count == 1)
                Console.WriteLine($"\n{winners[0].Name} wins the game with {WinningScore} points! Omedeto!");
            else
                Console.WriteLine("\nWe have a tie! Winners:\n" + string.Join("\n", winners.Select(w => $"{w.Name} with {w.Score} points")));
        }

        private static bool AskToPlayAgain()
        {
            while (true)
            {
                Console.Write("\nDo you want to start a new game? (yes/no): ");
                string response = Console.ReadLine()?.Trim().ToLower();     // To ensure the input matches.

                if (response == "yes")
                    return true;

                if (response == "no")
                    return false; // Exit the program.

                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
        }
    }
}
