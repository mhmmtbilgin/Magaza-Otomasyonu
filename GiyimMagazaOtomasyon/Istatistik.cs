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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void btnEnCokSatilan_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Top 20 satis_urun_barkod AS Urun_Barkod, SUM(urun_fiyat) AS Satilan_Urun_Adeti FROM Satis WHERE satis_tarihi >= '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND satis_tarihi <='" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' GROUP BY satis_urun_barkod ORDER BY Satilan_Urun_Adeti DESC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = "   EN ÇOK SATILAN ÜRÜN LİSTESİ";

        }

        private void Istatistik_Load(object sender, EventArgs e)
        {
            kasiyerAdi.Text = cmbKasiyer.Text;
            SqlCommand komut = new SqlCommand("select distinct satisi_yapan from Satis", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbKasiyer.Items.Add(dr["satisi_yapan"]);
            }
        }

        private void btnEnAzSatilan_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Top 20 satis_urun_barkod AS Urun_Barkod, SUM(urun_fiyat) AS Satilan_Urun_Adeti FROM Satis  WHERE satis_tarihi > '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND satis_tarihi <'" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' GROUP BY satis_urun_barkod ORDER BY Satilan_Urun_Adeti ASC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = "   EN AZ SATILAN ÜRÜN LİSTESİ";


        }

        private void btnEnCokKar_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Top 20 Satis.satis_urun_barkod AS Urun_Barkod, ((Satis.urun_fiyat-Stok.stok_urun_fiyati)*Satis.urun_adet) AS Kar_Tutarı FROM Satis Satis INNER JOIN Stok Stok ON Satis.satis_urun_barkod = Stok.stok_urun_barkod  WHERE satis_tarihi > '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND satis_tarihi <'" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' ORDER BY Kar_Tutarı DESC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = "EN ÇOK KAR EDEN ÜRÜN LİSTESİ";
        }

        private void btnEnCokZarar_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Top 20 Satis.satis_urun_barkod AS Urun_Barkod, ((Satis.urun_fiyat-Stok.stok_urun_fiyati)*Satis.urun_adet) AS Zarar_Tutarı FROM Satis Satis INNER JOIN Stok Stok ON Satis.satis_urun_barkod = Stok.stok_urun_barkod  WHERE satis_tarihi > '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND satis_tarihi <'" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' ORDER BY Zarar_Tutarı ASC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = " EN AZ KAR EDEN ÜRÜN LİSTESİ";
        }

        private void btnStokMiktar_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Top 20 stok_urun_barkod AS Urun_Barkod, stok_urun_adeti AS Stoktaki_Ürün_Adeti FROM Stok  WHERE stok_urun_tarihi > '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND stok_urun_tarihi <'" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' ORDER BY stok_urun_adeti ASC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = "       STOKTAKİ ÜRÜN LİSTESİ";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKasiyer_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Top 20 satis_urun_barkod, urun_adet, urun_fiyat, satis_tarihi from Satis where satisi_yapan= '" + cmbKasiyer.Text + "' and satis_tarihi >= '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND satis_tarihi <='" + dTimeSon.Value.ToString("yyyy-MM-dd") + "' ", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
            label1.Text = cmbKasiyer.Text + "'nin SATTIĞI ÜRÜNLER";

        }

        private void Başlangıç_Click(object sender, EventArgs e)
        {

        }

        private void cmbKasiyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select kullanici_telefon, kullanici_adres from Kullanici_Bilgi where kullanici_adi= '" + cmbKasiyer.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label8.Text = dr[0].ToString();
                label9.Text = dr[1].ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKasa_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select sum(kasa_toplami) as Kasa_Toplamı from Kasa WHERE tarih > '" + dTimeBas.Value.ToString("yyyy-MM-dd") + "' AND tarih <'" + dTimeSon.Value.ToString("yyyy-MM-dd")+"'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
    }
}