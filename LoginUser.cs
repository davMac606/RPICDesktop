using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RPIC
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo sair?", "Alerta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                LoginUser login = new LoginUser();
                this.Close();

            }
            else
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txtUsername.Text, txtSenha.Text);
            if (user.loginUsuario())
            {
                MessageBox.Show("Bem-vindo, " + txtUsername.Text + "!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("ERRO: Conta não encontrada, acesse o site para efetuar seu cadastro.", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            pbNotShown.Visible = false;
        }

        private void pbShown_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            pbShown.Visible = false;
            pbNotShown.Visible = true;
            txtSenha.MaxLength = 45;
        }

        private void pbNotShown_Click(object sender, EventArgs e)
        {
            pbNotShown.Visible = false;
            pbShown.Visible = true;
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 45;
        }
    }
}
