using System.Data;
using System.Data.SqlClient;

namespace SatisTakipFormu
{
    public partial class frmSatýþ : Form
    {
        public frmSatýþ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Sepet", baglanti);
            da.Fill(ds, "Sepet");
            dataGridView1.DataSource = ds.Tables["Sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }

        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select sum(ToplamFiyatý) from Sepet", baglanti);
                lblGenelToplam.Text = cmd.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sepetListele();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüþteriEkleme ekle = new frmMüþteriEkleme();
            ekle.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMüþteriListeleme listele = new frmMüþteriListeleme();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori frmKategori = new frmKategori();
            frmKategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka frmMarka = new frmMarka();
            frmMarka.ShowDialog();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Müþteri where TC like '" + txtTC.Text + "' ", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtAdSoyad.Text = reader["AdSoyad"].ToString();
                txtTelefon.Text = reader["Telefon"].ToString();
            }
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmÜrünListele listele = new frmÜrünListele();
            listele.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSatýþListele listele = new frmSatýþListele();
            listele.ShowDialog();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Ürün where BarkodNo like '" + txtBarkodNo.Text + "' ", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtÜrünAdý.Text = reader["UrunAdi"].ToString();
                txtSatýþFiyatý.Text = reader["SatisFiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        bool durum;

        private void BarkodKontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Sepet", baglanti);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (txtBarkodNo.Text == reader["BarkodNo"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyatý.Text = (double.Parse(txtSatýþFiyatý.Text) * double.Parse(txtMiktar.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtSatýþFiyatý_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyatý.Text = (double.Parse(txtSatýþFiyatý.Text) * double.Parse(txtMiktar.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            BarkodKontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Sepet(TC, AdSoyad, Telefon, BarkodNo, ÜrünAdý, Miktar, SatýþFiyatý, ToplamFiyatý, Tarih) values(@TC, @AdSoyad, @Telefon, @BarkodNo, @ÜrünAdý, @Miktar, @SatýþFiyatý, @ToplamFiyatý, @Tarih)", baglanti);
                cmd.Parameters.AddWithValue("@TC", txtTC.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@BarkodNo", txtBarkodNo.Text);
                cmd.Parameters.AddWithValue("@ÜrünAdý", txtÜrünAdý.Text);
                cmd.Parameters.AddWithValue("@Miktar", int.Parse(txtMiktar.Text));
                cmd.Parameters.AddWithValue("@SatýþFiyatý", double.Parse(txtSatýþFiyatý.Text));
                cmd.Parameters.AddWithValue("@ToplamFiyatý", double.Parse(txtToplamFiyatý.Text));
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd1 = new SqlCommand("update Sepet set Miktar = Miktar+ '" + int.Parse(txtMiktar.Text) + "'where BarkodNo = '" + txtBarkodNo.Text + "' ", baglanti);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("update Sepet set ToplamFiyatý = Miktar * SatýþFiyatý where BarkodNo = '" + txtBarkodNo.Text + "' ", baglanti);
                cmd2.ExecuteNonQuery();
                baglanti.Close();
            }

            txtMiktar.Text = "1";
            ds.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Sepet where BarkodNo = '" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "' ", baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ÜRÜN BAÞARI ÝLE SEPETTEN SÝLÝNDÝ.");
            ds.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();
        }

        private void btnSatýþÝptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Sepet", baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("ÜRÜNLER BAÞARI ÝLE SEPETTEN ÇIKARTILDI.");
            ds.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();
        }

        private void btnSatýþYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Satýþ(TC, AdSoyad, Telefon, BarkodNo, ÜrünAdý, Miktar, SatýþFiyatý, ToplamFiyatý, Tarih) values(@TC, @AdSoyad, @Telefon, @BarkodNo, @ÜrünAdý, @Miktar, @SatýþFiyatý, @ToplamFiyatý, @Tarih)", baglanti);
                cmd.Parameters.AddWithValue("@TC", txtTC.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                cmd.Parameters.AddWithValue("@BarkodNo", dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString());
                cmd.Parameters.AddWithValue("@ÜrünAdý", dataGridView1.Rows[i].Cells["ÜrünAdý"].Value.ToString());
                cmd.Parameters.AddWithValue("@Miktar", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));
                cmd.Parameters.AddWithValue("@SatýþFiyatý", double.Parse(dataGridView1.Rows[i].Cells["SatýþFiyatý"].Value.ToString()));
                cmd.Parameters.AddWithValue("@ToplamFiyatý", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyatý"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                SqlCommand cmd1 = new SqlCommand("update Ürün set Miktar = Miktar- '" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "' where BarkodNo = '" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", baglanti);
                cmd1.ExecuteNonQuery();
                baglanti.Close();
            }
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("delete from Sepet", baglanti);
            sqlCommand.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SATIÞ BAÞARILI.");
            ds.Tables["Sepet"].Clear();
            sepetListele();
            hesapla();



        }

        private void txtToplamFiyatý_TextChanged(object sender, EventArgs e)
        {

        }
    }
}