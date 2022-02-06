using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabanı.Classes;

namespace VeriTabanı
{
    public partial class notGirisEkrani : Form
    {
        public notGirisEkrani()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tNot t = new tNot();
            t.ogrenciID = Convert.ToInt32(txtOgrenci.Text);
            t.vize = Convert.ToInt32(txtVize.Text);
            t.final = Convert.ToInt32(txtFinal.Text);
            t.dersID = Convert.ToInt32(txtDersKod.Text);
            Baglanti.db.tNot.Add(t);
            Baglanti.db.SaveChanges();
            MessageBox.Show("Not Girişi Başarılı", "Sistem Bilgilendirme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        void liste()
        {
            dataGridView1.DataSource = Baglanti.db.tNot.ToList();
        }
        private void notGirisEkrani_Load(object sender, EventArgs e)
        {
            liste();
        }
    }
}
