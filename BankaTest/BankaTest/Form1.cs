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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=DbBankaTest;Integrated Security=True");

        
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit frm = new Kayit();
            frm.Show();
            this.Hide();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select HESAPNO,SIFRE from TBLKISILER where HESAPNO ='"+MskHesapNo.Text+"' and SIFRE='"+TxtSifre.Text+"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Detay frm = new Detay();
                frm.hesapno = MskHesapNo.Text;
                frm.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol edin.");
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
