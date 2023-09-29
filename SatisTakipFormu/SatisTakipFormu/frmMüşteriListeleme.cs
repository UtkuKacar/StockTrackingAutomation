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
    public partial class frmMüşteriListeleme : Form
    {
        public frmMüşteriListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True"); //SQL bağlantısı
        DataSet ds = new DataSet(); //Kayıtları geçici olarak tutmak için
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMüşteriListeleme_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void KayitGoster()
        { //datagrid de bilgileri göstermesi için
            baglanti.Open(); //Bağlantı aç
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Müşteri", baglanti); //Kayıtları Listele
            sqlDataAdapter.Fill(ds, "Müşteri");
            dataGridView1.DataSource = ds.Tables["Müşteri"];
            baglanti.Close(); //Bağlantı kapat
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//datagrid de listelenen bilgiye tıklayınca textboxlara gelmesi için
            txtTC.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEMail.Text = dataGridView1.CurrentRow.Cells["EMail"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        { //Müşteri bilgilerini güncelleme
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Müşteri set AdSoyad = @AdSoyad, Telefon = @Telefon, Adres = @Adres, EMail = @EMail where TC = @TC", baglanti);
            cmd.Parameters.AddWithValue("@TC", txtTC.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
            cmd.Parameters.AddWithValue("@EMail", txtEMail.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["Müşteri"].Clear();
            KayitGoster();
            MessageBox.Show("MÜŞTERİ KAYDI BAŞARIYLA GÜNCELLENDİ.");

            foreach (Control item in this.Controls)  //Textboxları silmesi için
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        { //Müşteriyi silme
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from Müşteri where TC = '" + dataGridView1.CurrentRow.Cells["TC"].Value.ToString() + "'", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            ds.Tables["Müşteri"].Clear();
            KayitGoster();
            MessageBox.Show("MÜŞTERİ KAYDI BAŞARIYLA SİLİNDİ");
        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        { //TC ye göre müşteri arama
            DataTable dt = new DataTable();
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Müşteri where TC like '%"+ txtTCAra.Text +"%'",baglanti);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
    }
}
