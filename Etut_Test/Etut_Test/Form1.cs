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
using System.IO;

namespace Etut_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=OgrenciEtut;Integrated Security=True");

        void derslistesi()
        {
         
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.DisplayMember = "DERSAD";
            CmbDers.ValueMember = "DERSID";
            CmbDers.DataSource = dt;
           
        }

        void derslistesiogretmen()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOgretmenDers.DisplayMember = "DERSAD";
            CmbOgretmenDers.ValueMember = "DERSID";
            CmbOgretmenDers.DataSource = dt;

        }

        //datagridview a etut listesini aktarma 
        void etutlistesi()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE ETUTLISTESI", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            for(int i=0; i< dataGridView1.Rows.Count -1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value) == true)
                {
                    renk.BackColor = Color.Green;
                }
                else
                {
                    renk.BackColor = Color.OrangeRed;
                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            derslistesiogretmen();

        }

        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRETMEN WHERE BRANSID=" + CmbDers.SelectedValue, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns.Add("Ogretmen", typeof(string), "AD + ' '+SOYAD");
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "Ogretmen";
            CmbOgretmen.DataSource = dt;
       


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@d1,@d2,@d3,@d4)",con);
            cmd.Parameters.AddWithValue("@d1",CmbDers.SelectedValue);
            cmd.Parameters.AddWithValue("@d2", CmbOgretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@d3", MskTarih.Text);
            cmd.Parameters.AddWithValue("@d4", MskSaat.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kaydiniz gerceklesti.");
            etutlistesi();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tbletut set ogrenciid=@p1,durum=@p2 where id=@p3",con);
            cmd.Parameters.AddWithValue("@p1",TxtOgrId.Text);
            cmd.Parameters.AddWithValue("@p2", "True");
            cmd.Parameters.AddWithValue("@p3", Txtogrenci.Text);    
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ogrenciye etut verildi.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@p1)",con);
            komut.Parameters.AddWithValue("@p1",TxtDers.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ders Kaydi Gerceklesti.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@P2,@P3,@P4,@P5,@P6)", con);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSinif.Text);
            komut.Parameters.AddWithValue("@p5", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Ogrenci" +
                " Kaydi Gerceklesti.");
        }
    }
}
