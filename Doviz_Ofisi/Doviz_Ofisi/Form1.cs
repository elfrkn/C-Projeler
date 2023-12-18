using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;



namespace Doviz_Ofisi
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbDoviz;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);

            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            LblDolarAlis.Text = dolaralis;

            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            LblDolarSatis.Text = dolarsatis;

            string euroalis= xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblEuroAlis.Text = euroalis;

            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            LblEuroSatis.Text = eurosatis;
            ToplamPara();

        }

        void ToplamPara()
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDOVIZ",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

                LblToplamTL.Text = dr[1].ToString();
                LblToplamDolar.Text = dr[2].ToString();
                LblToplamEuro.Text = dr[3].ToString();
            }
            baglanti.Close();
        }

        private void BtnDolarAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarAlis.Text;
        }

        private void BtnDolarSatis_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarSatis.Text;
        }

        private void BtnEuroAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroAlis.Text;
        }

        private void BtnEuroSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroSatis.Text;
        }

        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(TxtKur.Text);
            miktar = Convert.ToDouble(TxtMiktar.Text);
            tutar = kur * miktar;
            TxtTutar.Text = tutar.ToString();

            

           
             
               
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLDOVIZ set TL=TL+@t,DOLAR=DOLAR-@m", baglanti);
                komut2.Parameters.AddWithValue("@t", Double.Parse(TxtTutar.Text));
                komut2.Parameters.AddWithValue("@m", Double.Parse(TxtMiktar.Text));
                komut2.ExecuteNonQuery();
               
                baglanti.Close();
                ToplamPara();

            


        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");
        }

        private void BtnSatisYap2_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(TxtKur.Text);
            miktar = Convert.ToInt32(TxtMiktar.Text);
            tutar =Convert.ToInt32(miktar / kur);
            TxtTutar.Text = tutar.ToString();
            int kalan,sonkalan;
            kalan =Convert.ToInt32 (kur*tutar);
            sonkalan = Convert.ToInt32(miktar - kalan);
            TxtKalan.Text = sonkalan.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
