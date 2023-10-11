namespace Hastane_Otomasyonu
{
    partial class Hasta_Giris_Ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta_Giris_Ekranı));
            this.dataGridViewGecmisRandevular = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAktifRandevular = new System.Windows.Forms.DataGridView();
            this.linkLabelBilgiDüzenle = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxSikayet = new System.Windows.Forms.RichTextBox();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxKlinik = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmisRandevular)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevular)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGecmisRandevular
            // 
            this.dataGridViewGecmisRandevular.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewGecmisRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGecmisRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGecmisRandevular.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewGecmisRandevular.Name = "dataGridViewGecmisRandevular";
            this.dataGridViewGecmisRandevular.RowHeadersWidth = 51;
            this.dataGridViewGecmisRandevular.RowTemplate.Height = 24;
            this.dataGridViewGecmisRandevular.Size = new System.Drawing.Size(451, 376);
            this.dataGridViewGecmisRandevular.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewGecmisRandevular);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 397);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geçmiş Randevular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewAktifRandevular);
            this.groupBox2.Location = new System.Drawing.Point(3, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 229);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktif Randevular";
            // 
            // dataGridViewAktifRandevular
            // 
            this.dataGridViewAktifRandevular.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktifRandevular.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewAktifRandevular.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewAktifRandevular.Name = "dataGridViewAktifRandevular";
            this.dataGridViewAktifRandevular.RowHeadersWidth = 51;
            this.dataGridViewAktifRandevular.RowTemplate.Height = 24;
            this.dataGridViewAktifRandevular.Size = new System.Drawing.Size(549, 208);
            this.dataGridViewAktifRandevular.TabIndex = 0;
            this.dataGridViewAktifRandevular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAktifRandevular_CellClick);
            // 
            // linkLabelBilgiDüzenle
            // 
            this.linkLabelBilgiDüzenle.AutoSize = true;
            this.linkLabelBilgiDüzenle.Location = new System.Drawing.Point(322, 81);
            this.linkLabelBilgiDüzenle.Name = "linkLabelBilgiDüzenle";
            this.linkLabelBilgiDüzenle.Size = new System.Drawing.Size(117, 16);
            this.linkLabelBilgiDüzenle.TabIndex = 15;
            this.linkLabelBilgiDüzenle.TabStop = true;
            this.linkLabelBilgiDüzenle.Text = "Bilgilerimi Düzenle";
            this.linkLabelBilgiDüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBilgiDüzenle_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAdSoyad);
            this.groupBox3.Controls.Add(this.lblTc);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.linkLabelBilgiDüzenle);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 130);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Bilgisi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(162, 58);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 16);
            this.lblAdSoyad.TabIndex = 19;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(162, 27);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(84, 16);
            this.lblTc.TabIndex = 18;
            this.lblTc.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ad- Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "TC No:";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.textİd);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.richTextBoxSikayet);
            this.groupBox4.Controls.Add(this.comboBoxDoktor);
            this.groupBox4.Controls.Add(this.comboBoxKlinik);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnRandevuOlustur);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(492, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 533);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasta İşlemleri";
            // 
            // textİd
            // 
            this.textİd.Enabled = false;
            this.textİd.Location = new System.Drawing.Point(364, 286);
            this.textİd.Name = "textİd";
            this.textİd.Size = new System.Drawing.Size(191, 22);
            this.textİd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Randevu İd:";
            // 
            // richTextBoxSikayet
            // 
            this.richTextBoxSikayet.Location = new System.Drawing.Point(364, 391);
            this.richTextBoxSikayet.Name = "richTextBoxSikayet";
            this.richTextBoxSikayet.Size = new System.Drawing.Size(194, 81);
            this.richTextBoxSikayet.TabIndex = 4;
            this.richTextBoxSikayet.Text = "";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(364, 347);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(194, 28);
            this.comboBoxDoktor.TabIndex = 3;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // comboBoxKlinik
            // 
            this.comboBoxKlinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKlinik.FormattingEnabled = true;
            this.comboBoxKlinik.Location = new System.Drawing.Point(364, 313);
            this.comboBoxKlinik.Name = "comboBoxKlinik";
            this.comboBoxKlinik.Size = new System.Drawing.Size(194, 28);
            this.comboBoxKlinik.TabIndex = 2;
            this.comboBoxKlinik.SelectedIndexChanged += new System.EventHandler(this.comboBoxKlinik_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(179, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Şikayetinizi yazınız:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(179, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Klinik seçiniz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(179, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Doktor seçiniz:";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(412, 479);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(146, 43);
            this.btnRandevuOlustur.TabIndex = 17;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // Hasta_Giris_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1071, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hasta_Giris_Ekranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Ekranı";
            this.Load += new System.EventHandler(this.Hasta_Giris_Ekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGecmisRandevular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevular)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewGecmisRandevular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewAktifRandevular;
        private System.Windows.Forms.LinkLabel linkLabelBilgiDüzenle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxSikayet;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxKlinik;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.TextBox textİd;
        private System.Windows.Forms.Label label1;
    }
}