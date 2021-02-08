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
    public partial class AnaModul : Form
    {


        public AnaModul()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("SELECT Stok.stok_urun_barkod, Cinsiyet.cinsiyet, Tur.tur, Beden.beden, Renk.renk, Stok.stok_urun_adeti, Stok.stok_urun_fiyati, Stok.stok_urun_tarihi FROM Stok INNER JOIN Beden ON Beden.beden_id=Stok.stok_beden_id INNER JOIN Renk ON Renk.renk_id = Stok.stok_renk_id" +
          " INNER JOIN Cinsiyet ON Cinsiyet.cinsiyet_id = Stok.stok_cinsiyet_id INNER JOIN Tur ON Tur.tur_id = Stok.stok_tur_id", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void AnaModul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Stok set stok_cinsiyet_id=@p2, stok_tur_id=@p3, stok_beden_id=@p4, stok_renk_id=@p5,stok_urun_adeti=@p6, stok_urun_fiyati=@p7  where stok_urun_barkod=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@p3", txtTur.Text);
            komut.Parameters.AddWithValue("@p4", mskBeden.Text);
            komut.Parameters.AddWithValue("@p5", txtRenk.Text);
            komut.Parameters.AddWithValue("@p6", txtAdet.Text);
            komut.Parameters.AddWithValue("@p7", txtFiyat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Kaydınız Güncellenmiştir");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Stok (stok_urun_barkod, stok_cinsiyet_id, stok_tur_id, stok_beden_id, stok_renk_id, stok_urun_adeti,stok_urun_fiyati, stok_urun_tarihi) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2", txtCinsiyet.Text);
            komut.Parameters.AddWithValue("@p3", txtTur.Text);
            komut.Parameters.AddWithValue("@p4", mskBeden.Text);
            komut.Parameters.AddWithValue("@p5", txtRenk.Text);
            komut.Parameters.AddWithValue("@p6", txtAdet.Text);
            komut.Parameters.AddWithValue("@p7", txtFiyat.Text);
            komut.Parameters.AddWithValue("@p8", dTime.Value.ToString("yyyy-MM-dd"));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Eklenmiştir");
            Listele();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Stok where stok_urun_barkod=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Silinmiştir");
            Listele();
        }


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBarkod.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtCinsiyet.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskBeden.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtRenk.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAdet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            dTime.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Istatistik frmIstatistik = new Istatistik();
            frmIstatistik.Show();
        }


        private void AnaModul_FormClosed(object sender, FormClosedEventArgs e)
        {
            Islemler islem = new Islemler();
            islem.Show();
            this.Hide();
        }
    }
}

                    
