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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter(); 

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER",baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbkulup.DisplayMember = "kulupad";
            cmbkulup.ValueMember = "kulupid";
            cmbkulup.DataSource = dt;
            baglantı.Close();
        }
        string c = "";
        private void btnekle_Click(object sender, EventArgs e)
        {
            
            
            ds.OgrenciEkle(txtad.Text, txtsoyad.Text, byte.Parse(cmbkulup.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtid.Text));
            //Silme işleminde sıkıntı var.
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbkulup.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           // txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtad.Text, txtsoyad.Text, byte.Parse(cmbkulup.SelectedValue.ToString()), c, int.Parse(txtid.Text));
            MessageBox.Show("Öğrenci Kaydı Güncellenmiştir.");
            dataGridView1.DataSource = ds.OgrenciListesi();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(txtara.Text);
        }

       
    }
}
