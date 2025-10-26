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
    public partial class Main : Form
    {
        public Main()
        {
            //Application.Run(new Splash());
            InitializeComponent();
        }

        private void btnTimeline_Click(object sender, EventArgs e)
        {
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
            this.Hide();
            TimeLineStart ts = new TimeLineStart();
            ts.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a program that shows some basic info about me!!");
        }

        private void btnFunFacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FunFacts f = new FunFacts();
            f.Show();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Songs s = new Songs();
            s.Show();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
        }

        private void btnTimeline_MouseHover(object sender, EventArgs e)
        {
            btnTimeline.BackColor = Color.DarkCyan;
        }

        private void btnTimeline_MouseLeave(object sender, EventArgs e)
        {
            btnTimeline.BackColor = Color.DarkSlateGray;
        }

        private void btnSongs_MouseHover(object sender, EventArgs e)
        {
            btnSongs.BackColor = Color.DarkCyan;
        }

        private void btnSongs_MouseLeave(object sender, EventArgs e)
        {
            btnSongs.BackColor = Color.DarkSlateGray;
        }

        private void btnHobbies_MouseHover(object sender, EventArgs e)
        {
            btnHobbies.BackColor = Color.DarkCyan;
        }

        private void btnHobbies_MouseLeave(object sender, EventArgs e)
        {
            btnHobbies.BackColor = Color.DarkSlateGray;
        }

        private void btnFunFacts_MouseHover(object sender, EventArgs e)
        {
            btnFunFacts.BackColor = Color.DarkCyan;
        }

        private void btnFunFacts_MouseLeave(object sender, EventArgs e)
        {
            btnFunFacts.BackColor = Color.DarkSlateGray;
        }

        private void btnHobbies_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hobbies h = new Hobbies();
            h.Show();
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
