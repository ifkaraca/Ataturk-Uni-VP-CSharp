using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms_giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtVize.Text,out double vize) || !double.TryParse(txtFinal.Text,out double final))
            {
                MessageBox.Show("Lütfen numerik giriş yapın");
                return;
            }
            if(vize<0||vize>100||final<0||final>100)
            {
                MessageBox.Show("Lütfen 0-100 arasında bir değer giriniz");
                return;
            }
            double ortalama = 0.40 * vize + 0.60 * final;
            lblOrtalama.Text = ortalama.ToString("F2");
            lblDurum.Text = ortalama >= 50 ? "Geçti" : "Kaldı";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtVize.Clear();
            txtFinal.Clear();
            lblOrtalama.Text = "-";
            lblDurum.Text = "-";
            txtVize.Focus();
        }
    }
}
