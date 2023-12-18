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

namespace Pastane_Maliyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=PastaneMaliyet;Integrated Security=True");

        void firin()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFIRIN", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLMALZEMELER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void urunlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLURUNLER", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void kasa()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLKASA", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void urunadgetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
        }
        void malzemeadgetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            urunadgetir();
            malzemeadgetir();
            

        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            urunlistesi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kasa();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMALZEMELER (ad,stok,fiyat,notlar) values (@p1,@p2,@p3,@p4)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", TxtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni malzeme eklendi.");
            listele();

        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (ad) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtUrunAd.Text);
            komut.ExecuteNonQuery(); 
            baglanti.Close();
            MessageBox.Show("Yeni urun eklendi.");
            urunlistesi();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values(@f1,@f2,@f3,@f4)",baglanti);
            komut.Parameters.AddWithValue("@f1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@f2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@f3",decimal.Parse(TxtUrunMiktar.Text));
     
            komut.Parameters.AddWithValue("@f4", decimal.Parse(TxtUrunMaliyet.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun bilgileri girildi..");
            listBox1.Items.Add(CmbMalzeme.Text + " " + TxtUrunMaliyet.Text);
            firin();

        }

        private void TxtUrunMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if(TxtUrunMiktar.Text == "")
            {
                TxtUrunMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLMALZEMELER where MALZEMEID=@p1", baglanti);

            komut.Parameters.AddWithValue("@p1", CmbMalzeme.SelectedValue);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunMaliyet.Text =dr[3].ToString();
            }

            baglanti.Close();
            maliyet = Convert.ToDouble(TxtUrunMaliyet.Text) / 1000 * Convert.ToDouble(TxtUrunMiktar.Text);
            TxtUrunMaliyet.Text = maliyet.ToString();

        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Sum(MALIYET) from TBLFIRIN where URUNID=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyetFiyat.Text = dr[0].ToString();
            }
        }
    }
}
