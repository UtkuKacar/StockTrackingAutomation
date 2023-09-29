using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SatisTakipFormu
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;
        private void markaKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Markalar", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (comboBox1.Text == rdr ["Kategori"].ToString() && textBox2.Text == rdr["Marka"].ToString() || comboBox1.Text == " " || textBox2.Text == " ")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markaKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Markalar(Kategori, Marka) values('" + comboBox1.Text + "', '" + textBox2.Text + "')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("MARKA BAŞARI İLE EKLENDİ.");
            }
            else
            {
                MessageBox.Show("BÖYLE BİR KATEGORİ VE MARKA VAR" , "UYARI!");
            }
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategoriGtr();
        }

        private void KategoriGtr()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Kategoriler", baglanti);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
