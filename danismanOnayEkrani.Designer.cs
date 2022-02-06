namespace VeriTabanı
{
    partial class danismanOnayEkrani
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
            this.btnOnayla = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 186);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1530, 723);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtDersKod
            // 
            this.txtDersKod.Location = new System.Drawing.Point(133, 67);
            this.txtDersKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtDersKod.Name = "txtDersKod";
            this.txtDersKod.Size = new System.Drawing.Size(255, 35);
            this.txtDersKod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Kodu";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(1058, 59);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(291, 55);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "İşlemi Gerçekleştir";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(922, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 26);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Onayla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Öğrenci";
            // 
            // txtOgrenci
            // 
            this.txtOgrenci.Location = new System.Drawing.Point(546, 67);
            this.txtOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.txtOgrenci.Name = "txtOgrenci";
            this.txtOgrenci.Size = new System.Drawing.Size(255, 35);
            this.txtOgrenci.TabIndex = 5;
            // 
            // danismanOnayEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1578, 925);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrenci);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersKod);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "danismanOnayEkrani";
            this.Text = "danismanOnay";
            this.Load += new System.EventHandler(this.danismanOnayEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDersKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenci;
    }
}