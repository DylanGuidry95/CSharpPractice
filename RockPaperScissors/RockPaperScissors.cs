using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RockPaperScissors
    {
        private Dictionary<Player, bool> Participants;
        private int WinningScore;
        private int NumPlayers;
        private List<VictoryCondition> WinConditions;

        public RockPaperScissors()
        {
            Participants = new Dictionary<Player, bool>();
            Participants.Add(new Player(), false);
            Participants.Add(new Player(), false);
            NumPlayers = 2;
            WinningScore = 1;
            WinConditions = new List<VictoryCondition>();
            VictoryCondition rock = new VictoryCondition(Selection.ROCK, Selection.SCISSORS);
            VictoryCondition paper = new VictoryCondition(Selection.PAPER, Selection.ROCK);
            VictoryCondition scissors = new VictoryCondition(Selection.SCISSORS, Selection.PAPER);
            WinConditions.Add(rock);
            WinConditions.Add(paper);
            WinConditions.Add(scissors);
            StartRound();
        }

        public RockPaperScissors(List<Player> players, int winScore)
        {
            Participants = new Dictionary<Player, bool>();
            NumPlayers = players.Count * 2;
            foreach (var player in players)
            {
                Participants.Add(player, true);
                Participants.Add(new Player("CPU" + players.IndexOf(player)), false);
            }

            NumPlayers = Participants.Count;
            WinningScore = winScore;
            WinConditions = new List<VictoryCondition>();
            VictoryCondition rock = new VictoryCondition(Selection.ROCK, Selection.SCISSORS);
            VictoryCondition paper = new VictoryCondition(Selection.PAPER, Selection.ROCK);
            VictoryCondition scissors = new VictoryCondition(Selection.SCISSORS, Selection.PAPER);
            WinConditions.Add(rock);
            WinConditions.Add(paper);
            WinConditions.Add(scissors);
            StartRound();
        }

        void StartRound()
        {
            foreach (var participant in Participants)
            {
                if (!participant.Value)
                {
                    var rand = new Random();
                    int selection = rand.Next(0, 3);
                    Selection a = (Selection) selection;
                    participant.Key.SelectPlay((Selection)selection);
                }
            }
        }

        public bool VictoryCheck()
        {            
            foreach (var participant in Participants)
            {
                if(!participant.Key.HasPlayed())
                    return false;
            }

            if (NumPlayers != 2)
                return false;

            List<Selection> InPlay = new List<Selection>();
            foreach (var participant in Participants)
            {
                InPlay.Add(participant.Key.InPlaySelection);
            }                        

            foreach (var condition in WinConditions)
            {
                if (condition == new VictoryCondition(InPlay[0], InPlay[1]))
                    if (Participants.First().Key.IncreaseScore(1) == WinningScore)
                        return true;
            }

            if (Participants.Last().Key.IncreaseScore(1) == WinningScore)            
                return true;
            
            StartRound();
            return false;
        }

        public void SetPlayerName(string name)
        {
            Participants.First().Key.SetName(name);
        }

        public Player GetPlayer()
        {
            return Participants.First().Key;
        }

        public List<Selection> GetPlayed()
        {
            List<Selection> InPlay = new List<Selection>();
            foreach (var participant in Participants)
            {
                InPlay.Add(participant.Key.InPlaySelection);
            }

            return InPlay;
        }
    }
}
