using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace RPIC
{
    public partial class SplashScreen : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\aluno\source\repos\RPICDesktop\intro.wav");
      
      
        
        public SplashScreen()

        {
           
            InitializeComponent();
            timer1.Start();
            pbProgresso.Width = 20;
            pbSplash.Visible = false;
            label1.Width = 300;
            label1.Height = 20;
            player.Play();
            pbSound.Visible = false;
         
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pbProgresso.ForeColor = System.Drawing.Color.Red;
            pbProgresso.Width += 20;
            UseWaitCursor = true;
            pbSplash.Visible = true;
            if (pbProgresso.Width >= 776)
            {
                MainMenu mn = new MainMenu();
                if (Application.OpenForms.Count > 1)
                {
                    this.Close();
                }
                timer1.Stop();
                this.Hide();
                mn.Show();
                    player.Stop();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void pbSplash_Click(object sender, EventArgs e)
        {

        }

        private void pbSom_Click(object sender, EventArgs e)
        {
            player.Stop();
            pbSound.Visible = true;
            pbNoSound.Visible = false;
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            player.Play();
            pbSound.Visible = false;
            pbNoSound.Visible = true;
        }
    }
}
