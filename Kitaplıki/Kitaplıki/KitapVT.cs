using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Kitaplık;
using System.Windows.Forms;

namespace Kitaplik
{
    internal class KitapVT
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI;Initial Catalog=Kitaplik;Integrated Security=True");

        public List<kitap> Liste()
        {
            List<kitap> ktp = new List<kitap>();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLKITAPLAR",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                kitap k = new kitap();
                k.ID = Convert.ToInt16(dr[0].ToString());
                k.ADI = dr[1].ToString();
                k.YAZARI = dr[2].ToString();
                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
        }

        public void KitapEkle(kitap kt)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKITAPLAR (KITAPAD,KITAPYAZAR) values (@p1,@p2)",baglanti);
            komut.Parameters.AddWithValue("@p1",kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZARI);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kitap eklendi.");
        }

        public void KitapSil(kitap ks)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from TBLKITAPLAR where KITAPAD=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",ks.ADI);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Silindi.");
        }
    }
}
