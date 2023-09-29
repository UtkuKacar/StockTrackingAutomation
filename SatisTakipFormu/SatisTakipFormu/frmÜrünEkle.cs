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
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");

        bool durum;
        private void barkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Ürün", baglanti);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (txtBarkodNo.Text == rdr["BarkodNo"].ToString() || txtBarkodNo.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnOlanaEkle_Click(object sender, EventArgs e)
        {

        }

        private void frmÜrünEkle_Load(object sender, EventArgs e)
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
                cmbKategori.Items.Add(reader["Kategori"].ToString());
            }
            baglanti.Close();
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            cmbMarka.Text = "";
            baglanti.Open();
            SqlCommand sqlCmd = new SqlCommand("select * from Markalar where Kategori = '" + cmbKategori.SelectedItem + "' ", baglanti);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                cmbMarka.Items.Add(reader["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into Ürün(BarkodNo, Kategori, Marka, UrunAdi, Miktar, AlisFiyati, SatisFiyati, Tarih) values(@BarkodNo, @Kategori, @Marka, @UrunAdi, @Miktar, @AlisFiyati, @SatisFiyati, @Tarih)", baglanti);
                sqlCommand.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                sqlCommand.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                sqlCommand.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                sqlCommand.Parameters.AddWithValue("@UrunAdi", txtÜrünAdı.Text);
                sqlCommand.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
                sqlCommand.Parameters.AddWithValue("@AlisFiyati", double.Parse(txtAlışFiyat.Text));
                sqlCommand.Parameters.AddWithValue("@SatisFiyati", double.Parse(txtSatışFiyat.Text));
                sqlCommand.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                sqlCommand.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("ÜRÜN BAŞARI İLE EKLENDİ.");
            }
            else
            {
                MessageBox.Show("BÖYLE BİR BARKOD MEVCUT" , "UYARI!");
            }


            cmbMarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "")
            {
                lblMiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is System.Windows.Forms.TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand sqlcmd = new SqlCommand("select * from Ürün where BarkodNo like '" + BarkodNotxt.Text + "' ", baglanti);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                Kategoritxt.Text = reader["Kategori"].ToString();
                Markatxt.Text = reader["Marka"].ToString();
                ÜrünAdıtxt.Text = reader["UrunAdi"].ToString();
                Miktartxt.Text = reader["Miktar"].ToString();
                AlışFiyattxt.Text = reader["AlisFiyati"].ToString();
                SatışFiyattxt.Text = reader["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnOlanaEkle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Ürün set Miktar = Miktar+ '"+int.Parse(Miktartxt.Text)+"' where BarkodNo = '"+BarkodNotxt.Text+"'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            
            foreach (Control item in groupBox2.Controls)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("ÜRÜN BAŞARI İLE GÜNCELLENDİ.");
        }
    }
}
