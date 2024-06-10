using System;

namespace TicTacToe
{
    class RunGame
    { 
        static void Main (string[] args)
        {
            string[] numbs = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            GameFlow gf = new GameFlow();
            gf.Execution(numbs);
        }
    }
}