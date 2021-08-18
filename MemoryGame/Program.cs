using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    static class Program
    {
        /// <summary>
        /*
         * Make the C# GUI program for memory game. 
         
         * It is possible to play against computer or human player.
         
         * When the player guesses the right pairs from the cards that program has randomly inserted to the game grid,
           the player can continue guessing, but if the player guesses wrong, the turn is passed to other player (computer or human being).

         * In the beginning of the game, the player can select the number of cards and after that the program inserts the cards on the grid randomly.
         
         * Winner is the player who has guessed most of the pairs at the end of the game(so the game has to have bookkeeping about the right pairs). 
         
         * If the player doesn’t guess the pairs, the cards are turned again upside down.
         
         * Program asks the player/players information. Player information in saved in file and from file’s data it is possible to find out for example win/defeat statistics.
        */
        /// </summary>
        [STAThread]
        static void Main()
        {
            var game = new Memory();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
