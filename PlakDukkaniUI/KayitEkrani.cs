using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlakDukkaniUI
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
