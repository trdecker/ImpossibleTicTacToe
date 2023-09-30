/**
 * TODO: Create algorithm for IMPOSSIBLE mode
 * TODO: For normal, make random, or use IMPOSSIBLE mode but randomly pick bad choices (around two, maybe)
 * TODO: Connect to GitHub
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Create a new game, and pass that new game into
        /// a new gameForm.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game game = new Game();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gameForm(game));
        }
    }
}
