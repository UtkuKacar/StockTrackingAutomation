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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;
        private void kategoriKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Kategoriler",baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()) {
                if (textBox1.Text == rdr["Kategori"].ToString() || textBox1.Text == " ")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Kategoriler(Kategori) values('" + textBox1.Text + "')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("KATEGORİ BAŞARI İLE EKLENDİ.");
            }
            else
            {
                MessageBox.Show("BÖYLE BİR KATEGORİ VAR" , "UYARI!");
            }
            textBox1.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
