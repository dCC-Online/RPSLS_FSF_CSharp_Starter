using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player PlayerOne;
        public Player PlayerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
        }

        public int ChooseNumberOfPlayers()
        {
            return 0;
        }

        public void CreatePlayerObjects(int numberOfPlayers)
        {

        }

        public void CompareGestures()
        {

        }

        public void DisplayWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
