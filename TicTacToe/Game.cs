using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The class by which the actual game runs on.
/// </summary
namespace TicTacToe
{
    public class Game
    {
        public Letter turn { get; private set; }
        public List<List<Letter>> grid { get; private set; } // A two dimensional array. First index is row, second column.
        private int gridWidth = 3;
        private int gridHeight = 3;
        private GameType gameType;
        private Tuple<int, int> mostRecent;

        /// <summary>
        /// Initialize the grid board. Go row by row.
        /// Values added are objects of type "GridSpace"; they
        /// contain a tuple, a location ("row", "col"), and a value
        /// ("X", "O", or "NONE".)
        /// </summary>
        public Game()
        {

            grid = new List<List<Letter>>();
            for (int row = 0; row < gridHeight; row++)
            {
                grid.Add(new List<Letter>());
                for (int col = 0; col < gridWidth; col++)
                {
                    grid[row].Add(Letter.NONE);
                }
            }
        }

        /// <summary>
        /// Check for a victory.
        /// </summary>
        /// <param name="turn"></param>
        /// <returns></returns>
        public bool checkForWin(Letter turn)
        {
            // Check for win in a row.
            for (int row = 0; row < gridHeight; row++)
            {
                for (int col = 0; col < gridWidth; col++)
                {
                    // If even ONE value is NOT belong to the current player,
                    // That means the whole row is not a success. Break.
                    if (grid[row][col] != turn)
                        break;
                    // If you're on the LAST ITEM and the item belongs to the
                    // current player, it means you won (you would have broken
                    // before getting to that point otherwise)
                    // Return true.
                    else if (col == gridWidth - 1)
                        return true;
                }
            }

            // Check for a win in a column.
            for (int col = 0; col < gridWidth; col++)
            {
                for (int row = 0; row < gridHeight; row++)
                {
                    // If even ONE value is NOT belong to the current player,
                    // That means the whole row is not a success. Break.
                    if (grid[row][col] != turn)
                        break;
                    // If you're on the LAST ITEM and the item belongs to the
                    // current player, it means you won (you would have broken
                    // before getting to that point otherwise)
                    // Return true.
                    else if (row == gridHeight - 1)
                        return true;
                }
            }

            // Check for a win in a diagonal (Top left to bottom right)
            for (int i = 0; i < gridHeight; i++)
            {
                if (grid[i][i] != turn)
                    break;
                else if (i == gridHeight - 1)
                    return true;
            }

            // Check or a win in a diagonal (Top right to bottom left)
            for (int i = 0; i < gridHeight; i++)
            {
                if (grid[i][gridWidth - 1 - i] != turn)
                    break;
                else if (i == gridHeight - 1)
                    return true;
            }

            return false;
        }
       
        /// <summary>
        /// Pass in a position and the Letter value, and the grid space
        /// in that position will be updated with that value.
        /// IMPORTANT: "position" value MUST be in "row, col" format.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="value"></param>
        public void makeMove(Tuple<int, int> position, Letter value)
        {
            grid[position.Item1][position.Item2] = value;
            // If human, save position as mostRecent
            if (value == Letter.O)
            {
                mostRecent = position;
            }
        }

        /// <summary>
        /// If a turn is X, go to O; else if O, go to X (so go to other player)
        ///
        /// If the game hasn't started yet, (the turn is NONE), set the turn
        /// to whatever "startingTurn" is passed in. If one isn't passed in, such 
        /// as the value is NONE or null (for error handling), set the default turn
        /// to X.
        /// </summary>
        public void changeTurn()
        {
            if (turn == Letter.O)
                turn = Letter.X;
            else if (turn == Letter.X)
                turn = Letter.O;
            // If game not started, X goes
            else
                turn = Letter.X;
        }
        
        /// <summary>
        /// Check if board is full. If it is, and there's no victory,
        /// it is a CAT.
        /// </summary>
        /// <returns>True if board is full</returns>
        public bool checkForCat()
        {
            // Count how many letters have been placed
            int numLetters = 0;
            for (int row = 0; row < gridHeight; row++)
            {
                for (int col = 0; col < gridWidth; col++)
                {
                    if (grid[row][col] != Letter.NONE)
                        numLetters++;
                }
            }

            // Check if board is full
            int gridSize = gridWidth * gridHeight;
            if (numLetters == gridSize)
                return true;
            else
               return false;
        }

