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
    public partial class Songs : Form
    {
        public Songs()
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
            SoundPlayer playsound = new SoundPlayer();
            playsound.Stop();
        }

        private void radSucker_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Sucker1);
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

        private void radWhatMakesYouBeautiful_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.What_Makes_You_Beautiful1);
            playsound.Play();
        }

        private void radPerfect_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Perfect1);
            playsound.Play();
        }

        private void radLiveWhileWereYoung_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Live_While_Were_Young1);
            playsound.Play();
        }

        private void radSugar_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Sugar1);
            playsound.Play();
        }

        private void radStitches_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Stitches1);
            playsound.Play();
        }

        private void radChaandBaaliyan_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Chaand_baaliyan1);
            playsound.Play();
        }

        private void radOneThing_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.One_Thing1);
            playsound.Play();
        }

        private void radShapeOfYou_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Shape_of_you1);
            playsound.Play();
        }

        private void radPasoori_CheckedChanged(object sender, EventArgs e)
        {
            tmrFlash.Enabled = true;
            tmrFlashStop.Enabled = true;
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Pasoori1);
            playsound.Play();
        }

        private void tmrFlash_Tick(object sender, EventArgs e)
        {
            picSongs.Visible = true;
            tmrFlash.Stop();
        }

        private void tmrFlashStop_Tick(object sender, EventArgs e)
        {
            tmrFlash.Start();
            picSongs.Visible = false;
        }

        private void Songs_Load(object sender, EventArgs e)
        {
            picSongs.Visible = false;
        }

        private void Songs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            SoundPlayer playsound = new SoundPlayer();
            playsound.Stop();
        }
    }
}
