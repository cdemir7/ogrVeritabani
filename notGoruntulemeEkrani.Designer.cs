namespace VeriTabanı
{
    partial class notGoruntulemeEkrani
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
            this.notGoruntuleGrid = new System.Windows.Forms.DataGridView();
            this.ogrenciNo = new System.Windows.Forms.TextBox();
            this.ogrenciArama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notGoruntuleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // notGoruntuleGrid
            // 
            this.notGoruntuleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notGoruntuleGrid.Location = new System.Drawing.Point(14, 188);
            this.notGoruntuleGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notGoruntuleGrid.Name = "notGoruntuleGrid";
            this.notGoruntuleGrid.RowHeadersWidth = 51;
            this.notGoruntuleGrid.RowTemplate.Height = 24;
            this.notGoruntuleGrid.Size = new System.Drawing.Size(1380, 616);
            this.notGoruntuleGrid.TabIndex = 0;
            // 
            // ogrenciNo
            // 
            this.ogrenciNo.Location = new System.Drawing.Point(548, 55);
            this.ogrenciNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciNo.Name = "ogrenciNo";
            this.ogrenciNo.Size = new System.Drawing.Size(322, 32);
            this.ogrenciNo.TabIndex = 1;
            // 
            // ogrenciArama
            // 
            this.ogrenciArama.Location = new System.Drawing.Point(548, 116);
            this.ogrenciArama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciArama.Name = "ogrenciArama";
            this.ogrenciArama.Size = new System.Drawing.Size(322, 29);
            this.ogrenciArama.TabIndex = 2;
            this.ogrenciArama.Text = "Ogrenci Ara";
            this.ogrenciArama.UseVisualStyleBackColor = true;
            this.ogrenciArama.Click += new System.EventHandler(this.ogrenciArama_Click);
            // 
            // notGoruntulemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.ogrenciArama);
            this.Controls.Add(this.ogrenciNo);
            this.Controls.Add(this.notGoruntuleGrid);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "notGoruntulemeEkrani";
            this.Text = "notGoruntule";
            this.Load += new System.EventHandler(this.notGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notGoruntuleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView notGoruntuleGrid;
        private System.Windows.Forms.TextBox ogrenciNo;
        private System.Windows.Forms.Button ogrenciArama;
    }
}