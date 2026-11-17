using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparis
{
    public partial class Form1 : Form
    {
        private decimal GetProductPrice()
        {
            switch (comboBox1.SelectedItem?.ToString())
            {
                case "Book":
                    return 250m;
                case "Bag":
                    return 500m;
                case "Headphones":
                    return 800m;
                default:
                    return 0m;
            }
        }

        private decimal CalculateTotal(int quantity)
        {
            decimal total = GetProductPrice() * quantity;
            if(checkBox1.Checked)
            {
                total += 30m;
            }
            if(radioButton2.Checked)
            {
                total += 90m;
            }
            else if (radioButton1.Checked)
            {
                total += 40m;
            }

            return total;
        }

        private void UpdateTotal()
        {
            if(comboBox1.SelectedIndex == -1 || !int.TryParse(textBox1.Text,out int quantity) || quantity < 1 || quantity > 100)
            {
                label3.Text = "Geçersiz giriş";
                return;
            }
            decimal total = CalculateTotal(quantity);
            label3.Text = $"Toplam: {total:F2} TL";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[]
                {"Book","Bag","Headphones"});
            comboBox1.SelectedIndex = 0;
            textBox1.Text = "1";
            UpdateTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == -1 || !int.TryParse(textBox1.Text, out int q) || q<1 || q>100)
            {
                MessageBox.Show("Geçerli ürün ve adet giriniz");
                return;
            }

            decimal total = CalculateTotal(q);
            listBox1.Items.Add($"{comboBox1.SelectedItem} x {q} - {total:F2} TL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silinicek Ürünü seçin");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
