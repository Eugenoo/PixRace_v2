using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixRace_v2
{
    public partial class Form1 : Form
    {
        startGame gamescreen = new startGame();

        leaderboard leaderboardscreen = new leaderboard();
        public Form1()
        {
           InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            gamescreen.Show();
            Hide();
            
        }

        private void showLeaderboard(object sender, EventArgs e)
        {
            leaderboardscreen.Show();
        }
    }
}
