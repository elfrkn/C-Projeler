using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaTest
{
    public partial class Detay : Form
    {
        public Detay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbBankaTest;Integrated Security=True");
        public string hesapno;
       
        void data()
        {

            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT AD +' '+ SOYAD AS 'GONDEREN',TUTAR  FROM TBLHAREKET INNER JOIN TBLKISILER ON TBLHAREKET.GONDEREN=TBLKISILER.HESAPNO  where ALICI='"+hesapno+"' ", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT AD +' '+ SOYAD AS 'ALICI',TUTAR  FROM TBLHAREKET INNER JOIN TBLKISILER ON TBLHAREKET.ALICI=TBLKISILER.HESAPNO where GONDEREN='"+hesapno+"' ", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            baglanti.Close();
        }

        private void Detay_Load(object sender, EventArgs e)
        {

            data();
           
            LblHesapNo.Text = hesapno;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKISILER where hesapno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",hesapno);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                LblTc.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from TBLHESAP where HESAPNO=@h1 ",baglanti);
            komut2.Parameters.AddWithValue("@h1",hesapno);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                LblBakiye.Text = dr2[1].ToString();
            }
            baglanti.Close();
            


        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gonderilen hesabin para artisi
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2",baglanti);
            komut.Parameters.AddWithValue("@P1",decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P2",MskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
          



            //gonderen hesabin para azalisi
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE-@K1 WHERE HESAPNO=@K2", baglanti);
            komut2.Parameters.AddWithValue("@K1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@K2", LblHesapNo.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Isleminiz gerceklesti.");

            // Hareket Tablosuna Kayit Edilmesi 

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN,ALICI,TUTAR) VALUES (@H1,@H2,@H3)",baglanti);
            komut3.Parameters.AddWithValue("@H1",LblHesapNo.Text);
            komut3.Parameters.AddWithValue("@H2", MskHesapNo.Text);
            komut3.Parameters.AddWithValue("@H3", TxtTutar.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hareketler frm = new Hareketler();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
