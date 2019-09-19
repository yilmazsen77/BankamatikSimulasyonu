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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string hesap;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FFC2PST\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiler where HESAPNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTcKimlikNo.Text = dr[3].ToString(); ;
                lblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Para gönderilen hesap bakiye artışı.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update hesap set bakiye=bakiye+@p1 where hesapno=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p2", mskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen hesabın bakiye güncellemesi.
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update hesap set bakiye-@k1 where hesapno=@k2", baglanti);
            komut2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@k2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem gerçekleşti.");

        }

        private void LblHesapNo_Click(object sender, EventArgs e)
        {

        }
    }
}
