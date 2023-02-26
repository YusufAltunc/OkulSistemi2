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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKULUPLER", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("Insert into TBLKULUPLER (kulupad) values (@p1)", baglantı);
            cmd.Parameters.AddWithValue("@p1",txtkulupad.Text);
            cmd.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kulüp listeye eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Delete From TBLKULUPLER where kulupid=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1",txtkulupid.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kulup silme işlemi gercekleşmiştir");
            liste();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightYellow;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkulupid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkulupad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Update TBLKULUPLER Set kulupad=@p1 where kulupid=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1",txtkulupad.Text);
            komut.Parameters.AddWithValue("@p2",txtkulupid.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kulup Guncelleme işlemi gercekleşmiştir");
            liste();

        }
    }
}
