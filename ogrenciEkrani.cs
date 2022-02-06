using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanı
{
    public partial class ogrenciEkrani : Form
    {
        public ogrenciEkrani()
        {
            InitializeComponent();
        }

        private void ogrenciEkrani_Load(object sender, EventArgs e)
        {

        }

        private void notgrntlme_Click(object sender, EventArgs e)
        {
            notGoruntulemeEkrani n = new notGoruntulemeEkrani();
            n.Show();
        }

        private void derskaydi_Click(object sender, EventArgs e)
        {
            dersKayitEkrani t = new dersKayitEkrani();
            t.Show();
        }
    }
}
