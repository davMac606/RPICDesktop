
namespace RPIC
{
    partial class CadastroUsuario
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
            this.grpCadastroUser = new System.Windows.Forms.GroupBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.tbIdade = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpCadastroUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCadastroUser
            // 
            this.grpCadastroUser.Controls.Add(this.btnCadastrar);
            this.grpCadastroUser.Controls.Add(this.btnSair);
            this.grpCadastroUser.Controls.Add(this.txtSenha);
            this.grpCadastroUser.Controls.Add(this.txtUsername);
            this.grpCadastroUser.Controls.Add(this.txtNome);
            this.grpCadastroUser.Controls.Add(this.lblIdade);
            this.grpCadastroUser.Controls.Add(this.tbIdade);
            this.grpCadastroUser.Controls.Add(this.label4);
            this.grpCadastroUser.Controls.Add(this.label3);
            this.grpCadastroUser.Controls.Add(this.label2);
            this.grpCadastroUser.Controls.Add(this.label1);
            this.grpCadastroUser.Location = new System.Drawing.Point(12, 12);
            this.grpCadastroUser.Name = "grpCadastroUser";
            this.grpCadastroUser.Size = new System.Drawing.Size(1176, 649);
            this.grpCadastroUser.TabIndex = 0;
            this.grpCadastroUser.TabStop = false;
            this.grpCadastroUser.Text = "Cadastro de Usuários";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(674, 158);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(28, 21);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "16";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(580, 110);
            this.tbIdade.Maximum = 80;
            this.tbIdade.Minimum = 16;
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(225, 45);
            this.tbIdade.TabIndex = 4;
            this.tbIdade.Value = 18;
            this.tbIdade.ValueChanged += new System.EventHandler(this.tbIdade_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome de usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 29);
            this.txtNome.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(580, 62);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 29);
            this.txtUsername.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(68, 102);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(225, 29);
            this.txtSenha.TabIndex = 8;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(1047, 10);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 57);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(10, 586);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 57);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.grpCadastroUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro";
            this.grpCadastroUser.ResumeLayout(false);
            this.grpCadastroUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCadastroUser;
        private System.Windows.Forms.TrackBar tbIdade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
    }
}