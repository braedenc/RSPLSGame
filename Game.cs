using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSgame
{
    class Game
    {
        public string playerOneInput;
        public string CPUInput;
        public string playerTwoInput;
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public int CPUScore = 0;
        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! Would you like to play 1 player or 2 player? Enter '1 player' or '2 player'");
            string gameMode = Console.ReadLine();
            switch (gameMode)
            {
                case "1 player":
                    CPU soloPlay = new CPU();
                    soloPlay.Computer();
                    break;

                case "2 player":
                    TwoPlayer headToHead = new TwoPlayer();
                    headToHead.HeadToHead();
                    break;

                default:
                    Console.WriteLine("Invalid entry");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
