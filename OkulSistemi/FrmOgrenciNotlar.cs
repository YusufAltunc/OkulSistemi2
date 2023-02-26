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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=YUSUF\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dersad,sınav1,sınav2,sınav3,proje,ortalama,durum FROM TBLNOTLAR INNER JOIN  TBLDERSLER ON TBLNOTLAR.dersid = TBLDERSLER.dersid WHERE ogrid = @p1", baglantı);
            cmd.Parameters.AddWithValue("@p1", numara);
            //this.Text=numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
    }
}
