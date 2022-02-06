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
    public partial class ogretmenGirisEkrani : Form
    {
        SqlCommand cmd;
        public ogretmenGirisEkrani()
        {
            InitializeComponent();
        }

        ogretmenEkrani ogretmenekran;

        private void ogrtmnbtn_Click(object sender, EventArgs e)
        {
            Baglanti.bgl.Open();
            cmd = new SqlCommand("SELECT * FROM TOgretmenLogin where Kullanici=@kullaniciAdi AND Sifre=@sifre", Baglanti.bgl);
            cmd.Parameters.AddWithValue("@kullaniciAdi", ogrtmnad.Text);
            cmd.Parameters.AddWithValue("@sifre", ogrtmnsifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                ogretmenekran = new ogretmenEkrani();
                ogretmenekran.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            dr.Close();
            Baglanti.bgl.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ogretmenGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
