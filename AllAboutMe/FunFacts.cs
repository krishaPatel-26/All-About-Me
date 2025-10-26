using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Media;

namespace AllAboutMe_KrishaPatel
{
    public partial class FunFacts : Form
    {
        public FunFacts()
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

        private void FunFacts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.mixkit_arcade_game_jump_coin_216);
            playsound.Play();
            if (radF1.Checked == true)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vRXIHjkAsvM");
            }
            if (radLangauges.Checked == true)
            {
                Process.Start("H:/Network Documents/Comp 20S/Unit 1/HelloWorldInternational/HelloWorldInternational/bin/Debug/HelloWorldInternational.exe");
            }
            if (radHistory.Checked == true)
            {
                //System.Diagnostics.Process.Start("https://edubsd-my.sharepoint.com/:p:/r/personal/308029_bsd_ca1/_layouts/15/Doc.aspx?sourcedoc=%7BD4954652-6351-4DE9-98EE-888708FA0D1A%7D&file=THE%20GREAT%20DEPRESSION.pptx&action=edit&mobileredirect=true");
                Process.Start("H:/Network Documents/Comp 20S/Unit 4/AllAboutMe_KrishaPatel/AllAboutMe_KrishaPatel/THE GREAT DEPRESSION.pptx");
            }
            if (radFavClass.Checked == true)
            {
                Process.Start("H:/Network Documents/Comp 20S/Unit 4/AllAboutMe_KrishaPatel/AllAboutMe_KrishaPatel/RENDER.png");
            }
            if(rad9People.Checked == true)
            {
                //Process.Start();
            }
        }

    }
}
