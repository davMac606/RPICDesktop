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
    public partial class MainMenu : Form
    {  
        
        public MainMenu()
        {
            InitializeComponent();
          
        }
      
        private void btnSair_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo sair?", "Alerta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
            Application.Exit();
            } else
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grpSobre.Visible = false;
            SplashScreen sps = new SplashScreen();
            sps.Show();
            sps.MdiParent = this;
        }

        private void grpSobre_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ormomeida.github.io/roedores.net/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LoginUser>().Count() == 0)
            {
                LoginUser log = new LoginUser();
                log.Show();
                log.MdiParent = this;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CadastroUsuario>().Count() == 0)
            {
                CadastroUsuario cad = new CadastroUsuario();
                cad.Show();
                cad.MdiParent = this;
            }
        }
    }
}
