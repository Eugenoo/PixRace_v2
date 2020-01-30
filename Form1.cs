using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PixRace_v2
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        startGame gamescreen = new startGame();

        leaderboard leaderboardscreen = new leaderboard();
        public Form1()
        {
           InitializeComponent();
            player.URL = "bgmusic.mp3";
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

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
