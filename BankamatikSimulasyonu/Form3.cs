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

namespace BankamatikSimulasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FFC2PST\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kisiler (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTcKimlik.Text);
            komut.Parameters.AddWithValue("@p4", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p6", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri bilgileri sisteme kaydedildi.");
        }

        private void BtnHesap_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000,1000000);
            mskHesapNo.Text = sayi.ToString();
        }

        private void MskTcKimlik_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
