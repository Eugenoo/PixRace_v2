﻿using System;
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
    public partial class startGame : Form
    {
        public startGame()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(2);
        }

        void moveline(int speed)
        {
            if (stripe1.Top >= 699)
            { stripe1.Top = -85; }
            else { stripe1.Top += speed; }

            if (stripe2.Top >= 699)
            { stripe2.Top = -85; }
            else { stripe2.Top += speed; }

            if (stripe3.Top >= 699)
            { stripe3.Top = -85; }
            else { stripe3.Top += speed; }

            if (stripe4.Top >= 699)
            { stripe4.Top = -85; }
            else { stripe4.Top += speed; }

            //if (stripe5.Top >= 700)
            //{ stripe5.Top = -85; }
            //else { stripe5.Top += speed; }


        }


    }
}
