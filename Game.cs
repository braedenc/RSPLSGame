using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class Game
    {
        string playerInput;
        public string StartGame()
        {
            Console.WriteLine("Choose between 'rock', 'paper', 'scissors', 'lizard', or 'spock'");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "rock":
                    playerInput == "rock";
                    return playerInput;
                    break;

                case "paper":

                    break;

                case "scissors":

                    break;

                case "lizard":

                    break;

                case "spock":

                    break;

                default:

                    break;
            }
        }
    }
}
