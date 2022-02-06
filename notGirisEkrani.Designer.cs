namespace VeriTabanı
{
    partial class notGirisEkrani
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDersKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1393, 678);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDersKod
            // 
            this.txtDersKod.Location = new System.Drawing.Point(104, 40);
            this.txtDersKod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(112, 32);
            this.txtDersKod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Kodu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci";
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(342, 40);
            this.txtOgrenci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(112, 32);
            this.txtOgrenci.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vize";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(574, 40);
            this.txtVize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(112, 32);
            this.txtVize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Final";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(794, 43);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(112, 32);
            this.txtFinal.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Not Girişi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersKod);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "notGirisEkrani";
            this.Text = "notGiris";
            this.Load += new System.EventHandler(this.notGirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDersKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button button1;
    }
}