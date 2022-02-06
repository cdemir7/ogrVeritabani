using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VeriTabanı.Classes;

namespace VeriTabanı
{
    public partial class memurEkrani : Form
    {
        SqlCommand komut;
        SqlDataAdapter da;




        public memurEkrani()
        {
            InitializeComponent();
        }

        void OgrenciGetir()
        {
            da = new SqlDataAdapter("SELECT *FROM tOgrenci", Baglanti.bgl);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridwiewogrenci.DataSource = tablo;
        }

        void OgretmenGetir()
        {
            da = new SqlDataAdapter("SELECT *FROM tOgretmen", Baglanti.bgl);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            wiwevogrtmn.DataSource = tablo;
        }

        private void memurekran_Load(object sender, EventArgs e)
        {
            OgrenciGetir();
            OgretmenGetir();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gridwiewogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void wiwevogrtmn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ogrenciguncelle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("UPDATE tOgrenci SET ad = @ad, soyad = @soyad, bolumAd = @bolumAd, sinif = @sinif WHERE ogrenciID = @ogrenciID", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogrenciID", Convert.ToInt32(ogrnciNo.Text));
            komut.Parameters.AddWithValue("@ad", ogrnciAd.Text);
            komut.Parameters.AddWithValue("@soyad", ogrnciSoyad.Text);
            komut.Parameters.AddWithValue("@bolumAd", ogrencıBolumu.Text);
            komut.Parameters.AddWithValue("@sinif", ogrenciSinifi.Text);
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgrenciGetir();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridwiewogrenci_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ogrnciNo.Text = gridwiewogrenci.CurrentRow.Cells[0].Value.ToString();
            ogrnciAd.Text = gridwiewogrenci.CurrentRow.Cells[1].Value.ToString();
            ogrnciSoyad.Text = gridwiewogrenci.CurrentRow.Cells[2].Value.ToString();
            ogrenciSinifi.Text = gridwiewogrenci.CurrentRow.Cells[4].Value.ToString();
            ogrencıBolumu.Text = gridwiewogrenci.CurrentRow.Cells[3].Value.ToString();
        }

        private void ogrenciekle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("INSERT INTO tOgrenci(ogrenciID,ad,soyad,bolumAd,sinif) VALUES (@ogrenciID,@ad,@soyad,@bolumAd,@sinif)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogrenciID", ogrnciNo.Text);
            komut.Parameters.AddWithValue("@ad", ogrnciAd.Text);
            komut.Parameters.AddWithValue("@soyad", ogrnciSoyad.Text);
            komut.Parameters.AddWithValue("@sinif", ogrenciSinifi.Text);
            komut.Parameters.AddWithValue("@bolumAd", ogrencıBolumu.Text);
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgrenciGetir();
        }

        private void ogrencisil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("DELETE from tOgrenci WHERE ogrenciID = @ogrenciID", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogrenciID", Convert.ToInt32(ogrnciNo.Text));
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgrenciGetir();
        }

        private void ogretmenekle_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("INSERT INTO tOgretmen(ogretmenID,ad,soyad,bolumAd,sinif) VALUES (@ogretmenID,@ad,@soyad,@bolumAd,@sinif)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogretmenID", ogretmenkullanici.Text);
            komut.Parameters.AddWithValue("@ad", ogretmemad.Text);
            komut.Parameters.AddWithValue("@soyad", ogrtmensoyad.Text);
            komut.Parameters.AddWithValue("@sinif", ogretmenSinifi.Text);
            komut.Parameters.AddWithValue("@bolumAd", ogretmenBolum.Text);
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgretmenGetir();
        }

        private void ogrtmensil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("DELETE from tOgretmen WHERE ogretmenID = @ogretmenID", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogretmenID", Convert.ToInt32(ogretmenkullanici.Text));
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgretmenGetir();
        }

        private void ogrtmnguncel_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand("UPDATE tOgretmen SET ad = @ad, soyad = @soyad, bolumAd = @bolumAd, sinif = @sinif WHERE ogretmenID = @ogretmenID", Baglanti.bgl );
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@ogretmenID", Convert.ToInt32(ogretmenkullanici.Text));
            komut.Parameters.AddWithValue("@ad", ogretmemad.Text);
            komut.Parameters.AddWithValue("@soyad", ogrtmensoyad.Text);
            komut.Parameters.AddWithValue("@bolumAd", ogretmenBolum.Text);
            komut.Parameters.AddWithValue("@sinif", ogretmenSinifi.Text);
            komut.ExecuteNonQuery();
            Baglanti.bgl.Close();
            OgretmenGetir();
        }

        private void wiwevogrtmn_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ogretmemad.Text = wiwevogrtmn.CurrentRow.Cells[1].Value.ToString();
            ogrtmensoyad.Text = wiwevogrtmn.CurrentRow.Cells[2].Value.ToString();
            ogretmenkullanici.Text = wiwevogrtmn.CurrentRow.Cells[0].Value.ToString();
            ogretmenSinifi.Text = wiwevogrtmn.CurrentRow.Cells[4].Value.ToString();
            ogretmenBolum.Text = wiwevogrtmn.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniAtama t = new YeniAtama();
            t.Show();
        }
    }
}
