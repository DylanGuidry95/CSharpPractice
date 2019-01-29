using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public enum Selection
    {
        ROCK, PAPER, SCISSORS, NONE
    }

    interface IActor
    {
        void SelectPlay(Selection selection);

        bool HasPlayed();
    }

    public class VictoryCondition
    {
        private Selection Winner;
        private Selection Losser;

        public VictoryCondition(Selection win, Selection lost)
        {
            Winner = win;
            Losser = lost;
        }

        public static bool operator ==(VictoryCondition lhs, VictoryCondition rhs)
        {
            return (lhs.Winner == rhs.Winner && lhs.Losser == rhs.Losser);
        }

        public static bool operator !=(VictoryCondition lhs, VictoryCondition rhs)
        {
            return (lhs.Winner != rhs.Winner && lhs.Losser != rhs.Losser);
        }
    }
}
