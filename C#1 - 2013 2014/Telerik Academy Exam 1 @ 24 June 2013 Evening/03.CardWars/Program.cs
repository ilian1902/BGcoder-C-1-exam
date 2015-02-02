using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger player1TotalScore = 0;
        BigInteger player2TotalScore = 0;
        int player1GamesWon = 0;
        int player2GamesWon = 0;
        for (int i = 0; i < n; i++)
        {
            BigInteger heandScore1 = 0;
            BigInteger heandScore2 = 0;
            bool player1HasXcard = false;
            bool player2HasXCard = false;
            //player one
            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": heandScore1 += 1; break;
                    case "K": heandScore1 += 13; break;
                    case "Q": heandScore1 += 12; break;
                    case "J": heandScore1 += 11; break;
                    case "X": player1HasXcard = true; ; break;
                    case "Y": player1TotalScore -= 200; break;
                    case "Z": player1TotalScore *= 2; break;

                    default: heandScore1 += 12 - int.Parse(card); break;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": heandScore2 += 1; break;
                    case "K": heandScore2 += 13; break;
                    case "Q": heandScore2 += 12; break;
                    case "J": heandScore2 += 11; break;
                    case "X": player2HasXCard = true; ; break;
                    case "Y": player2TotalScore -= 200; break;
                    case "Z": player2TotalScore *= 2; break;

                    default: heandScore2 += 12 - int.Parse(card); break;
                }
            }
            if (player1HasXcard&&player2HasXCard)
            {
                player1TotalScore += 50;
                player2TotalScore += 50;
            }
            else if (player1HasXcard)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (player2HasXCard)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            if (heandScore1>heandScore2)
            {
                player1TotalScore += heandScore1;
                ++player1GamesWon;
            }
            else if (heandScore1<heandScore2)
            {
                player2TotalScore += heandScore2;
                ++player2GamesWon;
            }
        }
        if (player1TotalScore==player2TotalScore)
        {
            Console.WriteLine(@"It's a tie!
Score: {0}", player2TotalScore);
        }
        else
        {
            if (player1TotalScore>player2TotalScore)
            {
                Console.WriteLine(@"First player wins!
Score: {0}
Games won: {1}", player1TotalScore, player1GamesWon);
            }
            else
            {
                Console.WriteLine(@"Second player wins!
Score: {0}
Games won: {1}", player2TotalScore, player2GamesWon);
            }
        }
    }
}
