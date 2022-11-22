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

            if (Dao_Conexao.getConexao("143.106.241.3", "cl201238", "cl201238", "cl*14032006"))
            {

            }
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
            System.Diagnostics.Process.Start("https://davmac606.github.io/ProjetoBoostrap201238/");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LoginUser>().Count() == 0)
            {
                LoginUser log = new LoginUser();
                log.StartPosition = FormStartPosition.Manual;

                log.Show();


            }
            else
            {
                MessageBox.Show("Já existe uma guia de login aberta. Por favor, feche esta guia para abrir uma nova.", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms.OfType<CadastroUsuario>().Count() == 0)
            {
                grpSobre.Visible = false;
                CadastroUsuario cad = new CadastroUsuario();
                cad.StartPosition = FormStartPosition.Manual;

                cad.Show();
                
                
               
            } else
            {
                MessageBox.Show("Já existe uma guia de cadastro aberta. Por favor, feche esta guia para abrir uma nova.", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
       

        private void MainMenu_Load(object sender, EventArgs e)
        {
            while (Application.OpenForms.OfType<CadastroUsuario>().Count() >=1)
            {
                grpMenu.Visible = false;
            }  
            while (Application.OpenForms.OfType<LoginUser>().Count() >= 1)
            {
                grpMenu.Visible = false;
            }
        }

        private void grpMenu_Enter(object sender, EventArgs e)
        {

        }

        /*private void btnSair_MouseHover(object sender, EventArgs e)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            Random rnd = new Random();
            int num = rnd.Next(screen.Width - btnSair.Width);
            int num1 = rnd.Next(screen.Height - btnSair.Height);

            btnSair.Location = new Point(num, num1);
        }*/
    }
}
