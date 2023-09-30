using System;

namespace TicTacToe
{
    public enum GameType
    {
        ONE_PLAYER,
        ONE_PLAYER_IMPOSSIBLE,
        TWO_PLAYER
    }

    public enum Letter
    {
        NONE,
        X,
        O
    }

    public class GridSpace
    {
        Tuple<int, int> tuple; // Row, col
        public Letter value { get; private set; }


        public GridSpace(int row, int col)
        {
            tuple = Tuple.Create(row, col);
            value = Letter.NONE;
        }
    }
}