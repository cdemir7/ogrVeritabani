namespace VeriTabanı
{
    partial class anaGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.memurbtn = new System.Windows.Forms.Button();
            this.ogrtmnbtn = new System.Windows.Forms.Button();
            this.ogrncibtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memurbtn
            // 
            this.memurbtn.Location = new System.Drawing.Point(223, 287);
            this.memurbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memurbtn.Name = "memurbtn";
            this.memurbtn.Size = new System.Drawing.Size(173, 93);
            this.memurbtn.TabIndex = 0;
            this.memurbtn.Text = "Memur";
            this.memurbtn.UseVisualStyleBackColor = true;
            this.memurbtn.Click += new System.EventHandler(this.memurbtn_Click);
            // 
            // ogrtmnbtn
            // 
            this.ogrtmnbtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ogrtmnbtn.Location = new System.Drawing.Point(494, 287);
            this.ogrtmnbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrtmnbtn.Name = "ogrtmnbtn";
            this.ogrtmnbtn.Size = new System.Drawing.Size(197, 93);
            this.ogrtmnbtn.TabIndex = 1;
            this.ogrtmnbtn.Text = "Öğretmen";
            this.ogrtmnbtn.UseVisualStyleBackColor = true;
            this.ogrtmnbtn.Click += new System.EventHandler(this.ogrtmnbtn_Click);
            // 
            // ogrncibtn
            // 
            this.ogrncibtn.Location = new System.Drawing.Point(770, 287);
            this.ogrncibtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ogrncibtn.Name = "ogrncibtn";
            this.ogrncibtn.Size = new System.Drawing.Size(173, 93);
            this.ogrncibtn.TabIndex = 2;
            this.ogrncibtn.Text = "Öğrenci";
            this.ogrncibtn.UseVisualStyleBackColor = true;
            this.ogrncibtn.Click += new System.EventHandler(this.ogrncibtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(419, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI TİPİNİ SEÇİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrncibtn);
            this.Controls.Add(this.ogrtmnbtn);
            this.Controls.Add(this.memurbtn);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "anaekran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memurbtn;
        private System.Windows.Forms.Button ogrtmnbtn;
        private System.Windows.Forms.Button ogrncibtn;
        private System.Windows.Forms.Label label1;
    }
}

