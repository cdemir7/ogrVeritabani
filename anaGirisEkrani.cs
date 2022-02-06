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

namespace VeriTabanı
{
    public partial class anaGirisEkrani : Form
    {
        
        public anaGirisEkrani()
        {
            InitializeComponent();
        }
        memurGirisEkrani memurLogin;
        ogretmenGirisEkrani ogretmenLogin;
        ogrenciGirisEkrani ogrenciLogin;
        
       
        private void memurbtn_Click(object sender, EventArgs e)
        {
            memurLogin = new memurGirisEkrani();
            memurLogin.ShowDialog();            
        }

        private void ogrtmnbtn_Click(object sender, EventArgs e)
        {
            ogretmenLogin = new ogretmenGirisEkrani();
            ogretmenLogin.ShowDialog();
            
        }

        private void ogrncibtn_Click(object sender, EventArgs e)
        {
            ogrenciLogin = new ogrenciGirisEkrani();
            ogrenciLogin.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
