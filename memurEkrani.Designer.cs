namespace VeriTabanı
{
    partial class memurEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.ogrnciNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ogrnciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrnciSoyad = new System.Windows.Forms.TextBox();
            this.ogrenciekle = new System.Windows.Forms.Button();
            this.ogrencisil = new System.Windows.Forms.Button();
            this.ogrenciguncelle = new System.Windows.Forms.Button();
            this.gridwiewogrenci = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogretmemad = new System.Windows.Forms.TextBox();
            this.ogrtmensoyad = new System.Windows.Forms.TextBox();
            this.ogretmenkullanici = new System.Windows.Forms.TextBox();
            this.ogretmenekle = new System.Windows.Forms.Button();
            this.ogrtmensil = new System.Windows.Forms.Button();
            this.ogrtmnguncel = new System.Windows.Forms.Button();
            this.wiwevogrtmn = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ogrencıBolumu = new System.Windows.Forms.ComboBox();
            this.ogretmenBolum = new System.Windows.Forms.ComboBox();
            this.ogrenciSinifi = new System.Windows.Forms.ComboBox();
            this.ogretmenSinifi = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridwiewogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiwevogrtmn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ogrnciNo
            // 
            this.ogrnciNo.Location = new System.Drawing.Point(129, 72);
            this.ogrnciNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrnciNo.Name = "ogrnciNo";
            this.ogrnciNo.Size = new System.Drawing.Size(112, 32);
            this.ogrnciNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci Adı";
            // 
            // ogrnciAd
            // 
            this.ogrnciAd.Location = new System.Drawing.Point(129, 136);
            this.ogrnciAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrnciAd.Name = "ogrnciAd";
            this.ogrnciAd.Size = new System.Drawing.Size(112, 32);
            this.ogrnciAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci Soyadı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ogrnciSoyad
            // 
            this.ogrnciSoyad.Location = new System.Drawing.Point(129, 192);
            this.ogrnciSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrnciSoyad.Name = "ogrnciSoyad";
            this.ogrnciSoyad.Size = new System.Drawing.Size(112, 32);
            this.ogrnciSoyad.TabIndex = 3;
            // 
            // ogrenciekle
            // 
            this.ogrenciekle.Location = new System.Drawing.Point(17, 345);
            this.ogrenciekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciekle.Name = "ogrenciekle";
            this.ogrenciekle.Size = new System.Drawing.Size(114, 32);
            this.ogrenciekle.TabIndex = 4;
            this.ogrenciekle.Text = "EKLE";
            this.ogrenciekle.UseVisualStyleBackColor = true;
            this.ogrenciekle.Click += new System.EventHandler(this.ogrenciekle_Click);
            // 
            // ogrencisil
            // 
            this.ogrencisil.Location = new System.Drawing.Point(226, 348);
            this.ogrencisil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrencisil.Name = "ogrencisil";
            this.ogrencisil.Size = new System.Drawing.Size(114, 29);
            this.ogrencisil.TabIndex = 5;
            this.ogrencisil.Text = "SİL";
            this.ogrencisil.UseVisualStyleBackColor = true;
            this.ogrencisil.Click += new System.EventHandler(this.ogrencisil_Click);
            // 
            // ogrenciguncelle
            // 
            this.ogrenciguncelle.Location = new System.Drawing.Point(447, 349);
            this.ogrenciguncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciguncelle.Name = "ogrenciguncelle";
            this.ogrenciguncelle.Size = new System.Drawing.Size(114, 29);
            this.ogrenciguncelle.TabIndex = 6;
            this.ogrenciguncelle.Text = "GÜNCELLE";
            this.ogrenciguncelle.UseVisualStyleBackColor = true;
            this.ogrenciguncelle.Click += new System.EventHandler(this.ogrenciguncelle_Click);
            // 
            // gridwiewogrenci
            // 
            this.gridwiewogrenci.AllowUserToAddRows = false;
            this.gridwiewogrenci.AllowUserToDeleteRows = false;
            this.gridwiewogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridwiewogrenci.Location = new System.Drawing.Point(17, 385);
            this.gridwiewogrenci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridwiewogrenci.Name = "gridwiewogrenci";
            this.gridwiewogrenci.ReadOnly = true;
            this.gridwiewogrenci.RowHeadersWidth = 51;
            this.gridwiewogrenci.RowTemplate.Height = 24;
            this.gridwiewogrenci.Size = new System.Drawing.Size(650, 441);
            this.gridwiewogrenci.TabIndex = 7;
            this.gridwiewogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridwiewogrenci_CellContentClick);
            this.gridwiewogrenci.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridwiewogrenci_CellEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(844, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öğretmen Ad";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(844, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Öğretmen Soyad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(844, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Öğretmen Kullanıcı No";
            // 
            // ogretmemad
            // 
            this.ogretmemad.Location = new System.Drawing.Point(1014, 78);
            this.ogretmemad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogretmemad.Name = "ogretmemad";
            this.ogretmemad.Size = new System.Drawing.Size(112, 32);
            this.ogretmemad.TabIndex = 9;
            // 
            // ogrtmensoyad
            // 
            this.ogrtmensoyad.Location = new System.Drawing.Point(1014, 136);
            this.ogrtmensoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrtmensoyad.Name = "ogrtmensoyad";
            this.ogrtmensoyad.Size = new System.Drawing.Size(112, 32);
            this.ogrtmensoyad.TabIndex = 10;
            // 
            // ogretmenkullanici
            // 
            this.ogretmenkullanici.Location = new System.Drawing.Point(1014, 205);
            this.ogretmenkullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogretmenkullanici.Name = "ogretmenkullanici";
            this.ogretmenkullanici.Size = new System.Drawing.Size(112, 32);
            this.ogretmenkullanici.TabIndex = 11;
            // 
            // ogretmenekle
            // 
            this.ogretmenekle.Location = new System.Drawing.Point(784, 345);
            this.ogretmenekle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogretmenekle.Name = "ogretmenekle";
            this.ogretmenekle.Size = new System.Drawing.Size(108, 29);
            this.ogretmenekle.TabIndex = 12;
            this.ogretmenekle.Text = "EKLE";
            this.ogretmenekle.UseVisualStyleBackColor = true;
            this.ogretmenekle.Click += new System.EventHandler(this.ogretmenekle_Click);
            // 
            // ogrtmensil
            // 
            this.ogrtmensil.Location = new System.Drawing.Point(956, 345);
            this.ogrtmensil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrtmensil.Name = "ogrtmensil";
            this.ogrtmensil.Size = new System.Drawing.Size(108, 29);
            this.ogrtmensil.TabIndex = 13;
            this.ogrtmensil.Text = "SİL";
            this.ogrtmensil.UseVisualStyleBackColor = true;
            this.ogrtmensil.Click += new System.EventHandler(this.ogrtmensil_Click);
            // 
            // ogrtmnguncel
            // 
            this.ogrtmnguncel.Location = new System.Drawing.Point(1130, 348);
            this.ogrtmnguncel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrtmnguncel.Name = "ogrtmnguncel";
            this.ogrtmnguncel.Size = new System.Drawing.Size(108, 29);
            this.ogrtmnguncel.TabIndex = 14;
            this.ogrtmnguncel.Text = "GÜNCELLE";
            this.ogrtmnguncel.UseVisualStyleBackColor = true;
            this.ogrtmnguncel.Click += new System.EventHandler(this.ogrtmnguncel_Click);
            // 
            // wiwevogrtmn
            // 
            this.wiwevogrtmn.AllowUserToAddRows = false;
            this.wiwevogrtmn.AllowUserToDeleteRows = false;
            this.wiwevogrtmn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wiwevogrtmn.Location = new System.Drawing.Point(756, 385);
            this.wiwevogrtmn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wiwevogrtmn.Name = "wiwevogrtmn";
            this.wiwevogrtmn.ReadOnly = true;
            this.wiwevogrtmn.RowHeadersWidth = 51;
            this.wiwevogrtmn.RowTemplate.Height = 24;
            this.wiwevogrtmn.Size = new System.Drawing.Size(650, 441);
            this.wiwevogrtmn.TabIndex = 15;
            this.wiwevogrtmn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wiwevogrtmn_CellContentClick);
            this.wiwevogrtmn.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.wiwevogrtmn_CellEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(588, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "MEMUR EKRANI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sınıfı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(844, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sınıfı";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bolumu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(844, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bolumu";
            // 
            // ogrencıBolumu
            // 
            this.ogrencıBolumu.FormattingEnabled = true;
            this.ogrencıBolumu.Items.AddRange(new object[] {
            "Bilgisayar Müh",
            "Elektrik Elektronik Müh",
            "Makine Müh"});
            this.ogrencıBolumu.Location = new System.Drawing.Point(129, 300);
            this.ogrencıBolumu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrencıBolumu.Name = "ogrencıBolumu";
            this.ogrencıBolumu.Size = new System.Drawing.Size(136, 28);
            this.ogrencıBolumu.TabIndex = 25;
            this.ogrencıBolumu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ogretmenBolum
            // 
            this.ogretmenBolum.FormattingEnabled = true;
            this.ogretmenBolum.Items.AddRange(new object[] {
            "Bilgisayar Müh",
            "Elektrik Elektronik Müh",
            "Makine Müh"});
            this.ogretmenBolum.Location = new System.Drawing.Point(1014, 296);
            this.ogretmenBolum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogretmenBolum.Name = "ogretmenBolum";
            this.ogretmenBolum.Size = new System.Drawing.Size(136, 28);
            this.ogretmenBolum.TabIndex = 26;
            // 
            // ogrenciSinifi
            // 
            this.ogrenciSinifi.FormattingEnabled = true;
            this.ogrenciSinifi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ogrenciSinifi.Location = new System.Drawing.Point(129, 249);
            this.ogrenciSinifi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciSinifi.Name = "ogrenciSinifi";
            this.ogrenciSinifi.Size = new System.Drawing.Size(136, 28);
            this.ogrenciSinifi.TabIndex = 27;
            // 
            // ogretmenSinifi
            // 
            this.ogretmenSinifi.FormattingEnabled = true;
            this.ogretmenSinifi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ogretmenSinifi.Location = new System.Drawing.Point(1014, 252);
            this.ogretmenSinifi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogretmenSinifi.Name = "ogretmenSinifi";
            this.ogretmenSinifi.Size = new System.Drawing.Size(136, 28);
            this.ogretmenSinifi.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 71);
            this.button1.TabIndex = 29;
            this.button1.Text = "Atama Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memurEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 841);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ogretmenSinifi);
            this.Controls.Add(this.ogrenciSinifi);
            this.Controls.Add(this.ogretmenBolum);
            this.Controls.Add(this.ogrencıBolumu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wiwevogrtmn);
            this.Controls.Add(this.ogrtmnguncel);
            this.Controls.Add(this.ogrtmensil);
            this.Controls.Add(this.ogretmenekle);
            this.Controls.Add(this.ogretmenkullanici);
            this.Controls.Add(this.ogrtmensoyad);
            this.Controls.Add(this.ogretmemad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridwiewogrenci);
            this.Controls.Add(this.ogrenciguncelle);
            this.Controls.Add(this.ogrencisil);
            this.Controls.Add(this.ogrenciekle);
            this.Controls.Add(this.ogrnciSoyad);
            this.Controls.Add(this.ogrnciAd);
            this.Controls.Add(this.ogrnciNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "memurEkrani";
            this.Text = "memurekran";
            this.Load += new System.EventHandler(this.memurekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridwiewogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiwevogrtmn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ogrnciNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ogrnciAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ogrnciSoyad;
        private System.Windows.Forms.Button ogrenciekle;
        private System.Windows.Forms.Button ogrencisil;
        private System.Windows.Forms.Button ogrenciguncelle;
        private System.Windows.Forms.DataGridView gridwiewogrenci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ogretmemad;
        private System.Windows.Forms.TextBox ogrtmensoyad;
        private System.Windows.Forms.TextBox ogretmenkullanici;
        private System.Windows.Forms.Button ogretmenekle;
        private System.Windows.Forms.Button ogrtmensil;
        private System.Windows.Forms.Button ogrtmnguncel;
        private System.Windows.Forms.DataGridView wiwevogrtmn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ogrencıBolumu;
        private System.Windows.Forms.ComboBox ogretmenBolum;
        private System.Windows.Forms.ComboBox ogrenciSinifi;
        private System.Windows.Forms.ComboBox ogretmenSinifi;
        private System.Windows.Forms.Button button1;
    }
}