using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeriTabanı.Classes;

namespace VeriTabanı
{
    public partial class dersKayitEkrani : Form
    {
        public dersKayitEkrani()
        {
            InitializeComponent();
        }

        private void dersVerisi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void DersListe()
        {
            SqlDataAdapter ad = new SqlDataAdapter("Select * from tDers", Baglanti.bgl);
            DataTable t = new DataTable();
            ad.Fill(t);
            dersVerisi.DataSource = t;
        }
        void DersKayit()
        {
            dersKayitGrid.DataSource = Baglanti.db.TDersKayit.Where(b => b.Ogrenci == CacheHelper.OgrenciID && b.Durum == false).ToList();
        }
        void Onaylanan()
        {
            dataGridView1.DataSource = Baglanti.db.TDersKayit.Where(b => b.Ogrenci == CacheHelper.OgrenciID && b.Durum == true).ToList();
        }

        private void dersKayit_Load(object sender, EventArgs e)
        {
            DersListe();
            DersKayit();
            Onaylanan();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dersEkle_Click(object sender, EventArgs e)
        {
            TDersKayit t = new TDersKayit();
            var c = Baglanti.db.tDers.Where(b => b.dersAd == textBox1.Text).Select(n => n.dersID).FirstOrDefault();
            var kayitlar = Baglanti.db.TDersKayit.Where(b => b.Ders == c).Select(b => b.ID).FirstOrDefault();
            if (kayitlar > 0)
            {
                MessageBox.Show("Bu Derse Zaten Kayıt Oldunuz");
            }
            else
            {
                t.Ders = c;
                t.Ogrenci = CacheHelper.OgrenciID;
                Baglanti.db.TDersKayit.Add(t);
                Baglanti.db.SaveChanges();
                DersKayit();
            }


        }
    }
}
