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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FFC2PST\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kisiler where hesapno=@p1 and SIFRE=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı bilgi!");
            }
            baglanti.Close();
        }
    }
}
