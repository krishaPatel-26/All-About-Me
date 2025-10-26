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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrSplashClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Splash_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SoundPlayer playsound = new SoundPlayer(Properties.Resources.Feel_The_Music_Whatsapp_StatusIns__getmp3_pro_);
            playsound.Play();
        }
    }
}
