namespace VeriTabanı
{
    partial class ogretmenEkrani
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
            this.dersonay = new System.Windows.Forms.Button();
            this.notgrs = new System.Windows.Forms.Button();
            this.ogrnciprofil = new System.Windows.Forms.Button();
            this.dersliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dersonay
            // 
            this.dersonay.Location = new System.Drawing.Point(57, 233);
            this.dersonay.Margin = new System.Windows.Forms.Padding(4);
            this.dersonay.Name = "dersonay";
            this.dersonay.Size = new System.Drawing.Size(138, 52);
            this.dersonay.TabIndex = 0;
            this.dersonay.Text = "Ders Onaylama";
            this.dersonay.UseVisualStyleBackColor = true;
            this.dersonay.Click += new System.EventHandler(this.dersonay_Click);
            // 
            // notgrs
            // 
            this.notgrs.Location = new System.Drawing.Point(306, 233);
            this.notgrs.Margin = new System.Windows.Forms.Padding(4);
            this.notgrs.Name = "notgrs";
            this.notgrs.Size = new System.Drawing.Size(138, 52);
            this.notgrs.TabIndex = 1;
            this.notgrs.Text = "Not Girişi";
            this.notgrs.UseVisualStyleBackColor = true;
            this.notgrs.Click += new System.EventHandler(this.notgrs_Click);
            // 
            // ogrnciprofil
            // 
            this.ogrnciprofil.Location = new System.Drawing.Point(537, 233);
            this.ogrnciprofil.Margin = new System.Windows.Forms.Padding(4);
            this.ogrnciprofil.Name = "ogrnciprofil";
            this.ogrnciprofil.Size = new System.Drawing.Size(138, 52);
            this.ogrnciprofil.TabIndex = 2;
            this.ogrnciprofil.Text = "Öğrenci Profili";
            this.ogrnciprofil.UseVisualStyleBackColor = true;
            // 
            // dersliste
            // 
            this.dersliste.Location = new System.Drawing.Point(775, 233);
            this.dersliste.Margin = new System.Windows.Forms.Padding(4);
            this.dersliste.Name = "dersliste";
            this.dersliste.Size = new System.Drawing.Size(138, 51);
            this.dersliste.TabIndex = 3;
            this.dersliste.Text = "Ders Listele";
            this.dersliste.UseVisualStyleBackColor = true;
            // 
            // ogretmenEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dersliste);
            this.Controls.Add(this.ogrnciprofil);
            this.Controls.Add(this.notgrs);
            this.Controls.Add(this.dersonay);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ogretmenEkrani";
            this.Text = "ogretmenekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dersonay;
        private System.Windows.Forms.Button notgrs;
        private System.Windows.Forms.Button ogrnciprofil;
        private System.Windows.Forms.Button dersliste;
    }
}