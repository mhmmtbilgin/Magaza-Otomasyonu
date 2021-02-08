using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiyimMagazaOtomasyon
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public static string ad;
       
            private void button1_Click(object sender, EventArgs e)
        {
            ad = txtkAdi.Text;
            SqlCommand komut = new SqlCommand("Select * from admin_bilgi where admin_adi=@p1 and admin_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtkSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Sisteme Hoşgeldin  " + txtkAdi.Text);
                AdminIslem admin = new AdminIslem();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış girildi");
            } bgl.baglanti().Close();
        
        }

            private void label3_Click(object sender, EventArgs e)
            {

            }
    }
}
