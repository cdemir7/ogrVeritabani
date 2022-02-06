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
    public partial class ogretmenEkrani : Form
    {
        public ogretmenEkrani()
        {
            InitializeComponent();
        }

        private void dersonay_Click(object sender, EventArgs e)
        {
            danismanOnayEkrani o = new danismanOnayEkrani();
            o.Show();
        }

        private void notgrs_Click(object sender, EventArgs e)
        {
            notGirisEkrani t = new notGirisEkrani();
            t.Show();
        }
    }
}
