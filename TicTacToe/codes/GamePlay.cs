using System;

namespace TicTacToe
{
    class GameFlow
    {
        public void Execution(string[] number)
        {
            Place place = new Place();
            bool playerTurn = false;
            Flow(number, playerTurn);
            Console.WriteLine();
            place.Board(number);
            Congratulate(playerTurn);
        }

        public void Flow(string[] numb, bool isPlayer1)
        {
            Random random = new Random();
            Place place = new Place();
            GameStatus gs = new GameStatus();

            while (!gs.Status(numb))
            {
                place.Board(numb);

                if (!isPlayer1)
                {
                    Console.WriteLine("Your turn!");
                    string ply1 = Console.ReadLine();
                    Console.WriteLine();

                    if (numb.Contains(ply1) && ply1 != "X" && ply1 != "O")
                    {
                        int markPly1 = Convert.ToInt32(ply1);
                        numb[markPly1 - 1] = "X";
                        isPlayer1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Please insert the number available in the game!");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Opponent turn!");
                    string ply2 = Console.ReadLine();
                    //string ply2 = Convert.ToString(random.Next(1, 9));
                    Console.WriteLine();

                    if (numb.Contains(ply2) && ply2 != "X" && ply2 != "O")
                    {
                        int markPly2 = Convert.ToInt32(ply2);
                        numb[markPly2 - 1] = "O";
                        isPlayer1 = false;
                    }
                    else
                    {
                        Console.WriteLine("Please insert the number available in the game!");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void Congratulate(bool isPlayer1)
        {
            if (isPlayer1 == true)
            {
                Console.WriteLine("Congrats, player 1 win!");
            }
            else
            {
                Console.WriteLine("Congrats, player 2 win!");
            }
        }


    }
}