using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Yapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> karakterler = new List<string>();
            karakterler.Add("Mazhar");
            karakterler.Add("Ruhsar");
            karakterler.Add("Menkıbe");
            karakterler.Add("Müfit");
            karakterler.Add("Reyhan");
            karakterler.Add("Firdevs");

            foreach(string k in karakterler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(35);
            sayilar.Add(40);
            sayilar.Add(56);
            sayilar.Add(96);
            sayilar.Add(23);

            foreach(int i in sayilar)
            {
                if(i % 5 == 0)
                {
                    listBox2.Items.Add(i);
                }
                
            }
            if(sayilar.Contains(74))
            {
                MessageBox.Show("Bu sayi var");
            }else
            {
                MessageBox.Show("Bu sayi yok");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<kisiler> kisi = new List<kisiler>();
            kisi.Add(new kisiler()
            {
                ADI = "Elif",
                SOYADI = "Calis",
                MESLEK = "Ogretmen"
            });

            foreach(kisiler k in kisi)
            {
                listBox3.Items.Add(k.ADI+ " " + k.SOYADI+" "+k.MESLEK);
            }
        }
    }
}
