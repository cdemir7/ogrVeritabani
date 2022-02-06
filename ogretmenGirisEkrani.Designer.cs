namespace VeriTabanı
{
    partial class ogretmenGirisEkrani
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
            this.ogrtmnbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrtmnad = new System.Windows.Forms.TextBox();
            this.ogrtmnsifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ogrtmnbtn
            // 
            this.ogrtmnbtn.Location = new System.Drawing.Point(355, 344);
            this.ogrtmnbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ogrtmnbtn.Name = "ogrtmnbtn";
            this.ogrtmnbtn.Size = new System.Drawing.Size(326, 32);
            this.ogrtmnbtn.TabIndex = 0;
            this.ogrtmnbtn.Text = "Giriş";
            this.ogrtmnbtn.UseVisualStyleBackColor = true;
            this.ogrtmnbtn.Click += new System.EventHandler(this.ogrtmnbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // ogrtmnad
            // 
            this.ogrtmnad.Location = new System.Drawing.Point(355, 208);
            this.ogrtmnad.Margin = new System.Windows.Forms.Padding(4);
            this.ogrtmnad.Name = "ogrtmnad";
            this.ogrtmnad.Size = new System.Drawing.Size(325, 35);
            this.ogrtmnad.TabIndex = 2;
            // 
            // ogrtmnsifre
            // 
            this.ogrtmnsifre.Location = new System.Drawing.Point(355, 287);
            this.ogrtmnsifre.Margin = new System.Windows.Forms.Padding(4);
            this.ogrtmnsifre.Name = "ogrtmnsifre";
            this.ogrtmnsifre.PasswordChar = '*';
            this.ogrtmnsifre.Size = new System.Drawing.Size(325, 35);
            this.ogrtmnsifre.TabIndex = 3;
            // 
            // ogretmenGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.ogrtmnsifre);
            this.Controls.Add(this.ogrtmnad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrtmnbtn);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ogretmenGirisEkrani";
            this.Text = "ögretmenLogin";
            this.Load += new System.EventHandler(this.ogretmenGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrtmnbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrtmnad;
        private System.Windows.Forms.TextBox ogrtmnsifre;
    }
}