        /// <summary>
        /// Begin the game. X goes first. Empty previous board information
        /// </summary>
        public void startGame(GameType newGameType)
        {
            gameType = newGameType;

            for (int row = 0; row < gridHeight; row++)
            {
                for (int col = 0; col < gridWidth; col++)
                {
                    grid[row][col] = Letter.NONE;
                }
            }

            if (gameType == GameType.TWO_PLAYER)
                turn = Letter.X;
            else
                turn = Letter.O;
        }

        /// <summary>
        /// Check if a value is in a corner or not.
        /// </summary>
        /// <param name="space"></param>
        /// <returns></returns>
        private bool isCorner(Tuple<int, int> space)
        {
            int row = space.Item1;
            int col = space.Item2;

            if ((row == 0 && col == 0) || (row == 0 && col == gridWidth - 1) || 
                (row == gridHeight - 1 && col == 0) || (row == gridHeight - 1 && col == gridWidth - 1))
                return true;
            else return false;
        }

        /// <summary>
        /// Check if a value is in the middle or not.
        /// </summary>
        /// <param name="space"></param>
        /// <returns></returns>
        private bool isMiddle(Tuple<int, int> space)
        {
            int row = space.Item1;
            int col = space.Item2;

            if (row == 1 && col == 1) // TODO make this dynamic
                return true;
            else return false;
        }

        /// <summary>
        /// Check for a potential win. Checks for rows, then columns, then diagonals.
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        private int checkForPotentialWin(Letter letter)
        {
            // Check for win in a row.
            for (int row = 0; row < gridHeight; row++)
            {
                if (grid[row][1] == letter && grid[row][2] == letter && grid[row][0] == Letter.NONE)
                    return (0 + 3 * row);
                if (grid[row][0] == letter && grid[row][2] == letter && grid[row][1] == Letter.NONE)
                    return (1 + 3 * row);
                if (grid[row][0] == letter && grid[row][1] == letter && grid[row][2] == Letter.NONE)
                    return (2 + 3 * row);
            }

            // Check for a win in a column.
            for (int col = 0; col < gridWidth; col++)
            {
                if (grid[1][col] == letter && grid[2][col] == letter && grid[0][col] == Letter.NONE)
                    return (0 + col);
                if (grid[0][col] == letter && grid[2][col] == letter && grid[1][col] == Letter.NONE)
                    return (3 + col);
                if (grid[0][col] == letter && grid[1][col] == letter && grid[2][col] == Letter.NONE)
                    return (6 + col);
            }

            // Check for a win in a diagonal (Top left to bottom right)
            if (grid[0][0] == letter && grid[1][1] == letter && grid[2][2] == Letter.NONE)
                return 8;
            if (grid[0][0] == letter && grid[2][2] == letter && grid[1][1] == Letter.NONE)
                return 4;
            if (grid[1][1] == letter && grid[2][2] == letter && grid[0][0] == Letter.NONE)
                return 0;

            // Check or a win in a diagonal (Top right to bottom left)
            if (grid[0][2] == letter && grid[1][1] == letter && grid[2][0] == Letter.NONE)
                return 6;
            if (grid[0][2] == letter && grid[2][0] == letter && grid[1][1] == Letter.NONE)
                return 4;
            if (grid[2][0] == letter && grid[1][1] == letter && grid[0][2] == Letter.NONE)
                return 2;

            return -1;
        }

