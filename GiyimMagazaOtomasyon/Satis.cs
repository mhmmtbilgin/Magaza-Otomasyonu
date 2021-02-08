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
    public partial class Satis : Form
    {
       
        public Satis()
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
        private void Satis_Load(object sender, EventArgs e)
        {
            Listele();
            lblAd.Text = Giris.ad;
            
        }   
        private void btnSatis_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Satis (satis_urun_barkod, urun_adet, urun_fiyat, satis_tarihi, satisi_yapan) values (@p1, @p2, @p3, @p4, @p5)", bgl.baglanti());
            SqlCommand komut3 = new SqlCommand("Insert into Kasa (kasa_urun_barkod, urun_adet, urun_fiyat, tarih) values (@p1, @p2, @p3, @p4)", bgl.baglanti());
            SqlCommand komut2 = new SqlCommand("UPDATE Stok SET Stok.stok_urun_adeti = Stok.stok_urun_adeti - Satis.urun_adet FROM Stok Stok JOIN Satis Satis ON Satis.satis_urun_barkod = Stok.stok_urun_barkod ", bgl.baglanti());
            SqlCommand komut4 = new SqlCommand("UPDATE Kasa SET kasa_toplami = urun_adet * urun_fiyat", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut.Parameters.AddWithValue("@p2", txtAdet.Text);
            komut.Parameters.AddWithValue("@p3", txtFiyat.Text);
            komut.Parameters.AddWithValue("@p4", dTime.Value.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@p5", lblAd.Text);
            komut3.Parameters.AddWithValue("@p1", txtBarkod.Text);
            komut3.Parameters.AddWithValue("@p2", txtAdet.Text);
            komut3.Parameters.AddWithValue("@p3", txtFiyat.Text);
            komut3.Parameters.AddWithValue("@p4", dTime.Value.ToString("yyyy-MM-dd"));  
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery(); 
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            Listele();
            MessageBox.Show("Satış Eklenmiştir");
            
            
        }
        

        private void Satis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Islemler islem = new Islemler();
            islem.Show();
            this.Hide();
            
                        
        }
      
          
    }
}
