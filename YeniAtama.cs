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
    public partial class YeniAtama : Form
    {
        public YeniAtama()
        {
            InitializeComponent();
        }
        void Liste()
        {
            SqlDataAdapter ad = new SqlDataAdapter("Select * from tBolum",Baglanti.bgl);
            DataTable t = new DataTable();
            ad.Fill(t);
            dataGridView1.DataSource = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tBolum t = new tBolum();
            t.Sinif = Convert.ToInt32(textBox2.Text);
            t.Ogretmen = Convert.ToInt32(textBox3.Text);
            t.bolumAd = textBox1.Text;
            Baglanti.db.tBolum.Add(t);
            Baglanti.db.SaveChanges();
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            var x = Baglanti.db.tBolum.Find(id);
            x.Ogretmen= Convert.ToInt32(textBox3.Text);
            x.Sinif= Convert.ToInt32(textBox2.Text);
            x.bolumAd = textBox1.Text;
            Baglanti.db.SaveChanges();
            Liste();
        }

        private void YeniAtama_Load(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            var x = Baglanti.db.tBolum.Find(id);
            Baglanti.db.tBolum.Remove(x);
            Baglanti.db.SaveChanges();
            Liste();
        }
    }
}
