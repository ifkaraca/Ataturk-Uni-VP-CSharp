using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int sayi))
            {
                MessageBox.Show("Hatalı giriş");
            }
            else
            {
                if (sayi >= 0 && sayi <= 12)
                {
                    int sonuc = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        sonuc = sonuc * i;
                    }
                    if (sonuc < 1000)
                    {
                        label1.Text = $"{sayi}! = {sonuc} (küçük)";
                    }
                    else
                    {
                        label1.Text = $"{sayi}! = {sonuc} (büyük)";
                    }
                }
                else
                {
                    MessageBox.Show("0-12 arasıdna olmalıdır");
                }
            }
        }
    }
}
