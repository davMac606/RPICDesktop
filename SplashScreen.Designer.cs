
namespace RPIC
{
    partial class SplashScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbSplash = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProgresso
            // 
            this.pbProgresso.BackColor = System.Drawing.Color.Red;
            this.pbProgresso.Location = new System.Drawing.Point(14, 543);
            this.pbProgresso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(905, 30);
            this.pbProgresso.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbSplash
            // 
            this.pbSplash.Image = ((System.Drawing.Image)(resources.GetObject("pbSplash.Image")));
            this.pbSplash.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSplash.InitialImage")));
            this.pbSplash.Location = new System.Drawing.Point(273, 112);
            this.pbSplash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(378, 402);
            this.pbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplash.TabIndex = 1;
            this.pbSplash.TabStop = false;
            this.pbSplash.Click += new System.EventHandler(this.pbSplash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bem vindo ao RPIC!";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSplash);
            this.Controls.Add(this.pbProgresso);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbSplash;
        private System.Windows.Forms.Label label1;
    }
}