        /// <summary>
        /// Make a computer move in an IMPOSSIBLE move game. The computer will immediately try
        /// to win, or else stop the player from winning. Otherwise, it follows a specific pattern
        /// to try and force a winning condition.
        /// </summary>
        /// <returns></returns>
        public int impossibleComputerMove()
        {
            int pos = -1;

            // First, check for potential wins.
            pos = checkForPotentialWin(Letter.X);

            // Then, check for potential losses.
            if (pos == -1)
                pos = checkForPotentialWin(Letter.O);

            // If there's no threat and no potential win, follow these steps.
            if (pos == -1)
            {
                if (isCorner(mostRecent))
                {
                    if (grid[2][2] == Letter.NONE)
                        pos = 8;
                    else if (grid[0][2] == Letter.NONE)
                        pos = 2;
                    else if (grid[2][0] == Letter.NONE)
                        pos = 6;
                }
                else if (isMiddle(mostRecent)) // If placed in middle, do the opposite corner (which is 8)
                {
                    if (grid[2][2] == Letter.NONE)
                        pos = 8;
                    else if (grid[0][2] == Letter.NONE)
                        pos = 2;
                    else if (grid[2][0] == Letter.NONE)
                        pos = 6;
                }
                else // It is an edge
                {
                    if (grid[2][2] == Letter.X && grid[0][2] == Letter.NONE)
                        pos = 2;
                    else if (grid[2][2] == Letter.X && grid[2][0] == Letter.NONE)
                        pos = 6;
                    else if (grid[2][0] == Letter.X && grid[2][2] == Letter.NONE)
                        pos = 2;
                    else if (grid[2][0] == Letter.X && grid[2][2] == Letter.NONE)
                        pos = 8;
                    else if (grid[0][2] == Letter.X && grid[2][0] == Letter.NONE)
                        pos = 6;
                    else if (grid[0][2] == Letter.X && grid[2][2] == Letter.NONE)
                        pos = 8;
                    else if (grid[1][1] == Letter.NONE)
                        pos = 4;
                }
            }

            fillSpace(pos, Letter.X);

            return pos;
        }

        /// <summary>
        /// Take an integer value and populate the grid 2-dimensional array at the associated spot.
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="letter"></param>
        /// <returns></returns>
        private int fillSpace(int loc, Letter letter)
        {
            switch (loc)
            {
                case 0:
                    if (grid[0][0] == Letter.NONE)
                        grid[0][0] = letter;
                    else return -1;
                    break;
                case 1:
                    if (grid[0][1] == Letter.NONE)
                        grid[0][1] = letter;
                    else return -1;
                    break;
                case 2:
                    if (grid[0][2] == Letter.NONE)
                        grid[0][2] = letter;
                    else return -1;
                    break;
                case 3:
                    if (grid[1][0] == Letter.NONE)
                        grid[1][0] = letter;
                    else return -1;
                    break;
                case 4:
                    if (grid[1][1] == Letter.NONE)
                        grid[1][1] = letter;
                    else return -1;
                    break;
                case 5:
                    if (grid[1][2] == Letter.NONE)
                        grid[1][2] = letter;
                    else return -1;
                    break;
                case 6:
                    if (grid[2][0] == Letter.NONE)
                        grid[2][0] = letter;
                    else return -1;
                    break;
                case 7:
                    if (grid[2][1] == Letter.NONE)
                        grid[2][1] = letter;
                    else return -1;
                    break;
                case 8:
                    if (grid[2][2] == Letter.NONE)
                        grid[2][2] = letter;
                    else return -1;
                    break;
            }
            return 0;
        }

        /// <summary>
        /// Make the computer move, in the normal one player mode.
        /// Will check for a potential win, then a potential loss.
        /// For both, there is a %30 chance of making a "mistake"; meaning, it will
        /// skip the opportunity to win or stop the player from winning.
        /// Afterwards, it picks a spot randomly.
        /// </summary>
        /// <returns></returns>
        public int computerMove()
        {
            Random rand = new Random();
            int pos = checkForPotentialWin(Letter.X);
            if (pos > -1)
            {
                int chance = rand.Next(1, 11);
                if (chance > 3) // Must have a 3 or higher to not make a mistake
                {
                    fillSpace(pos, Letter.X);
                    return pos;
                }
                pos = -1;
            }

            pos = checkForPotentialWin(Letter.O);
            if (pos > -1)
            {
                int chance = rand.Next(1, 11);
                if (chance > 3)
                {
                    fillSpace(pos, Letter.X);
                    return pos;
                }
                pos = -1;
            }

            int loc = -1;
            loc = rand.Next(0, 8);
            
            while (pos == -1)
            {
                int success = fillSpace(loc, Letter.X);
                if (success > -1)
                {
                    pos = loc;
                    break;
                }
                loc = rand.Next(0, 9);
            }
            return pos;
        }
    }
}
