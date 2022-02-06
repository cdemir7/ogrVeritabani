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
    public partial class notGoruntulemeEkrani : Form
    {
        public notGoruntulemeEkrani()
        {
            InitializeComponent();
        }

        private void notGoruntule_Load(object sender, EventArgs e)
        {
            if (CacheHelper.OgrenciID != 0 && CacheHelper.OgrenciID > 0)
            {
                var x = Baglanti.db.tOgrenci.Where(b => b.ogrenciID == CacheHelper.OgrenciID).Select(n => n.ad + " " + n.soyad).FirstOrDefault();
                ogrenciNo.Text = x.ToString();
                ogrenciNo.Enabled = false;
            }
        }

        private void ogrenciArama_Click(object sender, EventArgs e)
        {
            var x = Baglanti.db.tOgrenci.Where(b => b.ad + " " + b.soyad == ogrenciNo.Text).Select(n => n.ogrenciID).FirstOrDefault();
            notGoruntuleGrid.DataSource = Baglanti.db.tNot.Where(b => b.ogrenciID == x).ToList();
        }
    }
}
