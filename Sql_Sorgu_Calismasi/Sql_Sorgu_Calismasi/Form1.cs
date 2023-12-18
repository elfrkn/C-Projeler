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

namespace Sql_Sorgu_Calismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Integrated Security=True");
        void listele()
        {
            baglanti.Open();
            SqlCommand komut =new  SqlCommand("select * from sys.databases",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=" + comboBox1.Text + ";Integrated Security=True");
            
            string sorgu = richTextBox1.Text;


            try
            {
               
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin !!!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=" + comboBox1.Text + ";Integrated Security=True");
                string sorgu = richTextBox1.Text;
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin !!!");
            }
           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog="+ comboBox1.Text+ ";Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
           
        }
    }
}
