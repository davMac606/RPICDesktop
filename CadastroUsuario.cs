using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPIC
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        MainMenu mn = new MainMenu();
        private void tbIdade_ValueChanged(object sender, EventArgs e)
        {
            lblIdade.Text = tbIdade.Value.ToString();
            tbIdade.Value = int.Parse(lblIdade.Text);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 45;
        }
        public bool aberta = false;
        private void btnSair_Click(object sender, EventArgs e)
        {
            aberta = true;
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo sair?", "Alerta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                CadastroUsuario cad = new CadastroUsuario();
                this.Close();
                
            }
            else
            {
                
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(txtNome.Text, txtUsername.Text, txtSenha.Text, int.Parse(lblIdade.Text));
            if (user.cadastroUsuario())
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Alerta do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Cadastro falhou. Por favor, tente novamente.", "Alerta de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
