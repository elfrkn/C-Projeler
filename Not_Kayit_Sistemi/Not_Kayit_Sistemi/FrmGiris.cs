using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay frm = new FrmOgrenciDetay();
            frm.numara = MskNumara.Text;
            frm.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        } 

        private void MskNumara_TextChanged(object sender, EventArgs e)
        {

            if (MskNumara.Text == "1111")
            {
                FrmOgretmenDetay frm = new FrmOgretmenDetay();
                frm.Show();

            }
        }
    }
}
