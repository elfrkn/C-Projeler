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

namespace Veri_Tabanli_Parti_Secim_Istatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbSecimProje;Integrated Security=True");

        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtIlceAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtAParti.Text);
            komut.Parameters.AddWithValue("@P3", TxtBParti.Text);
            komut.Parameters.AddWithValue("@P4", TxtCParti.Text);
            komut.Parameters.AddWithValue("@P5", TxtDParti.Text);
            komut.Parameters.AddWithValue("@P6", TxtEParti.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy girisi gerceklesti.");



        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
