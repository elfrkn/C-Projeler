namespace Doviz_Ofisi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.LblDolarAlis = new System.Windows.Forms.Label();
            this.LblDolarSatis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblEuroSatis = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblEuroAlis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSatisYap2 = new System.Windows.Forms.Button();
            this.BtnSatisYap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtKur = new System.Windows.Forms.TextBox();
            this.BtnDolarAl = new System.Windows.Forms.Button();
            this.BtnDolarSatis = new System.Windows.Forms.Button();
            this.BtnEuroSat = new System.Windows.Forms.Button();
            this.BtnEuroAl = new System.Windows.Forms.Button();
            this.LblToplamEuro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblToplamDolar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblToplamTL = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dolar Alis :";
            // 
            // LblDolarAlis
            // 
            this.LblDolarAlis.AutoSize = true;
            this.LblDolarAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarAlis.ForeColor = System.Drawing.Color.White;
            this.LblDolarAlis.Location = new System.Drawing.Point(173, 54);
            this.LblDolarAlis.Name = "LblDolarAlis";
            this.LblDolarAlis.Size = new System.Drawing.Size(23, 25);
            this.LblDolarAlis.TabIndex = 1;
            this.LblDolarAlis.Text = "0";
            // 
            // LblDolarSatis
            // 
            this.LblDolarSatis.AutoSize = true;
            this.LblDolarSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblDolarSatis.ForeColor = System.Drawing.Color.White;
            this.LblDolarSatis.Location = new System.Drawing.Point(173, 91);
            this.LblDolarSatis.Name = "LblDolarSatis";
            this.LblDolarSatis.Size = new System.Drawing.Size(23, 25);
            this.LblDolarSatis.TabIndex = 3;
            this.LblDolarSatis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dolar Satis :";
            // 
            // LblEuroSatis
            // 
            this.LblEuroSatis.AutoSize = true;
            this.LblEuroSatis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroSatis.ForeColor = System.Drawing.Color.White;
            this.LblEuroSatis.Location = new System.Drawing.Point(173, 166);
            this.LblEuroSatis.Name = "LblEuroSatis";
            this.LblEuroSatis.Size = new System.Drawing.Size(23, 25);
            this.LblEuroSatis.TabIndex = 7;
            this.LblEuroSatis.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Euro Satis :";
            // 
            // LblEuroAlis
            // 
            this.LblEuroAlis.AutoSize = true;
            this.LblEuroAlis.BackColor = System.Drawing.Color.Transparent;
            this.LblEuroAlis.ForeColor = System.Drawing.Color.White;
            this.LblEuroAlis.Location = new System.Drawing.Point(173, 129);
            this.LblEuroAlis.Name = "LblEuroAlis";
            this.LblEuroAlis.Size = new System.Drawing.Size(23, 25);
            this.LblEuroAlis.TabIndex = 5;
            this.LblEuroAlis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Euro Alis :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnSatisYap2);
            this.groupBox1.Controls.Add(this.BtnSatisYap);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtKalan);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtMiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtKur);
            this.groupBox1.Location = new System.Drawing.Point(385, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 250);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BtnSatisYap2
            // 
            this.BtnSatisYap2.Location = new System.Drawing.Point(256, 196);
            this.BtnSatisYap2.Name = "BtnSatisYap2";
            this.BtnSatisYap2.Size = new System.Drawing.Size(119, 38);
            this.BtnSatisYap2.TabIndex = 18;
            this.BtnSatisYap2.Text = "Dolar Al";
            this.BtnSatisYap2.UseVisualStyleBackColor = true;
            this.BtnSatisYap2.Click += new System.EventHandler(this.BtnSatisYap2_Click);
            // 
            // BtnSatisYap
            // 
            this.BtnSatisYap.Location = new System.Drawing.Point(121, 196);
            this.BtnSatisYap.Name = "BtnSatisYap";
            this.BtnSatisYap.Size = new System.Drawing.Size(119, 38);
            this.BtnSatisYap.TabIndex = 17;
            this.BtnSatisYap.Text = "Dolar Sat";
            this.BtnSatisYap.UseVisualStyleBackColor = true;
            this.BtnSatisYap.Click += new System.EventHandler(this.BtnSatisYap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(47, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Kalan :";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(122, 151);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(256, 30);
            this.TxtKalan.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(47, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tutar :";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(122, 111);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(254, 30);
            this.TxtTutar.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Miktar :";
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(122, 71);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(254, 30);
            this.TxtMiktar.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(63, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Kur :";
            // 
            // TxtKur
            // 
            this.TxtKur.Location = new System.Drawing.Point(121, 29);
            this.TxtKur.Name = "TxtKur";
            this.TxtKur.Size = new System.Drawing.Size(254, 30);
            this.TxtKur.TabIndex = 0;
            this.TxtKur.TextChanged += new System.EventHandler(this.TxtKur_TextChanged);
            // 
            // BtnDolarAl
            // 
            this.BtnDolarAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDolarAl.Location = new System.Drawing.Point(248, 54);
            this.BtnDolarAl.Name = "BtnDolarAl";
            this.BtnDolarAl.Size = new System.Drawing.Size(36, 25);
            this.BtnDolarAl.TabIndex = 10;
            this.BtnDolarAl.Text = "...";
            this.BtnDolarAl.UseVisualStyleBackColor = true;
            this.BtnDolarAl.Click += new System.EventHandler(this.BtnDolarAl_Click);
            // 
            // BtnDolarSatis
            // 
            this.BtnDolarSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDolarSatis.Location = new System.Drawing.Point(248, 91);
            this.BtnDolarSatis.Name = "BtnDolarSatis";
            this.BtnDolarSatis.Size = new System.Drawing.Size(36, 25);
            this.BtnDolarSatis.TabIndex = 11;
            this.BtnDolarSatis.Text = "...";
            this.BtnDolarSatis.UseVisualStyleBackColor = true;
            this.BtnDolarSatis.Click += new System.EventHandler(this.BtnDolarSatis_Click);
            // 
            // BtnEuroSat
            // 
            this.BtnEuroSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEuroSat.Location = new System.Drawing.Point(248, 168);
            this.BtnEuroSat.Name = "BtnEuroSat";
            this.BtnEuroSat.Size = new System.Drawing.Size(36, 25);
            this.BtnEuroSat.TabIndex = 13;
            this.BtnEuroSat.Text = "...";
            this.BtnEuroSat.UseVisualStyleBackColor = true;
            this.BtnEuroSat.Click += new System.EventHandler(this.BtnEuroSat_Click);
            // 
            // BtnEuroAl
            // 
            this.BtnEuroAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEuroAl.Location = new System.Drawing.Point(248, 131);
            this.BtnEuroAl.Name = "BtnEuroAl";
            this.BtnEuroAl.Size = new System.Drawing.Size(36, 25);
            this.BtnEuroAl.TabIndex = 12;
            this.BtnEuroAl.Text = "...";
            this.BtnEuroAl.UseVisualStyleBackColor = true;
            this.BtnEuroAl.Click += new System.EventHandler(this.BtnEuroAl_Click);
            // 
            // LblToplamEuro
            // 
            this.LblToplamEuro.AutoSize = true;
            this.LblToplamEuro.BackColor = System.Drawing.Color.Transparent;
            this.LblToplamEuro.ForeColor = System.Drawing.Color.White;
            this.LblToplamEuro.Location = new System.Drawing.Point(247, 452);
            this.LblToplamEuro.Name = "LblToplamEuro";
            this.LblToplamEuro.Size = new System.Drawing.Size(23, 25);
            this.LblToplamEuro.TabIndex = 19;
            this.LblToplamEuro.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "TOPLAM EURO :";
            // 
            // LblToplamDolar
            // 
            this.LblToplamDolar.AutoSize = true;
            this.LblToplamDolar.BackColor = System.Drawing.Color.Transparent;
            this.LblToplamDolar.ForeColor = System.Drawing.Color.White;
            this.LblToplamDolar.Location = new System.Drawing.Point(247, 414);
            this.LblToplamDolar.Name = "LblToplamDolar";
            this.LblToplamDolar.Size = new System.Drawing.Size(23, 25);
            this.LblToplamDolar.TabIndex = 17;
            this.LblToplamDolar.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "TOPLAM DOLAR :";
            // 
            // LblToplamTL
            // 
            this.LblToplamTL.AutoSize = true;
            this.LblToplamTL.BackColor = System.Drawing.Color.Transparent;
            this.LblToplamTL.ForeColor = System.Drawing.Color.White;
            this.LblToplamTL.Location = new System.Drawing.Point(247, 377);
            this.LblToplamTL.Name = "LblToplamTL";
            this.LblToplamTL.Size = new System.Drawing.Size(23, 25);
            this.LblToplamTL.TabIndex = 15;
            this.LblToplamTL.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(112, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 25);
            this.label14.TabIndex = 14;
            this.label14.Text = "TOPLAM TL :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 589);
            this.Controls.Add(this.LblToplamEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblToplamDolar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblToplamTL);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnEuroSat);
            this.Controls.Add(this.BtnEuroAl);
            this.Controls.Add(this.BtnDolarSatis);
            this.Controls.Add(this.BtnDolarAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblEuroSatis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblEuroAlis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblDolarSatis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblDolarAlis);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDolarAlis;
        private System.Windows.Forms.Label LblDolarSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblEuroSatis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblEuroAlis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSatisYap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtKur;
        private System.Windows.Forms.Button BtnDolarAl;
        private System.Windows.Forms.Button BtnDolarSatis;
        private System.Windows.Forms.Button BtnEuroSat;
        private System.Windows.Forms.Button BtnEuroAl;
        private System.Windows.Forms.Button BtnSatisYap2;
        private System.Windows.Forms.Label LblToplamEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblToplamDolar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblToplamTL;
        private System.Windows.Forms.Label label14;
    }
}

