namespace VeriTabanı
{
    partial class dersKayitEkrani
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
            this.dersVerisi = new System.Windows.Forms.DataGridView();
            this.dersKayitGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dersEkle = new System.Windows.Forms.Button();
            this.dersSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dersVerisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersKayitGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dersVerisi
            // 
            this.dersVerisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersVerisi.Location = new System.Drawing.Point(4, 13);
            this.dersVerisi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dersVerisi.Name = "dersVerisi";
            this.dersVerisi.RowHeadersWidth = 51;
            this.dersVerisi.RowTemplate.Height = 24;
            this.dersVerisi.Size = new System.Drawing.Size(477, 301);
            this.dersVerisi.TabIndex = 0;
            this.dersVerisi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dersVerisi_CellContentClick);
            // 
            // dersKayitGrid
            // 
            this.dersKayitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dersKayitGrid.Location = new System.Drawing.Point(850, 13);
            this.dersKayitGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dersKayitGrid.Name = "dersKayitGrid";
            this.dersKayitGrid.RowHeadersWidth = 51;
            this.dersKayitGrid.RowTemplate.Height = 24;
            this.dersKayitGrid.Size = new System.Drawing.Size(522, 301);
            this.dersKayitGrid.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dersin Adi";
            // 
            // dersEkle
            // 
            this.dersEkle.Location = new System.Drawing.Point(547, 167);
            this.dersEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dersEkle.Name = "dersEkle";
            this.dersEkle.Size = new System.Drawing.Size(84, 29);
            this.dersEkle.TabIndex = 8;
            this.dersEkle.Text = "Ekle";
            this.dersEkle.UseVisualStyleBackColor = true;
            this.dersEkle.Click += new System.EventHandler(this.dersEkle_Click);
            // 
            // dersSil
            // 
            this.dersSil.Location = new System.Drawing.Point(712, 167);
            this.dersSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dersSil.Name = "dersSil";
            this.dersSil.Size = new System.Drawing.Size(84, 29);
            this.dersSil.TabIndex = 9;
            this.dersSil.Text = "Sil";
            this.dersSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 389);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1360, 134);
            this.dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Onaylanan Dersler";
            // 
            // dersKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dersSil);
            this.Controls.Add(this.dersEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dersKayitGrid);
            this.Controls.Add(this.dersVerisi);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dersKayitEkrani";
            this.Text = "mü";
            this.Load += new System.EventHandler(this.dersKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dersVerisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersKayitGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dersVerisi;
        private System.Windows.Forms.DataGridView dersKayitGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dersEkle;
        private System.Windows.Forms.Button dersSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}