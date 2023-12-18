using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = linkLabel1;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (soruno)
            {
                //cevap1
                case 1:
                    if (textBox1.Text == "akdeniz")
                    {
                        buttonA.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();
                        

                    }
                    else
                    {
                        buttonA.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();
                        
                    }
                    break;
                //cevap2
                case 2:
                    if (textBox1.Text == "bursa")
                    {
                        buttonB.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();
                    }
                    else
                    {
                        buttonB.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();
                    }
                    break;
                //cevap3
                case 3:
                    if (textBox1.Text == "cuma")
                    {
                        buttonC.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();
                    }
                    else
                    {
                        buttonC.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();
                    }
                    break;
                //cevap4
                case 4:
                    if (textBox1.Text == "diyarbakir")
                    {
                        buttonD.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();


                    }
                    else
                    {
                        buttonD.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();

                    }
                    break;
                //cevap5
                case 5:
                    if (textBox1.Text == "eski")
                    {
                        buttonE.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();


                    }
                    else
                    {
                        buttonE.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();

                    }
                    break;
                //cevap6
                case 6:
                    if (textBox1.Text == "Ferman")
                    {
                        buttonF.BackColor = Color.Green;
                        textBox1.Text = "";
                        dogru++;
                        label2.Text = dogru.ToString();


                    }
                    else
                    {
                        buttonF.BackColor = Color.Red;
                        textBox1.Text = "";
                        yanlis++;
                        label3.Text = yanlis.ToString();

                    }
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ulkemizin guney kismindaki kiyi bolgesi?";
                buttonA.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Yesilligiyle unlu Marmara ilimiz?";
                buttonB.BackColor = Color.Yellow;
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Muslumanlarin kutsal gunu?";
                buttonC.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzunyla unlu ilimiz?";
                buttonD.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimesinin zit anlami?";
                buttonE.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padisahin emirlerinin yazili hali?";
                buttonF.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dunyanin isi kaynagi?";
                buttonG.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Ogrencilerin kotu karne getirince bakistigi nesne?";
                buttonH.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Guluyle unlu ilimiz?";
                buttonI.BackColor = Color.Yellow;

            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diger ismi?";
                buttonİ.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                buttonJ.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanin meshur meyvesi?";
                buttonK.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yil Istanbulda duzenlenen meshur festival?";
                buttonL.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yilin 3. ayi?";
                buttonM.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Uflemeli bir muzik aleti ?";
                buttonN.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk sairi?";
                buttonO.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Cocuklarin pek sevmedigi pirinc,havuc gibi sebzelerle yapilan yemek ?";
                buttonP.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayin sultani ?";
                buttonR.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Ingilizcede yilan?";
                buttonS.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Turkiyenin mega stari ?";
                buttonT.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Umit kelimesinin es anlamlisi?";
                buttonU.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltisi ile unlu ilimiz?";
                buttonV.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Simsek kelimesinin es anlamlisi";
                buttonY.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bolgesinin en cok agaci bulunan,yagi da yapilan bir kahvalti besini?";
                buttonZ.BackColor = Color.Yellow;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
