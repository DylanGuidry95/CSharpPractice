using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperShotgun
{
    class Player
    { 
        //stores the player's current selection.
        public int Selection;

        //Takes user input for the user player, sets it as current Selection.
        public void ChooseSelection()
        {
            Console.Write("Choose a value, 1 for Rock, 2 for Paper, 3 for Shotgun\n");
            Selection = Convert.ToInt32(Console.ReadLine());
        }

        //sets the computer's selection to a random choice between 1 and 3
        public void AiSelection()
        {
            Selection = new Random().Next(1,3);
        }

        //Constructs player with 1 as default selection
        public Player()
        {
            Selection = 1;
        }
    }
}
