
namespace RPIC
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.pbNotShown = new System.Windows.Forms.PictureBox();
            this.pbShown = new System.Windows.Forms.PictureBox();
            this.pbData = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotShown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BackColor = System.Drawing.Color.LightGray;
            this.grpLogin.Controls.Add(this.pbNotShown);
            this.grpLogin.Controls.Add(this.pbShown);
            this.grpLogin.Controls.Add(this.pbData);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.label2);
            this.grpLogin.Controls.Add(this.txtSenha);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.btnSair);
            this.grpLogin.Location = new System.Drawing.Point(12, 12);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(977, 340);
            this.grpLogin.TabIndex = 0;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login de Usuário";
            // 
            // pbNotShown
            // 
            this.pbNotShown.Image = ((System.Drawing.Image)(resources.GetObject("pbNotShown.Image")));
            this.pbNotShown.Location = new System.Drawing.Point(334, 80);
            this.pbNotShown.Name = "pbNotShown";
            this.pbNotShown.Size = new System.Drawing.Size(27, 25);
            this.pbNotShown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotShown.TabIndex = 13;
            this.pbNotShown.TabStop = false;
            this.pbNotShown.Click += new System.EventHandler(this.pbNotShown_Click);
            // 
            // pbShown
            // 
            this.pbShown.Image = ((System.Drawing.Image)(resources.GetObject("pbShown.Image")));
            this.pbShown.Location = new System.Drawing.Point(334, 80);
            this.pbShown.Name = "pbShown";
            this.pbShown.Size = new System.Drawing.Size(27, 25);
            this.pbShown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShown.TabIndex = 12;
            this.pbShown.TabStop = false;
            this.pbShown.Click += new System.EventHandler(this.pbShown_Click);
            // 
            // pbData
            // 
            this.pbData.Image = ((System.Drawing.Image)(resources.GetObject("pbData.Image")));
            this.pbData.Location = new System.Drawing.Point(620, 24);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(300, 300);
            this.pbData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbData.TabIndex = 11;
            this.pbData.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(334, 267);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(175, 57);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(9, 267);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 57);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(125, 80);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(203, 25);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(125, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(203, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de usuário:";
            // 
            // LoginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 366);
            this.Controls.Add(this.grpLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginUser";
            this.Text = "LoginUser";
            this.Load += new System.EventHandler(this.LoginUser_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotShown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbData;
        private System.Windows.Forms.PictureBox pbNotShown;
        private System.Windows.Forms.PictureBox pbShown;
    }
}