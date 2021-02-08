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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
            this.Hide();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            AnaModul ana = new AnaModul();
            ana.Show();
            this.Hide();
        }
    }
}
