using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//DERSLERİN SQL İLE SİLME EKLEME İŞLERİNİ DATASET İLE YAPTIK.
namespace OkulSistemi
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightBlue;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtdersad.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders Silme İşlemi Yapılmıştır.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(txtdersad.Text,byte.Parse(txtdersid.Text));
            MessageBox.Show("Ders Guncelleme İşlemi Yapılmıştır.");
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdersid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
