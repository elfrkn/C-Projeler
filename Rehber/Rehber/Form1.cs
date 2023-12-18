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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=Rehber;Integrated Security=True");

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KISILER ", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TxtAd.Text = "";
            txtId.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTel.Text = "";
            TxtResim.Text = "";
            TxtAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO KISILER (AD,SOYAD,TELEFON,MAIL,RESIM) VALUES (@R1,@R2,@R3,@R4,@R5)",baglanti);
            komut.Parameters.AddWithValue("@R1",TxtAd.Text);
            komut.Parameters.AddWithValue("@R2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@R3", MskTel.Text);
            komut.Parameters.AddWithValue("@R4", TxtMail.Text);
            komut.Parameters.AddWithValue("@R5", TxtResim.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kisi eklendi.");
            listele();
            temizle();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Kisiyi silmek istiyor musunuz?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(secim == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete from KISILER where ID=@P1", baglanti);
                komut.Parameters.AddWithValue("@P1", txtId.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kisi bilgisi silindi");
                listele();
                temizle();
            }
          
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResim.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {


            baglanti.Open();
            SqlCommand komut=new SqlCommand("Update KISILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4,RESIM=@p6 where ID=@p5",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtMail.Text);
            komut.Parameters.AddWithValue("@p5", txtId.Text);
            komut.Parameters.AddWithValue("@p6", TxtResim.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kisi bilgisi guncellendi.");
            listele();
            temizle();

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            TxtResim.Text = openFileDialog1.FileName;
        }
    }
}
