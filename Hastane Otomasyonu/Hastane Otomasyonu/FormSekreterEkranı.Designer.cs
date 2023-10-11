namespace Hastane_Otomasyonu
{
    partial class FormSekreterEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSekreterEkranı));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.Label();
            this.txtSekreterTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richtxtDuyuru1 = new System.Windows.Forms.RichTextBox();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnOluştur = new System.Windows.Forms.Button();
            this.richtxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.cmbboxDoktor = new System.Windows.Forms.ComboBox();
            this.cmbboxKlinik = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtİd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBranslar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDoktorlar = new System.Windows.Forms.DataGridView();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDoktorPaneli = new System.Windows.Forms.Button();
            this.btnKlinikPaneli = new System.Windows.Forms.Button();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtSekreterTC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(117, 64);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(72, 20);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(117, 32);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(108, 20);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "00000000000";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AutoSize = true;
            this.txtAdSoyad.Location = new System.Drawing.Point(6, 64);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.txtAdSoyad.TabIndex = 2;
            this.txtAdSoyad.Text = "Ad Soyad:";
            // 
            // txtSekreterTC
            // 
            this.txtSekreterTC.AutoSize = true;
            this.txtSekreterTC.Location = new System.Drawing.Point(6, 32);
            this.txtSekreterTC.Name = "txtSekreterTC";
            this.txtSekreterTC.Size = new System.Drawing.Size(112, 20);
            this.txtSekreterTC.TabIndex = 1;
            this.txtSekreterTC.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.richtxtDuyuru1);
            this.groupBox2.Controls.Add(this.btnDuyurular);
            this.groupBox2.Controls.Add(this.btnOluştur);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(465, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 413);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // richtxtDuyuru1
            // 
            this.richtxtDuyuru1.Location = new System.Drawing.Point(25, 21);
            this.richtxtDuyuru1.Name = "richtxtDuyuru1";
            this.richtxtDuyuru1.Size = new System.Drawing.Size(358, 234);
            this.richtxtDuyuru1.TabIndex = 16;
            this.richtxtDuyuru1.Text = "";
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDuyurular.Location = new System.Drawing.Point(104, 330);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(174, 50);
            this.btnDuyurular.TabIndex = 15;
            this.btnDuyurular.Text = "Duyuruları Görüntüle";
            this.btnDuyurular.UseVisualStyleBackColor = false;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnOluştur
            // 
            this.btnOluştur.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOluştur.Location = new System.Drawing.Point(104, 287);
            this.btnOluştur.Name = "btnOluştur";
            this.btnOluştur.Size = new System.Drawing.Size(174, 38);
            this.btnOluştur.TabIndex = 2;
            this.btnOluştur.Text = "Duyuru Oluştur";
            this.btnOluştur.UseVisualStyleBackColor = false;
            this.btnOluştur.Click += new System.EventHandler(this.btnOluştur_Click);
            // 
            // richtxtDuyuru
            // 
            this.richtxtDuyuru.Location = new System.Drawing.Point(-116, 23);
            this.richtxtDuyuru.Name = "richtxtDuyuru";
            this.richtxtDuyuru.Size = new System.Drawing.Size(449, 72);
            this.richtxtDuyuru.TabIndex = 2;
            this.richtxtDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.btnRandevuOlustur);
            this.groupBox3.Controls.Add(this.maskedTextBoxTc);
            this.groupBox3.Controls.Add(this.cmbboxDoktor);
            this.groupBox3.Controls.Add(this.cmbboxKlinik);
            this.groupBox3.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox3.Controls.Add(this.txtİd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 413);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDurum.Location = new System.Drawing.Point(197, 287);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(82, 24);
            this.checkBoxDurum.TabIndex = 13;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRandevuOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuOlustur.Location = new System.Drawing.Point(197, 330);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(195, 50);
            this.btnRandevuOlustur.TabIndex = 3;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTc.Location = new System.Drawing.Point(197, 228);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(195, 27);
            this.maskedTextBoxTc.TabIndex = 12;
            // 
            // cmbboxDoktor
            // 
            this.cmbboxDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxDoktor.FormattingEnabled = true;
            this.cmbboxDoktor.Location = new System.Drawing.Point(197, 191);
            this.cmbboxDoktor.Name = "cmbboxDoktor";
            this.cmbboxDoktor.Size = new System.Drawing.Size(195, 28);
            this.cmbboxDoktor.TabIndex = 11;
            this.cmbboxDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbboxDoktor_SelectedIndexChanged);
            // 
            // cmbboxKlinik
            // 
            this.cmbboxKlinik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbboxKlinik.FormattingEnabled = true;
            this.cmbboxKlinik.Location = new System.Drawing.Point(199, 152);
            this.cmbboxKlinik.Name = "cmbboxKlinik";
            this.cmbboxKlinik.Size = new System.Drawing.Size(195, 28);
            this.cmbboxKlinik.TabIndex = 10;
            this.cmbboxKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbboxKlinik_SelectedIndexChanged);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(199, 113);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(195, 27);
            this.maskedTextBoxSaat.TabIndex = 9;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(199, 79);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(195, 27);
            this.maskedTextBoxTarih.TabIndex = 8;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtİd
            // 
            this.txtİd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİd.Location = new System.Drawing.Point(199, 45);
            this.txtİd.Name = "txtİd";
            this.txtİd.Size = new System.Drawing.Size(195, 27);
            this.txtİd.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hasta TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Klinik Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Randevu Saati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Randevu Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu İd:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewBranslar);
            this.groupBox4.Controls.Add(this.richtxtDuyuru);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(885, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 242);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridViewBranslar
            // 
            this.dataGridViewBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBranslar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBranslar.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewBranslar.Name = "dataGridViewBranslar";
            this.dataGridViewBranslar.RowHeadersWidth = 51;
            this.dataGridViewBranslar.RowTemplate.Height = 24;
            this.dataGridViewBranslar.Size = new System.Drawing.Size(465, 216);
            this.dataGridViewBranslar.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewDoktorlar);
            this.groupBox5.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(888, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(474, 258);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridViewDoktorlar
            // 
            this.dataGridViewDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktorlar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoktorlar.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewDoktorlar.Name = "dataGridViewDoktorlar";
            this.dataGridViewDoktorlar.RowHeadersWidth = 51;
            this.dataGridViewDoktorlar.RowTemplate.Height = 24;
            this.dataGridViewDoktorlar.Size = new System.Drawing.Size(468, 235);
            this.dataGridViewDoktorlar.TabIndex = 0;
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(0, 78);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(223, 38);
            this.btnDuyuruOlustur.TabIndex = 6;
            this.btnDuyuruOlustur.Text = "Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDoktorPaneli);
            this.groupBox6.Controls.Add(this.btnKlinikPaneli);
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(465, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 112);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDoktorPaneli.Location = new System.Drawing.Point(16, 23);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(103, 63);
            this.btnDoktorPaneli.TabIndex = 7;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.UseVisualStyleBackColor = false;
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // btnKlinikPaneli
            // 
            this.btnKlinikPaneli.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnKlinikPaneli.Location = new System.Drawing.Point(141, 23);
            this.btnKlinikPaneli.Name = "btnKlinikPaneli";
            this.btnKlinikPaneli.Size = new System.Drawing.Size(100, 63);
            this.btnKlinikPaneli.TabIndex = 8;
            this.btnKlinikPaneli.Text = "Klinik Paneli";
            this.btnKlinikPaneli.UseVisualStyleBackColor = false;
            this.btnKlinikPaneli.Click += new System.EventHandler(this.btnKlinikPaneli_Click);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnRandevuListe.Location = new System.Drawing.Point(264, 23);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(101, 63);
            this.btnRandevuListe.TabIndex = 2;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = false;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // FormSekreterEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1375, 573);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSekreterEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Ekranı";
            this.Load += new System.EventHandler(this.FormSekreterEkranı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBranslar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label txtAdSoyad;
        private System.Windows.Forms.Label txtSekreterTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOluştur;
        private System.Windows.Forms.RichTextBox richtxtDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbboxKlinik;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.TextBox txtİd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.ComboBox cmbboxDoktor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBranslar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewDoktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.Button btnDoktorPaneli;
        private System.Windows.Forms.Button btnKlinikPaneli;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.RichTextBox richtxtDuyuru1;
    }
}