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

namespace SatisTakipFormu
{
    public partial class frmMüşteriEkleme : Form
    {
        public frmMüşteriEkleme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True"); //SQL bağlantısı

        private void frmMüşteriEkleme_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Veri Tabanına ekleme
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Müşteri(TC, AdSoyad, Telefon, Adres, EMail) values(@TC, @AdSoyad, @Telefon, @Adres, @EMail)", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@EMail", txtEMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("MÜŞTERİ KAYDI BAŞARIYLA EKLENDİ.");

            foreach (Control item in this.Controls)  //Textboxları silmesi için
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
