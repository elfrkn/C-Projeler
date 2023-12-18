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

namespace Seyahat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=YolcuBilet;Integrated Security=True");

      void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERBILGI",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void yolculistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLSEFERDETAY", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@y1,@y2,@y3,@y4,@y5,@y6)",baglanti);
            komut.Parameters.AddWithValue("@y1",TxtAd.Text);
            komut.Parameters.AddWithValue("@y2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@y3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@y4", MskTC.Text);
            komut.Parameters.AddWithValue("@y5", CmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@y6", TxtMaıl.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu bilgileri kaydeildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnKaptanKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN(KAPTANNO,ADSOYAD,TELEFON) values (@k1,@k2,@k3)",baglanti);
            komut.Parameters.AddWithValue("@k1", TxtKaptanNo.Text);
            komut.Parameters.AddWithValue("@k2", TxtKaptanAdSoyad.Text);
            komut.Parameters.AddWithValue("@k3", MskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan bilgileri kaydeildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI(KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@s1,@s2,@s3,@s4,@s5,@s6)", baglanti);
            komut.Parameters.AddWithValue("@s1", TxtKalkis.Text);
            komut.Parameters.AddWithValue("@s2", TxtVaris.Text);
            komut.Parameters.AddWithValue("@s3", MskTarih.Text);
            komut.Parameters.AddWithValue("@s4", MskSaat.Text);
            komut.Parameters.AddWithValue("@s5", MskKaptan.Text);
            komut.Parameters.AddWithValue("@s6", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer bilgileri kaydeildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seferlistesi();
            yolculistesi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
            yolculistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtRezSeferNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtKoltukNo.Text = "0";
        }

        private void BtnRezevasyonYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) values (@s1,@s2,@s3)",baglanti);
            komut.Parameters.AddWithValue("@s1", TxtRezSeferNo.Text);
            komut.Parameters.AddWithValue("@s2", MskRezTC.Text);
            komut.Parameters.AddWithValue("@s3", TxtKoltukNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyon Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seferlistesi();
            yolculistesi();
        }
    }
}
