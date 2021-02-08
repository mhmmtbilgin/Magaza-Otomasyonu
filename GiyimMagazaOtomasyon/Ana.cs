using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiyimMagazaOtomasyon
{
    public partial class Ana : Form
    {
        public Ana()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminGiris admin = new AdminGiris();
            admin.Show();
        }
    }
}

  
