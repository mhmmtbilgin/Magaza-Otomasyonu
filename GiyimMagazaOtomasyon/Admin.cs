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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
       
        private void Admin_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT admin_id, admin_adi, admin_telefon from admin_bilgi", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
                      
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
              {
                  int secilen = dataGridView1.SelectedCells[0].RowIndex;
                  txtAdminid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                  txtAdminAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                  txtadminTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
              }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into admin_bilgi (admin_id,admin_adi,admin_soyadi,admin_telefon,admin_adres,admin_sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdminid.Text);
            komut.Parameters.AddWithValue("@p2", txtAdminAd.Text);
            komut.Parameters.AddWithValue("@p3", txtAdminSoyAd.Text);
            komut.Parameters.AddWithValue("@p4", txtadminTel.Text);
            komut.Parameters.AddWithValue("@p5", txtAdminAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtAdminSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklenmiştir");
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from admin_bilgi where admin_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdminid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Silinmiştir");
        }

        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update admin_bilgi set  admin_adi=@p2, admin_soyadi=@p3, admin_telefon=@p4,admin_adres=@p5, admin_sifre=@p6  where admin_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdminid.Text);
            komut.Parameters.AddWithValue("@p2", txtAdminAd.Text);
            komut.Parameters.AddWithValue("@p3", txtAdminSoyAd.Text);
            komut.Parameters.AddWithValue("@p4", txtadminTel.Text);
            komut.Parameters.AddWithValue("@p5", txtAdminAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtAdminSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Güncellenmiştir");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
