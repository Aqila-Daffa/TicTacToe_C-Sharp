using System;

namespace TicTacToe
{
    class Place
    {

        public void Board (string[] numbers)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write (numbers[i * 3 + j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine("------");
            }
        }
    }
}