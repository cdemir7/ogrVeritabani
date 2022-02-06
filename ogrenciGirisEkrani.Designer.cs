namespace VeriTabanı
{
    partial class ogrenciGirisEkrani
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
            this.girisbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrenciad = new System.Windows.Forms.TextBox();
            this.ogrencisifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girisbtn
            // 
            this.girisbtn.Location = new System.Drawing.Point(301, 297);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(317, 51);
            this.girisbtn.TabIndex = 0;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // ogrenciad
            // 
            this.ogrenciad.Location = new System.Drawing.Point(301, 149);
            this.ogrenciad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciad.Name = "ogrenciad";
            this.ogrenciad.Size = new System.Drawing.Size(317, 32);
            this.ogrenciad.TabIndex = 3;
            // 
            // ogrencisifre
            // 
            this.ogrencisifre.Location = new System.Drawing.Point(301, 239);
            this.ogrencisifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrencisifre.Name = "ogrencisifre";
            this.ogrencisifre.PasswordChar = '*';
            this.ogrencisifre.Size = new System.Drawing.Size(317, 32);
            this.ogrencisifre.TabIndex = 4;
            // 
            // ogrenciLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.ogrencisifre);
            this.Controls.Add(this.ogrenciad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisbtn);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ogrenciLogin";
            this.Text = "ogrenciLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrenciad;
        private System.Windows.Forms.TextBox ogrencisifre;
    }
}