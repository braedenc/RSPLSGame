using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class TwoPlayer: Game
    {
        public void HeadToHead()
        {
            Game myGame = new Game();
            GetPlayerOneInput();
            Console.WriteLine("Player 2, choose between 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
            playerTwoInput = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write("*");
                playerTwoInput += key.KeyChar;
            }
            switch (playerTwoInput)
            {
                case "rock":
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Both players chose rock, It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Player 1 chose paper and Player 2 chose rock, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player 1 chose scissors and Player 2 chose rock, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player 1 chose lizard and Player 2 chose rock, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player 1 chose spock and Player 2 chose rock, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    break;

                case "paper":
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player 1 chose rock and Player 2 chose paper, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Both players chose paper, It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player 1 chose scissors and Player 2 chose paper, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player 1 chose lizard and Player 2 chose paper, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player 1 chose spock and Player 2 chose paper, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    break;

                case "scissors":
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player 1 chose rock and Player 2 chose scissors, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Player 1 chose paper and Player 2 chose scissors, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Both players chose scissors, It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player 1 chose lizard and Player 2 chose scissors, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player 1 chose spock and Player 2 chose scissors, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    break;

                case "lizard":
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player 1 chose rock and Player 2 chose lizard, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Player 1 chose paper and Player 2 chose lizard, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player 1 chose scissors and Player 2 chose lizard, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Both players chose lizard, It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player 1 chose spock and Player 2 chose lizard, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    break;

                case "spock":
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player 1 chose rock and Player 2 chose spock, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Player 1 chose paper and Player 2 chose spock, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player 1 chose scissors and Player 2 chose spock, Player 2 wins!");
                        Console.ReadLine();
                        playerTwoScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player 1 chose lizard and Player 2 chose spock, Player 1 wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Both players chose spock, It's a draw!");
                        Console.ReadLine();
                    }
                    break;

                default:

                    break;
            }
            Score();
        }
        private void GetPlayerOneInput()
        {
            Console.WriteLine("Player 1 choose between 'rock', 'paper', 'scissors', 'lizard', or 'spock'. Enter your choice below");
            playerOneInput = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                Console.Write("*");
                playerOneInput += key.KeyChar;
            }

        }
        private void Score()
        {
            if (playerOneScore == 2)
            {
                Console.WriteLine("Player 1 wins the match!");
                Console.WriteLine("Would you like to play again? 'yes' or 'no'");
                string matchOver = Console.ReadLine();
                if (matchOver == "yes")
                {
                    StartGame();
                }
                else if (matchOver == "no")
                {
                    Console.WriteLine();
                }
            }
            else if (playerTwoScore == 2)
            {
                Console.WriteLine("Player 2 wins the match!");
                Console.WriteLine("Would you like to play again? 'yes' or 'no'");
                string matchOver = Console.ReadLine();
                if (matchOver == "yes")
                {
                    StartGame();
                }
                else if (matchOver == "no")
                {
                    Console.WriteLine();
                }
            }else
            {
                HeadToHead();
            }
        }
    }
}
