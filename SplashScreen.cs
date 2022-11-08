using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPIC
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
            pbProgresso.Width = 20;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\aluno\source\repos\RPIC\intro.wav");
            player.Play();
            pbSplash.Visible = false;
            label1.Width = 300;
            label1.Height = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbProgresso.ForeColor = Color.Red;
            pbProgresso.Width += 20;
            UseWaitCursor = true;
            pbSplash.Visible = true;
            if (pbProgresso.Width >= 776)
            {
                MainMenu mn = new MainMenu();
                timer1.Stop();
                this.Hide();
                mn.Show();
            }
        }
    }
}
