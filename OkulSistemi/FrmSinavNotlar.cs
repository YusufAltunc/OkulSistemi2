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

namespace OkulSistemi
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtid.Text));
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DisplayMember = "dersad";
            cmbders.ValueMember = "dersid";
            cmbders.DataSource = dt;
            baglantı.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int notid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            notid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sinav1, sinav2, sinav3, proje;

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtsinav1.Clear();
            txtsinav2.Clear();
            txtsinav3.Clear();
            txtproje.Clear();
            txtortalama.Clear();
            txtdurum.Clear();
        }

        double ortalama;
        private void bthesapla_Click(object sender, EventArgs e)
        {
            
           // string durum;
            sinav1=Convert.ToInt16(txtsinav1.Text);
            sinav2 = Convert.ToInt16(txtsinav2.Text);
            sinav3 = Convert.ToInt16(txtsinav3.Text);
            proje = Convert.ToInt16(txtproje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtortalama.Text = ortalama.ToString();
            if(ortalama>=50)
            {
                txtdurum.Text = "True";
            }
            else
            {
                txtdurum.Text = "False";
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbders.SelectedValue.ToString()), int.Parse(txtid.Text), byte.Parse(txtsinav1.Text), byte.Parse(txtsinav2.Text), byte.Parse(txtsinav3.Text), byte.Parse(txtproje.Text), decimal.Parse(txtortalama.Text), bool.Parse(txtdurum.Text), notid);
        }
    }
}
