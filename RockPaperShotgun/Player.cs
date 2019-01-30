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
        public int Selection;

        public void ChooseSelection()
        {
            Console.Write("Choose a value, 1 for Rock, 2 for Paper, 3 for Shotgun\n");
            Selection = Convert.ToInt32(Console.ReadLine());
        }

        public void AiSelection()
        {
            Selection = new Random().Next(1,3);
        }

        public Player()
        {
            Selection = 1;
        }
    }
}
