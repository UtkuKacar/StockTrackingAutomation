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
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UTKU;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void satisListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Satış", baglanti);
            da.Fill(ds, "Satış");
            dataGridView1.DataSource = ds.Tables["Satış"];
            baglanti.Close();
        }

        private void fmrSatışListele_Load(object sender, EventArgs e)
        {
            satisListele();
        }
    }
}
