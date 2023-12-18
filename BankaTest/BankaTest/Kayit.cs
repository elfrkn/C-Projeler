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

namespace BankaTest
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbBankaTest;Integrated Security=True");

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtSifre.Text = "";
            MskHesapNo.Text = "";
            MskTC.Text = "";
            MskTelefon.Text = "";
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            int sayi =int.Parse( MskHesapNo.Text);
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti) ;
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", MskHesapNo.Text);         
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

          
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TBLHESAP (HESAPNO) values (@p1)",baglanti);
            komut2.Parameters.AddWithValue("@p1",MskHesapNo.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgileriniz Kaydedildi.");
            temizle();
        }

        private void BtnHesapNo_Click(object sender, EventArgs e)
        {


            
            Random rastgele = new Random();
            int sayi = rastgele.Next(100000,1000000);
            MskHesapNo.Text = sayi.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLHESAP ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                if(MskHesapNo.Text  == dr[0].ToString())
                {
                    MessageBox.Show("Bu Hesap Numarasi Onceden Alindi.Tekrar Dene!");
                }
            }

            baglanti.Close();



        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
