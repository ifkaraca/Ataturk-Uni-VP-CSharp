namespace WinFormsApp1
{
    public partial class sa : Form
    {
        public sa()
        {
            InitializeComponent();
        }

        private void sa_Load(object sender, EventArgs e)
        {

        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mal");

        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            string yas = txtYas.Text;
            if(int.TryParse(yas,out int dyas))
            {
                label1.Text = $"Yaş: {dyas}";
            }
            else
            {
                label1.Text = $"yanlış giriş";
            }
        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
