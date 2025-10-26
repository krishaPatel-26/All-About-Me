namespace AllAboutMe_KrishaPatel
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.lblAllAboutMeTitle = new System.Windows.Forms.Label();
            this.tmrSplashClose = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAllAboutMeTitle
            // 
            this.lblAllAboutMeTitle.Font = new System.Drawing.Font("Jokerman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllAboutMeTitle.ForeColor = System.Drawing.Color.White;
            this.lblAllAboutMeTitle.Location = new System.Drawing.Point(100, 150);
            this.lblAllAboutMeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllAboutMeTitle.Name = "lblAllAboutMeTitle";
            this.lblAllAboutMeTitle.Size = new System.Drawing.Size(677, 363);
            this.lblAllAboutMeTitle.TabIndex = 9;
            this.lblAllAboutMeTitle.Text = "Welcome to my project... Here you will learn some stuff about me!!";
            this.lblAllAboutMeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSplashClose
            // 
            this.tmrSplashClose.Enabled = true;
            this.tmrSplashClose.Interval = 3500;
            this.tmrSplashClose.Tick += new System.EventHandler(this.tmrSplashClose_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 662);
            this.Controls.Add(this.lblAllAboutMeTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All About Me";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Splash_FormClosed);
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Click += new System.EventHandler(this.Splash_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Splash_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllAboutMeTitle;
        private System.Windows.Forms.Timer tmrSplashClose;
    }
}