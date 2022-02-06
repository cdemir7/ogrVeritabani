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
    public partial class memurGirisEkrani : Form
    {
        SqlCommand cmd;
        public memurGirisEkrani()
        {
            InitializeComponent();
        }

        memurEkrani memurekran;
        private void memurgrsbtn_Click(object sender, EventArgs e)
        {
            //string sorgu = "SELECT * FROM tKullanici where kullaniciAdi=@kullaniciAdi AND sifre=@sifre";

            cmd = new SqlCommand("SELECT * FROM TMemurLogin where Kullanici=@kullaniciAdi AND Sifre=@sifre", Baglanti.bgl);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@kullaniciAdi", memurad.Text);
            cmd.Parameters.AddWithValue("@sifre", memursifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                memurekran = new memurEkrani();
                memurekran.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            dr.Close();
            Baglanti.bgl.Close();

        }

        private void memursifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void memurGirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
