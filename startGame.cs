using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PixRace_v2
{
    public partial class startGame : Form
    {
        public startGame()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy(gamespeed);
            moveline(gamespeed);
            gameover();
            
            
            
        }

        Random rand = new Random();
        int x, y;


        void enemy(int speed)
        {
            int speedlocal = speed;
            if (car1.Top >= 699)
            {
                x = rand.Next(30, 404);
                y = -100;
                car1.Location = new Point(x, y);
            }
            else { car1.Top += (speedlocal / 4); }

            if (car2.Top >= 699)
            {
                x = rand.Next(30, 404);
                y = -100;
                car2.Location = new Point(x, y);
            }
            else { car2.Top += (speedlocal / 4); }

            if (car3.Top >= 699)
            {
                x = rand.Next(30, 404);
                y = -100;
                car3.Location = new Point(x, y);
            }
            else { car3.Top += (speedlocal / 4); }
        }

        void savescore()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\Users\admin\source\repos\scores.txt",lines);
        }
        void moveline2(int speed,PictureBox formStripe)
        {
            int speedlocal2 = speed;

            if (formStripe.Top >= 699)
            { formStripe.Top = -85; }
            else { formStripe.Top += (speedlocal2 / 2); }
        }
        void moveline(int speed)
        {
            int speedlocal = speed;

            moveline2(speedlocal, stripe1);
            // makes stripes go slower than aproaching enemy cars

            moveline2(speedlocal, stripe2);
            moveline2(speedlocal, stripe3);
            moveline2(speedlocal, stripe4);
            //if (stripe5.Top >= 700)
            //{ stripe5.Top = -85; }
            //else { stripe5.Top += speed; }


        }
        void endgame()
        {
            timer1.Enabled = false;
            gameOverLabel.Visible = true;
            resumeButton.Visible = true;
            goToMenu.Visible = true;
            pointsTimer.Enabled = false;
            savescore();
        }
        void gameover()
        {
            if (playerCar.Bounds.IntersectsWith(car1.Bounds))
            {
                endgame();
              

            }
            if (playerCar.Bounds.IntersectsWith(car2.Bounds))
            {
                endgame();
                
            }
            if (playerCar.Bounds.IntersectsWith(car3.Bounds))
            {
                endgame();
               
            }
        }
        int gamespeed = 0;

      
        
        
        private void resumeButton_Click(object sender, EventArgs e)
        {
            restart();
            savescore();
            

        }

        private void restart()
        {
            gameOverLabel.Visible = false;
            resumeButton.Visible = false;
            goToMenu.Visible = false;
            timer1.Enabled = true;

           
            startGame newGame = new startGame();             //This will be used if i didnt find how to restart in same window
            newGame.Show();
            Close();



            /*timer1.Enabled = true;
            playerCar.Location = new Point(333, 533);
            car3.Location = new Point(56, 88);
            car2.Location = new Point(56, 316);
            car1.Location = new Point(56, 533);*/
            
        }
       /* private void countPoints()
        {
            int points =0;
            if(gamespeed == 0)
            {
                points += 0;
            }
            else
            {
               // points = gamespeed * 
            }
        }*/
        private void goToMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            Close();
        }

        int points = 0;

        private void Points_Tick(object sender, EventArgs e)
        {

            

            if (gamespeed == 0)
                {
                    points += 0;
                pointsLabel.Text = "Score: " + points ;
                }
                else
                {
                    points += gamespeed;
                pointsLabel.Text = "Score: " + points ;
                }

        }

       

        private void speed_Tick(object sender, EventArgs e)
        {
            int speed = 0;
            if (gamespeed == 0)
               {
                speed += 0;
                speedLabel.Text = "Speed " + speed +" MPH";
               }
            else
            {
                speed += gamespeed;
                speedLabel.Text = "Speed " + speed +" MPH";
            }
        }

        

        private void startGame_KeyDown(object sender, KeyEventArgs e)
        {
            //moving left & right
            if (e.KeyCode == Keys.Left)
            {
                if (playerCar.Left > 30)
                    playerCar.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (playerCar.Left < 404)
                    playerCar.Left += 10;
            }

            //moving foward & back

            if (e.KeyCode == Keys.Up)
                if (gamespeed <= 32)
                {
                    gamespeed++;
                }
            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                {
                    gamespeed--;
                }





        }
    }
}