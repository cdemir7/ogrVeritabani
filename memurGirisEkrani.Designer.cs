namespace VeriTabanı
{
    partial class memurGirisEkrani
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
            this.memurad = new System.Windows.Forms.TextBox();
            this.memursifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.memurgrsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memurad
            // 
            this.memurad.Location = new System.Drawing.Point(256, 126);
            this.memurad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memurad.Name = "memurad";
            this.memurad.Size = new System.Drawing.Size(345, 32);
            this.memurad.TabIndex = 0;
            // 
            // memursifre
            // 
            this.memursifre.Location = new System.Drawing.Point(256, 220);
            this.memursifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memursifre.Name = "memursifre";
            this.memursifre.PasswordChar = '*';
            this.memursifre.Size = new System.Drawing.Size(345, 32);
            this.memursifre.TabIndex = 1;
            this.memursifre.TextChanged += new System.EventHandler(this.memursifre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // memurgrsbtn
            // 
            this.memurgrsbtn.Location = new System.Drawing.Point(349, 291);
            this.memurgrsbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.memurgrsbtn.Name = "memurgrsbtn";
            this.memurgrsbtn.Size = new System.Drawing.Size(147, 60);
            this.memurgrsbtn.TabIndex = 3;
            this.memurgrsbtn.Text = "Giriş";
            this.memurgrsbtn.UseVisualStyleBackColor = true;
            this.memurgrsbtn.Click += new System.EventHandler(this.memurgrsbtn_Click);
            // 
            // memurGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.memurgrsbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memursifre);
            this.Controls.Add(this.memurad);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "memurGirisEkrani";
            this.Text = "memurLogin";
            this.Load += new System.EventHandler(this.memurGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memurad;
        private System.Windows.Forms.TextBox memursifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button memurgrsbtn;
    }
}