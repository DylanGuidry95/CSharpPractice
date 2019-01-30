using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private RockPaperScissors RPSGame;
        public Form1(RockPaperScissors game)
        {
            RPSGame = game;
            InitializeComponent();            
        }

        private void PlayerName_TextChanged(object sender, EventArgs e)
        {
            RPSGame.SetPlayerName(PlayerName.Text);
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            RPSGame.GetPlayer().SelectPlay(Selection.ROCK);
            if (RPSGame.VictoryCheck())
                Log.Text = "Game Over";
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            RPSGame.GetPlayer().SelectPlay(Selection.PAPER);            
            if (RPSGame.VictoryCheck())
                Log.Text = "Game Over";
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            RPSGame.GetPlayer().SelectPlay(Selection.SCISSORS);
            if (RPSGame.VictoryCheck())
                Log.Text = "Game Over";
        }
    }
}
