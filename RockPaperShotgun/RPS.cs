using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace RockPaperShotgun
{
    class RPS
    {
        //bool checks for game state

        private bool Playing = true;
        private bool VictoryFound = false;

        Player user = new Player();
        Player comp = new Player();

        //checking for game victory. Will output result to console, wait for user to press enter, 
        //then determine if another round should be played.
        public void CheckVictory(Player user, Player comp)
        {
            if (user.Selection == 1)
            {
                if (comp.Selection == 1)
                {
                    Console.Write("Tie\n");
                    
                    
                }
                if (comp.Selection == 2)
                {
                    Console.Write("Comp Wins!\n");
                    VictoryFound = true;
                    
                }
                if (comp.Selection == 3)
                {
                    Console.Write("Player Wins!\n");
                    VictoryFound = true;
                }
            }

            if (user.Selection == 2)
            {
                if (comp.Selection == 1)
                {
                    Console.Write("Player Wins!\n");
                    VictoryFound = true;
                    
                }
                if (comp.Selection == 2)
                {
                    Console.Write("Tie\n");
                    
                }
                if (comp.Selection == 3)
                {
                    Console.Write("Comp Wins!\n");
                    VictoryFound = true;
                    
                }
            }

            if (user.Selection == 3)
            {
                if (comp.Selection == 1)
                {
                    Console.Write("Comp Wins!\n");
                    VictoryFound = true;
                    
                }
                if (comp.Selection == 2)
                {
                    Console.Write("Player Wins!\n");
                    VictoryFound = true;
                    
                }
                if (comp.Selection == 3)
                {
                    Console.Write("Tie\n");
                    
                }
            }

            Console.ReadLine();

            if (VictoryFound)
            {
                Playing = false;
            }
        }





        //Starts the game, runs it as a while loop on Playing bool
        public void PlayGame()
        {
            Console.Write("Let's play Rock Paper Shotgun! Rock > Paper. Shotgun > Paper. Rock > Shotgun.\n");

            while (Playing)
            {
                user.ChooseSelection();
                comp.AiSelection();
                CheckVictory(user, comp);
            }
        }




    }
}
