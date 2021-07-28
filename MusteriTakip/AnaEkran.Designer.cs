namespace MusteriTakip
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxGecmis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxKisiler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gecmisRaporBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musteriEkle = new System.Windows.Forms.Button();
            this.alacakRaporBtn = new System.Windows.Forms.Button();
            this.tabloGuncelle = new System.Windows.Forms.Button();
            this.bilgiBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.musteriSil = new System.Windows.Forms.Button();
            this.gecmisTemizleBtn = new System.Windows.Forms.Button();
            this.seciliGecmisBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxGecmis
            // 
            this.listBoxGecmis.FormattingEnabled = true;
            this.listBoxGecmis.Location = new System.Drawing.Point(347, 102);
            this.listBoxGecmis.Name = "listBoxGecmis";
            this.listBoxGecmis.Size = new System.Drawing.Size(480, 225);
            this.listBoxGecmis.TabIndex = 4;
            this.listBoxGecmis.SelectedIndexChanged += new System.EventHandler(this.listBoxGecmis_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İŞLEM GEÇMİŞİ";
            // 
            // listBoxKisiler
            // 
            this.listBoxKisiler.FormattingEnabled = true;
            this.listBoxKisiler.Location = new System.Drawing.Point(27, 102);
            this.listBoxKisiler.Name = "listBoxKisiler";
            this.listBoxKisiler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxKisiler.Size = new System.Drawing.Size(303, 225);
            this.listBoxKisiler.TabIndex = 7;
            this.listBoxKisiler.SelectedIndexChanged += new System.EventHandler(this.listBoxKisiler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ARA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guncelleBtn
            // 
            this.guncelleBtn.Location = new System.Drawing.Point(27, 327);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(115, 27);
            this.guncelleBtn.TabIndex = 10;
            this.guncelleBtn.Text = "Müşteriyi Görüntüle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "KİŞİLER";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 412);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Alacak Tutarı";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 220);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.gecmisRaporBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.musteriEkle);
            this.panel1.Controls.Add(this.alacakRaporBtn);
            this.panel1.Controls.Add(this.tabloGuncelle);
            this.panel1.Controls.Add(this.bilgiBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 50);
            this.panel1.TabIndex = 14;
            // 
            // gecmisRaporBtn
            // 
            this.gecmisRaporBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.gecmisRaporBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gecmisRaporBtn.Image = global::MusteriTakip.Properties.Resources.profit_report__1_;
            this.gecmisRaporBtn.Location = new System.Drawing.Point(382, 0);
            this.gecmisRaporBtn.Name = "gecmisRaporBtn";
            this.gecmisRaporBtn.Size = new System.Drawing.Size(123, 50);
            this.gecmisRaporBtn.TabIndex = 13;
            this.gecmisRaporBtn.Text = "Geçmiş İşlem Raporu Oluştur";
            this.gecmisRaporBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gecmisRaporBtn.UseVisualStyleBackColor = false;
            this.gecmisRaporBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.pictureBox1.Image = global::MusteriTakip.Properties.Resources.handshake;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // musteriEkle
            // 
            this.musteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.musteriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteriEkle.Image = global::MusteriTakip.Properties.Resources.add_user;
            this.musteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musteriEkle.Location = new System.Drawing.Point(141, 0);
            this.musteriEkle.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.musteriEkle.Name = "musteriEkle";
            this.musteriEkle.Size = new System.Drawing.Size(123, 50);
            this.musteriEkle.TabIndex = 0;
            this.musteriEkle.Text = "Müşteri Oluştur";
            this.musteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.musteriEkle.UseVisualStyleBackColor = false;
            this.musteriEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // alacakRaporBtn
            // 
            this.alacakRaporBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.alacakRaporBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alacakRaporBtn.Image = global::MusteriTakip.Properties.Resources.profit_report__1_;
            this.alacakRaporBtn.Location = new System.Drawing.Point(261, 0);
            this.alacakRaporBtn.Name = "alacakRaporBtn";
            this.alacakRaporBtn.Size = new System.Drawing.Size(123, 50);
            this.alacakRaporBtn.TabIndex = 2;
            this.alacakRaporBtn.Text = "Alacak Raporu   Oluştur";
            this.alacakRaporBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.alacakRaporBtn.UseVisualStyleBackColor = false;
            this.alacakRaporBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabloGuncelle
            // 
            this.tabloGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.tabloGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabloGuncelle.Image = global::MusteriTakip.Properties.Resources.loop_arrow;
            this.tabloGuncelle.Location = new System.Drawing.Point(503, 0);
            this.tabloGuncelle.Name = "tabloGuncelle";
            this.tabloGuncelle.Size = new System.Drawing.Size(116, 50);
            this.tabloGuncelle.TabIndex = 11;
            this.tabloGuncelle.Text = "Tabloları Güncelle";
            this.tabloGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tabloGuncelle.UseVisualStyleBackColor = false;
            this.tabloGuncelle.Click += new System.EventHandler(this.tabloGuncelle_Click);
            // 
            // bilgiBtn
            // 
            this.bilgiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.bilgiBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bilgiBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bilgiBtn.Image = global::MusteriTakip.Properties.Resources.info;
            this.bilgiBtn.Location = new System.Drawing.Point(617, 0);
            this.bilgiBtn.Name = "bilgiBtn";
            this.bilgiBtn.Size = new System.Drawing.Size(131, 50);
            this.bilgiBtn.TabIndex = 3;
            this.bilgiBtn.Text = "Program Hakkında Bilgi";
            this.bilgiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bilgiBtn.UseVisualStyleBackColor = false;
            this.bilgiBtn.Click += new System.EventHandler(this.bilgiBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(336, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Müşteri Borç Grafiği";
            // 
            // musteriSil
            // 
            this.musteriSil.Location = new System.Drawing.Point(141, 327);
            this.musteriSil.Name = "musteriSil";
            this.musteriSil.Size = new System.Drawing.Size(115, 27);
            this.musteriSil.TabIndex = 16;
            this.musteriSil.Text = "Müşteriyi Sil";
            this.musteriSil.UseVisualStyleBackColor = true;
            this.musteriSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // gecmisTemizleBtn
            // 
            this.gecmisTemizleBtn.Location = new System.Drawing.Point(347, 327);
            this.gecmisTemizleBtn.Name = "gecmisTemizleBtn";
            this.gecmisTemizleBtn.Size = new System.Drawing.Size(115, 27);
            this.gecmisTemizleBtn.TabIndex = 17;
            this.gecmisTemizleBtn.Text = "Geçmişi Temizle";
            this.gecmisTemizleBtn.UseVisualStyleBackColor = true;
            this.gecmisTemizleBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // seciliGecmisBtn
            // 
            this.seciliGecmisBtn.Location = new System.Drawing.Point(461, 327);
            this.seciliGecmisBtn.Name = "seciliGecmisBtn";
            this.seciliGecmisBtn.Size = new System.Drawing.Size(115, 27);
            this.seciliGecmisBtn.TabIndex = 18;
            this.seciliGecmisBtn.Text = "Seçili İşlemi Sil";
            this.seciliGecmisBtn.UseVisualStyleBackColor = true;
            this.seciliGecmisBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(850, 644);
            this.Controls.Add(this.seciliGecmisBtn);
            this.Controls.Add(this.gecmisTemizleBtn);
            this.Controls.Add(this.musteriSil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guncelleBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxKisiler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGecmis);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alacakRaporBtn;
        private System.Windows.Forms.Button bilgiBtn;
        private System.Windows.Forms.ListBox listBoxGecmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxKisiler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Button tabloGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gecmisRaporBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button musteriSil;
        private System.Windows.Forms.Button gecmisTemizleBtn;
        private System.Windows.Forms.Button seciliGecmisBtn;
        private System.Windows.Forms.Button musteriEkle;
    }
}

