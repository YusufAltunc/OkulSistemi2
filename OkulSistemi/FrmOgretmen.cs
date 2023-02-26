using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup  frm = new FrmKulup();
            frm.Show();
        }

        private void btnogretmen_Click(object sender, EventArgs e)
        {

        }

        private void btndersislemleri_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();
            frm.Show();
        }

        private void btnogrenciislemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmm = new FrmOgrenci();
            frmm.Show();
        }

        private void btnsınavnot_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm = new FrmSinavNotlar();
            frm.Show();
        }
    }
}
