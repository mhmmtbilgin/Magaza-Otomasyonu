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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kullanici_Bilgi(kullanici_detay_id,kullanici_adi,kullanici_soyadi,kullanici_telefon,kullanici_adres,kullanici_sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciId.Text);
            komut.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciSoayd.Text);
            komut.Parameters.AddWithValue("@p4", txtKullanicTel.Text);
            komut.Parameters.AddWithValue("@p5", txtKullaniciAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtKullaniciSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklenmiştir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Kullanici_Bilgi where kullanici_detay_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Silinmiştir");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Update Kullanici_Bilgi set  kullanici_adi=@p2, kullanici_soyadi=@p3, kullanici_telefon=@p4,kullanici_adres=@p5, kullanici_sifre=@p6  where kullanici_detay_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciId.Text);
            komut.Parameters.AddWithValue("@p2", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciSoayd.Text);
            komut.Parameters.AddWithValue("@p4", txtKullanicTel.Text);
            komut.Parameters.AddWithValue("@p5", txtKullaniciAdres.Text);
            komut.Parameters.AddWithValue("@p6", txtKullaniciSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Güncellenmiştir");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKullaniciId.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                     txtKullanicTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
           
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT kullanici_detay_id, kullanici_adi, kullanici_telefon from Kullanici_Bilgi", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}
