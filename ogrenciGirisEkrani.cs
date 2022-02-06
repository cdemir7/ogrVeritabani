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
    public partial class ogrenciGirisEkrani : Form
    {
        public ogrenciGirisEkrani()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        ogrenciEkrani ogr;
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.bgl.Open();
            cmd = new SqlCommand("SELECT * FROM tOgrenci where KullaniciAdi=@kullaniciAdi AND Sifre=@sifre", Baglanti.bgl);
            cmd.Parameters.AddWithValue("@kullaniciAdi", ogrenciad.Text);
            cmd.Parameters.AddWithValue("@sifre", ogrencisifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                CacheHelper.OgrenciID = Convert.ToInt32(dr[0]);
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                ogr = new ogrenciEkrani();
                ogr.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            dr.Close();
            Baglanti.bgl.Close();
        }
    }
}
