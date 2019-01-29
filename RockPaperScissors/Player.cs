using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player : IActor
    {
        public Selection InPlaySelection;
        private string Name;
        private int Score;

        public Player()
        {
            Name = "Default";
            InPlaySelection = Selection.NONE;            
            Score = 0;
        }

        public Player(string name)
        {
            Name = name;
            InPlaySelection = Selection.NONE;
            Score = 0;
        }

        public void SelectPlay(Selection selection)
        {
            if (InPlaySelection == Selection.NONE)
                InPlaySelection = selection;
        }

        public bool HasPlayed()
        {
            return (InPlaySelection != Selection.NONE);
        }

        public int IncreaseScore(int amount)
        {
            return Score += amount;
        }
    }
}
