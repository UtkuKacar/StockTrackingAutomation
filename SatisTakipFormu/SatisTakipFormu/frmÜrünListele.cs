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

namespace SatisTakipFormu
{
    public partial class frmÜrünListele : Form
    {
        public frmÜrünListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            KategoriGtr();
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Ürün", baglanti);
            sqlda.Fill(ds, "Ürün");
            dataGridView1.DataSource = ds.Tables["Ürün"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            Miktartxt.Text = dataGridView1.CurrentRow.Cells["Miktar"].Value.ToString();
            AlışFiyattxt.Text = dataGridView1.CurrentRow.Cells["AlisFiyati"].Value.ToString();
            SatışFiyattxt.Text = dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Ürün set UrunAdi = @UrunAdi, Miktar = @Miktar, AlisFiyati = @AlisFiyati, SatisFiyati = @SatisFiyati where BarkodNo = @BarkodNo", baglanti);
            cmd.Parameters.AddWithValue("@BarkodNo", BarkodNotxt.Text);
            cmd.Parameters.AddWithValue("@UrunAdi", ÜrünAdıtxt.Text);
            cmd.Parameters.AddWithValue("@Miktar", int.Parse(Miktartxt.Text));
            cmd.Parameters.AddWithValue("@AlisFiyati", double.Parse(AlışFiyattxt.Text));
            cmd.Parameters.AddWithValue("@SatisFiyati", double.Parse(SatışFiyattxt.Text));
            cmd.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["Ürün"].Clear();
            ÜrünListele();
            MessageBox.Show("ÜRÜN BAŞARI İLE GÜNCELLENDİ.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update Ürün set Kategori = @Kategori, Marka = @Marka where BarkodNo = @BarkodNo", baglanti);
                cmd.Parameters.AddWithValue("@BarkodNo", BarkodNotxt.Text);
                cmd.Parameters.AddWithValue("@Kategori", cmbKategori.Text);
                cmd.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("ÜRÜN BAŞARI İLE GÜNCELLENDİ.");
                ds.Tables["Ürün"].Clear();
                ÜrünListele();
            }

            else
            {
                MessageBox.Show("BARKOD NUMARASINI YAZIP TEKRAR DENEYİN!");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from Ürün where BarkodNo = '" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["Ürün"].Clear();
            ÜrünListele();
            MessageBox.Show("ÜRÜN KAYDI BAŞARIYLA SİLİNDİ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Ürün where BarkodNo like '%" + txtBarkodArama.Text + "%'", baglanti);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
