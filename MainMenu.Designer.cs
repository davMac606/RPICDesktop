
namespace RPIC
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSite = new System.Windows.Forms.Button();
            this.grpSobre = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.grpSobre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(465, 511);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(169, 72);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(630, 437);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 67);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSite
            // 
            this.btnSite.Location = new System.Drawing.Point(314, 437);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(155, 67);
            this.btnSite.TabIndex = 0;
            this.btnSite.Text = "Cadastrar";
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // grpSobre
            // 
            this.grpSobre.BackColor = System.Drawing.Color.LightGray;
            this.grpSobre.Controls.Add(this.label1);
            this.grpSobre.Controls.Add(this.btnLogin);
            this.grpSobre.Controls.Add(this.pictureBox1);
            this.grpSobre.Controls.Add(this.btnSite);
            this.grpSobre.Controls.Add(this.btnSair);
            this.grpSobre.Location = new System.Drawing.Point(6, 17);
            this.grpSobre.Name = "grpSobre";
            this.grpSobre.Size = new System.Drawing.Size(1147, 590);
            this.grpSobre.TabIndex = 5;
            this.grpSobre.TabStop = false;
            this.grpSobre.Text = "Sobre o RPIC";
            this.grpSobre.Enter += new System.EventHandler(this.grpSobre_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1001, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "@ 2022 RPIC INC.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.grpSobre);
            this.grpMenu.Location = new System.Drawing.Point(11, 12);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1165, 613);
            this.grpMenu.TabIndex = 11;
            this.grpMenu.TabStop = false;
            this.grpMenu.Enter += new System.EventHandler(this.grpMenu_Enter);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 637);
            this.Controls.Add(this.grpMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.grpSobre.ResumeLayout(false);
            this.grpSobre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSite;
        public System.Windows.Forms.GroupBox grpSobre;
        public System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}