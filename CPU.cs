using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{

    class CPU: Game
    {
        public void Computer()
        {
            Game myGame = new Game();
            GetPlayerOneInput();    
            int randomPick;
            Random rnd = new Random();
            randomPick = rnd.Next(1,6);
            switch (randomPick)
            {
                case 1:
                    CPUInput = "rock";
                    Console.WriteLine("Computer chose rock!");
                    if(playerOneInput == "rock")
                    {
                        Console.WriteLine("It's a draw!");
                        Console.ReadLine();
                    } else if(playerOneInput == "paper")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    } else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    } else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    } else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    break;

                case 2:
                    CPUInput = "paper";
                    Console.WriteLine("Computer chose paper!");
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    break;

                case 3:
                    CPUInput = "scissors";
                    Console.WriteLine("Computer chose scissors!");
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    break;

                case 4:
                    CPUInput = "lizard";
                    Console.WriteLine("Computer chose lizard!");
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("It's a draw!");
                        Console.ReadLine();
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    break;

                case 5:
                    CPUInput = "spock";
                    Console.WriteLine("Computer chose spock!");
                    if (playerOneInput == "rock")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "paper")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "scissors")
                    {
                        Console.WriteLine("Computer wins!");
                        Console.ReadLine();
                        CPUScore++;
                    }
                    else if (playerOneInput == "lizard")
                    {
                        Console.WriteLine("Player wins!");
                        Console.ReadLine();
                        playerOneScore++;
                    }
                    else if (playerOneInput == "spock")
                    {
                        Console.WriteLine("It's a draw!");
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
            Console.WriteLine("Choose between 'rock', 'paper', 'scissors', 'lizard', or 'spock'. Enter your choice below");
            playerOneInput = Console.ReadLine();
        }
        private void Score()
        {
            if(playerOneScore == 2)
            {
                Console.WriteLine("Player 1 wins the match!");
                Console.WriteLine("Would you like to play again? 'yes' or 'no'");
                string matchOver = Console.ReadLine();
                if(matchOver == "yes")
                {
                    StartGame();
                }else if(matchOver == "no")
                {
                    Console.WriteLine();
                }
            } else if(CPUScore == 2)
            {
                Console.WriteLine("Computer wins the match!");
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
                Computer();
            }
        }
    }
}
