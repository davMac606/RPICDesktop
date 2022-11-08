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
            
            if (DialogResult.OK != MessageBox.Show("Rimani qui!", "Alerta do Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) {
            Application.Exit();
            } else
            {

            }
            
        }
    }
}
