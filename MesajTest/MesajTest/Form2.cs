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

namespace MesajTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=Test;Integrated Security=True");

        void gelenkutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select  (AD+ ' ' +SOYAD) AS 'GONDEREN',BASLIK,ICERIK  from TBLMESAJLAR INNER JOIN TBLKISILER ON TBLMESAJLAR.GONDEREN = TBLKISILER.NUMARA WHERE ALICI="+numara,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void gidenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select  (AD+ ' ' +SOYAD) AS 'ALICI',BASLIK,ICERIK  from TBLMESAJLAR INNER JOIN TBLKISILER ON TBLMESAJLAR.ALICI = TBLKISILER.NUMARA WHERE GONDEREN=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;
            gelenkutusu();
            gidenkutusu();


            // Ad Soyad Cekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select AD,SOYAD from TBLKISILER where numara= "+ numara,baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) VALUES (@P1,@P2,@P3,@P4)",baglanti );
            komut.Parameters.AddWithValue("@P1",numara);
            komut.Parameters.AddWithValue("@P2", MskAlici.Text);
            komut.Parameters.AddWithValue("@P3",TxtBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RMesaj.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajiniz gonderildi.");

            gidenkutusu();
            gelenkutusu();

        }
    }
}
