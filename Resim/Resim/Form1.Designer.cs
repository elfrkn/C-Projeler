namespace Resim
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
            this.BtnRenk = new System.Windows.Forms.Button();
            this.BtnResim = new System.Windows.Forms.Button();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRenk
            // 
            this.BtnRenk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnRenk.Location = new System.Drawing.Point(40, 22);
            this.BtnRenk.Name = "BtnRenk";
            this.BtnRenk.Size = new System.Drawing.Size(183, 41);
            this.BtnRenk.TabIndex = 0;
            this.BtnRenk.Text = "Renk Seç";
            this.BtnRenk.UseVisualStyleBackColor = false;
            this.BtnRenk.Click += new System.EventHandler(this.BtnRenk_Click);
            // 
            // BtnResim
            // 
            this.BtnResim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnResim.Location = new System.Drawing.Point(40, 68);
            this.BtnResim.Name = "BtnResim";
            this.BtnResim.Size = new System.Drawing.Size(183, 42);
            this.BtnResim.TabIndex = 1;
            this.BtnResim.Text = "Resim Seç";
            this.BtnResim.UseVisualStyleBackColor = false;
            this.BtnResim.Click += new System.EventHandler(this.BtnResim_Click);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnYazdir.Location = new System.Drawing.Point(40, 115);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(183, 38);
            this.BtnYazdir.TabIndex = 2;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = false;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnKaydet.Location = new System.Drawing.Point(40, 157);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(183, 38);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtMetin
            // 
            this.TxtMetin.Location = new System.Drawing.Point(98, 210);
            this.TxtMetin.Name = "TxtMetin";
            this.TxtMetin.Size = new System.Drawing.Size(125, 27);
            this.TxtMetin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Boyut :";
            // 
            // TxtBoyut
            // 
            this.TxtBoyut.Location = new System.Drawing.Point(98, 243);
            this.TxtBoyut.Name = "TxtBoyut";
            this.TxtBoyut.Size = new System.Drawing.Size(125, 27);
            this.TxtBoyut.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(271, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(807, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoyut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMetin);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.BtnResim);
            this.Controls.Add(this.BtnRenk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRenk;
        private System.Windows.Forms.Button BtnResim;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

