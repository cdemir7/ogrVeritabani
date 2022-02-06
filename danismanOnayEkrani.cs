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
    public partial class danismanOnayEkrani : Form
    {
        public danismanOnayEkrani()
        {
            InitializeComponent();
        }

        void Liste()
        {
            SqlDataAdapter ad = new SqlDataAdapter("Select * from TDersKayit where Durum=0",Baglanti.bgl);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
        }
        private void danismanOnayEkrani_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int a = Convert.ToInt32(txtDersKod.Text);
                int c = Convert.ToInt32(txtOgrenci.Text);
                var x = Baglanti.db.TDersKayit.Where(b => b.Ders == a && b.Ogrenci == c).Select(m => m.ID).FirstOrDefault();
                var n = Baglanti.db.TDersKayit.Find(x);
                n.Durum = true;
                Baglanti.db.SaveChanges();
                MessageBox.Show("Ders Başarıyla Onaylandı");
                Liste();
            }
            else
            {
                MessageBox.Show("Lütfen Önce 'Onaylandı' Kutucuğunu İşaretleyiniz");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrenci.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string durum = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (durum == "False")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;

            }
        }
    }
}
