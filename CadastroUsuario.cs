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

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja mesmo sair?", "Alerta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                mn.grpMenu.Visible = true;
                
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
    }
}
