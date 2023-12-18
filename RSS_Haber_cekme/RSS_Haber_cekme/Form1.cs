using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Haber_cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //https://www.hurriyet.com.tr/rss/anasayfa
        //https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml
        // https://www.fotomac.com.tr/rss/anasayfa.xml

        public string haber (string url)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(url);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
            return url;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string rss = haber("https://www.hurriyet.com.tr/rss/anasayfa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rss = haber("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string rss = haber("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }

    }
}
