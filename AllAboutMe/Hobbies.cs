using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllAboutMe_KrishaPatel
{
    public partial class Hobbies : Form
    {
        public Hobbies()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a program that shows some basic info about me!!");
        }

        private void mainMeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {
            int speed;

            if (radHangingOut.Checked == true && picFriends.Right > 0)
            {
                speed = 10;
                picFriends.Left = picFriends.Left + speed;
                if (picFriends.Left > 650)
                {
                    picFriends.Left = -245;
                }
            }
            if (radBikeRide.Checked == true && picBikeRide.Right > 0)
            {
                speed = 10;
                picBikeRide.Left = picBikeRide.Left + speed;
                if (picBikeRide.Left > 650)
                {
                    picBikeRide.Left = -245;
                }
            }
            if (radColoring.Checked == true && picColoring.Right > 0)
            {
                speed = 10;
                picColoring.Left = picColoring.Left + speed;
                if (picColoring.Left > 650)
                {
                    picColoring.Left = -245;
                }
            }
            if (radChilling.Checked == true && picChilling.Right > 0)
            {
                speed = 10;
                picChilling.Left = picChilling.Left + speed;
                if (picChilling.Left > 650)
                {
                    picChilling.Left = -245;
                }
            }
            if (radMusic.Checked == true && picMusic.Right > 0)
            {
                speed = 10;
                picMusic.Left = picMusic.Left + speed;
                if (picMusic.Left > 650)
                {
                    picMusic.Left = -245;
                }
            }
            if (radSleeping.Checked == true && picSleeping.Right > 0)
            {
                speed = 10;
                picSleeping.Left = picSleeping.Left + speed;
                if (picSleeping.Left > 650)
                {
                    picSleeping.Left = -245;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Maroon;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkSlateGray;
        }

        private void radHangingOut_CheckedChanged(object sender, EventArgs e)
        {
            picFriends.Visible = true;
            tmrGo.Enabled = true;
       
        }

        private void radBikeRide_CheckedChanged(object sender, EventArgs e)
        {
            picBikeRide.Visible = true;
            tmrGo.Enabled = true;
        }

        private void radChilling_CheckedChanged(object sender, EventArgs e)
        {
            picChilling.Visible = true;
            tmrGo.Enabled = true;
        }

        private void radColoring_CheckedChanged(object sender, EventArgs e)
        {
            picColoring.Visible = true;
            tmrGo.Enabled = true;
        }

        private void radMusic_CheckedChanged(object sender, EventArgs e)
        {
            picMusic.Visible = true;
            tmrGo.Enabled = true;
        }

        private void radSleeping_CheckedChanged(object sender, EventArgs e)
        {
            picSleeping.Visible = true;
            tmrGo.Enabled = true;
        }

        private void Hobbies_Load(object sender, EventArgs e)
        {
            picFriends.Visible = false;
            picBikeRide.Visible = false;
            picChilling.Visible = false;
            picColoring.Visible = false;
            picMusic.Visible = false;
            picSleeping.Visible = false;
        }

        private void Hobbies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
