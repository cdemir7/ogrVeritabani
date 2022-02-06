namespace VeriTabanı
{
    partial class ogrenciEkrani
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
            this.derskaydi = new System.Windows.Forms.Button();
            this.notgrntlme = new System.Windows.Forms.Button();
            this.transkrip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // derskaydi
            // 
            this.derskaydi.Location = new System.Drawing.Point(76, 252);
            this.derskaydi.Margin = new System.Windows.Forms.Padding(4);
            this.derskaydi.Name = "derskaydi";
            this.derskaydi.Size = new System.Drawing.Size(174, 73);
            this.derskaydi.TabIndex = 0;
            this.derskaydi.Text = "DERS KAYDI";
            this.derskaydi.UseVisualStyleBackColor = true;
            this.derskaydi.Click += new System.EventHandler(this.derskaydi_Click);
            // 
            // notgrntlme
            // 
            this.notgrntlme.Location = new System.Drawing.Point(396, 252);
            this.notgrntlme.Margin = new System.Windows.Forms.Padding(4);
            this.notgrntlme.Name = "notgrntlme";
            this.notgrntlme.Size = new System.Drawing.Size(174, 73);
            this.notgrntlme.TabIndex = 1;
            this.notgrntlme.Text = "NOT GÖRÜNTÜLEME";
            this.notgrntlme.UseVisualStyleBackColor = true;
            this.notgrntlme.Click += new System.EventHandler(this.notgrntlme_Click);
            // 
            // transkrip
            // 
            this.transkrip.Location = new System.Drawing.Point(716, 252);
            this.transkrip.Margin = new System.Windows.Forms.Padding(4);
            this.transkrip.Name = "transkrip";
            this.transkrip.Size = new System.Drawing.Size(174, 73);
            this.transkrip.TabIndex = 2;
            this.transkrip.Text = "TRANSKRİP";
            this.transkrip.UseVisualStyleBackColor = true;
            // 
            // ogrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.transkrip);
            this.Controls.Add(this.notgrntlme);
            this.Controls.Add(this.derskaydi);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ogrenciEkrani";
            this.Text = "ogrenciekran";
            this.Load += new System.EventHandler(this.ogrenciEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button derskaydi;
        private System.Windows.Forms.Button notgrntlme;
        private System.Windows.Forms.Button transkrip;
    }
}