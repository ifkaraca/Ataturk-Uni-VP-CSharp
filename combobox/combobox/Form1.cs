using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {

        string meyve1 = "Elma";
        string meyve2 = "Armut";
        string meyve3 = "Muz";
        string meyve4 = "Çilek";

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(meyve1);
            comboBox1.Items.Add(meyve2);
            comboBox1.Items.Add(meyve3);
            comboBox1.Items.Add(meyve4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
