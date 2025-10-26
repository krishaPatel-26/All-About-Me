using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllAboutMe_KrishaPatel
{
    public partial class TimeLine4 : Form
    {
        public TimeLine4()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeLine3 t3 = new TimeLine3();
            t3.Show();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Maroon;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkSlateGray;
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.DeepSkyBlue;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.DarkSlateGray;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            TimeLine5 t5 = new TimeLine5();
            t5.Show();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.DeepSkyBlue;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.DarkSlateGray;
        }

        private void TimeLine4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
