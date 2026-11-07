namespace sicaklik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            string deger = txtGiris.Text;

            if (int.TryParse(deger, out int celcius))
            {
                int fah = celcius * 9 / 5 + 32;
                lblFah.Text = $"{fah}";
            }
            else
            {
                lblFah.Text = "Hatalı giriş yaptınız";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtGiris.Clear();
            lblFah.Text = "xx";
        }
    }
}
