using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    struct Node<T>
    {
        public T Value;        
        public bool IsVictor;
    }

    class Match<T>
    {
        public Node<T> ContestantLeft;
        public Node<T> ContestantRight;

        public Match<T> ConnectedMatchLeft;
        public Match<T> ConnectedMatchRight;

        void SetLeftContestant()
        {
            ContestantLeft.Value = ConnectedMatchLeft.GetVictor();
        }
        void SetRightContestant()
        {
            ContestantRight.Value = ConnectedMatchRight.GetVictor();
        }

        T GetVictor()
        {
            return ContestantLeft.IsVictor ? ContestantLeft.Value : ContestantRight.Value;
        }
    }

    class TournamentTree<T>
    {
        public int NumberContestants;
        public List<Match<T>> Matches;

        TournamentTree(int numContestants)
        {
            NumberContestants = numContestants;
            for (int i = 0; i < numContestants / 2; i++)
            {
                Matches.Add(new Match<T>());
                if (i % 2 == 0)
                {
                    
                }
            }
        }
    }
}
