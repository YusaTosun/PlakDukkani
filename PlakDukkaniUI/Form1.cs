namespace PlakDukkaniUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitEkrani kayit = new();
            kayit.Show();
            this.Hide();
        }
    }
}