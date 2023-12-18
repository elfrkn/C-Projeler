namespace KelimeOgrenUygulama
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIngilizce = new System.Windows.Forms.TextBox();
            this.TxtTurkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSure = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.LblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingilizce :";
            // 
            // TxtIngilizce
            // 
            this.TxtIngilizce.Location = new System.Drawing.Point(253, 67);
            this.TxtIngilizce.Name = "TxtIngilizce";
            this.TxtIngilizce.Size = new System.Drawing.Size(224, 30);
            this.TxtIngilizce.TabIndex = 10;
            // 
            // TxtTurkce
            // 
            this.TxtTurkce.Location = new System.Drawing.Point(253, 119);
            this.TxtTurkce.Name = "TxtTurkce";
            this.TxtTurkce.Size = new System.Drawing.Size(224, 30);
            this.TxtTurkce.TabIndex = 1;
            this.TxtTurkce.TextChanged += new System.EventHandler(this.TxtTurkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turkce :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sure :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kelime :";
            // 
            // LblSure
            // 
            this.LblSure.AutoSize = true;
            this.LblSure.Location = new System.Drawing.Point(614, 72);
            this.LblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSure.Name = "LblSure";
            this.LblSure.Size = new System.Drawing.Size(34, 25);
            this.LblSure.TabIndex = 6;
            this.LblSure.Text = "90";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Location = new System.Drawing.Point(614, 122);
            this.LblKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(23, 25);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // LblCevap
            // 
            this.LblCevap.AutoSize = true;
            this.LblCevap.Location = new System.Drawing.Point(528, 180);
            this.LblCevap.Name = "LblCevap";
            this.LblCevap.Size = new System.Drawing.Size(64, 25);
            this.LblCevap.TabIndex = 8;
            this.LblCevap.Text = "label7";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(888, 260);
            this.Controls.Add(this.LblCevap);
            this.Controls.Add(this.LblKelime);
            this.Controls.Add(this.LblSure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTurkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIngilizce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIngilizce;
        private System.Windows.Forms.TextBox TxtTurkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSure;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label LblCevap;
        private System.Windows.Forms.Timer timer1;
    }
}

