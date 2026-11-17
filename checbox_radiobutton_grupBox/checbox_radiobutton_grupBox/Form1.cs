using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checbox_radiobutton_grupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int total = 500;
        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = $"Teslimat bedeli: 40TL";
            radioButton1.Checked = true;
            label2.Text = $"{total} TL";
            label3.Text = $"Toplam: {total}TL";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                total += 30;
            else
                total -= 30;

            label3.Text = $"Toplam: {total}TL";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                total += 40;
                label4.Text = "Teslimat bedeli: 40 TL";
            }
            else
            {
                total -= 40;
            }

            label3.Text = $"Toplam: {total} TL";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                total += 90;
                label4.Text = "Teslimat bedeli: 90 TL";
            }
            else
            {
                total -= 90;
            }

            label3.Text = $"Toplam: {total} TL";
        }
    }
}
