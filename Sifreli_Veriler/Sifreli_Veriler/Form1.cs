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
namespace Sifreli_Veriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=Test;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLVERILER",baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["AD"] = sifrecoz(row["AD"] as string);
                row["SOYAD"] = sifrecoz(row["SOYAD"] as string);
                row["MAIL"] = sifrecoz(row["MAIL"] as string);
                row["SIFRE"] = sifrecoz(row["SIFRE"] as string);
                row["HESAPNO"] = sifrecoz(row["HESAPNO"] as string);

            }
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private object sifrecoz(string value)
        {
            byte[] cozum = Convert.FromBase64String(value);
            byte[] cozumturkce = Encoding.Convert(Encoding.UTF8,Encoding.ASCII, cozum);
            string sonuc = ASCIIEncoding.ASCII.GetString(cozumturkce);
            return sonuc;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = TxtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = TxtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = TxtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = TxtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = TxtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) VALUES (@p1,@p2,@p3,@p4,@p5)",baglanti);

            komut.Parameters.AddWithValue("@p1",adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi.");




        }

        private void Form1_Load(object sender, EventArgs e)
        {
           listele();
            //string adcozum = TxtAd.Text;
           // byte[] adcozumdizi = Convert.FromBase64String(adcozum);
           // string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);

           
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }
    }
}
