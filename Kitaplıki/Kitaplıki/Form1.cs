using Kitaplik;
using Kitaplık;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplıki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KitapVT vtsinif = new KitapVT();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitap ktpsinif = new kitap();
            ktpsinif.ADI = textBox1.Text;
            ktpsinif.YAZARI = textBox2.Text;
            vtsinif.KitapEkle(ktpsinif);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kitap ktpsil = new kitap();
            ktpsil.ADI = textBox1.Text;
            vtsinif.KitapSil(ktpsil);

        }
    }
}
