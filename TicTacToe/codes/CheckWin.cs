using System;

namespace TicTacToe
{
    class GameStatus
    {
        public bool Status(string[] numb)
        {
            bool row1 = numb[0] == numb[1] && numb[1] == numb[2];
            bool row2 = numb[3] == numb[4] && numb[4] == numb[5];
            bool row3 = numb[6] == numb[7] && numb[7] == numb[8];
            bool col1 = numb[0] == numb[3] && numb[3] == numb[6];
            bool col2 = numb[1] == numb[4] && numb[4] == numb[7];
            bool col3 = numb[2] == numb[5] && numb[5] == numb[8];
            bool diagDown = numb[0] == numb[4] && numb[4] == numb[8];
            bool diagUp = numb[6] == numb[4] && numb[4] == numb[2];

            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }
    }
}