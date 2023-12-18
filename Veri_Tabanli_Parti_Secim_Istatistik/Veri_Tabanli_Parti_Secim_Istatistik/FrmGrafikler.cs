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
using Microsoft.SqlServer.Server;

namespace Veri_Tabanli_Parti_Secim_Istatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            // ilce adlarini combobaxa cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT ILCEAD FROM TBLILCE",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbIlce.Items.Add(dr[0]);
            }
            baglanti.Close();

            //Grafige toplam sonuclari getirme

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE",baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTI", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTI", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTI", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTI", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTI", dr2[4]);
            }
            baglanti.Close();
        }

        private void CmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLILCE WHERE ILCEAD=@P1",baglanti);
            komut.Parameters.AddWithValue("@p1",CmbIlce.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                LblA.Text = dr[2].ToString();
                LblB.Text = dr[3].ToString();
                LblC.Text = dr[4].ToString();
                LblD.Text = dr[5].ToString();
                LblE.Text = dr[6].ToString();

            }
            baglanti.Close();
        }
    }
}
