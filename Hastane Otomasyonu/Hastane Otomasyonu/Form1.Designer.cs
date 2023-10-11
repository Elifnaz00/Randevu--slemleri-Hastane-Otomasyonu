namespace Hastane_Otomasyonu
{
    partial class FormGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
			this.btn_HastaGirisi = new System.Windows.Forms.Button();
			this.btn_SekreterGirisi = new System.Windows.Forms.Button();
			this.btn_DoktorGirisi = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_HastaKaydi = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_HastaGirisi
			// 
			this.btn_HastaGirisi.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btn_HastaGirisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_HastaGirisi.Location = new System.Drawing.Point(29, 386);
			this.btn_HastaGirisi.Name = "btn_HastaGirisi";
			this.btn_HastaGirisi.Size = new System.Drawing.Size(193, 47);
			this.btn_HastaGirisi.TabIndex = 0;
			this.btn_HastaGirisi.Text = "Hasta Girişi";
			this.btn_HastaGirisi.UseVisualStyleBackColor = false;
			this.btn_HastaGirisi.Click += new System.EventHandler(this.btn_HastaGirisi_Click);
			// 
			// btn_SekreterGirisi
			// 
			this.btn_SekreterGirisi.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btn_SekreterGirisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_SekreterGirisi.Location = new System.Drawing.Point(665, 387);
			this.btn_SekreterGirisi.Name = "btn_SekreterGirisi";
			this.btn_SekreterGirisi.Size = new System.Drawing.Size(193, 47);
			this.btn_SekreterGirisi.TabIndex = 1;
			this.btn_SekreterGirisi.Text = "Sekreter Girişi";
			this.btn_SekreterGirisi.UseVisualStyleBackColor = false;
			this.btn_SekreterGirisi.Click += new System.EventHandler(this.button2_Click);
			// 
			// btn_DoktorGirisi
			// 
			this.btn_DoktorGirisi.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btn_DoktorGirisi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_DoktorGirisi.Location = new System.Drawing.Point(1246, 386);
			this.btn_DoktorGirisi.Name = "btn_DoktorGirisi";
			this.btn_DoktorGirisi.Size = new System.Drawing.Size(193, 47);
			this.btn_DoktorGirisi.TabIndex = 2;
			this.btn_DoktorGirisi.Text = "Doktor Girişi";
			this.btn_DoktorGirisi.UseVisualStyleBackColor = false;
			this.btn_DoktorGirisi.Click += new System.EventHandler(this.btn_DoktorGirisi_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-19, -15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(447, 215);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(-20, -8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(442, 219);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(-35, -18);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(467, 220);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(29, 162);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(387, 197);
			this.panel1.TabIndex = 6;
			// 
			// btn_HastaKaydi
			// 
			this.btn_HastaKaydi.BackColor = System.Drawing.Color.AntiqueWhite;
			this.btn_HastaKaydi.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_HastaKaydi.Location = new System.Drawing.Point(223, 386);
			this.btn_HastaKaydi.Name = "btn_HastaKaydi";
			this.btn_HastaKaydi.Size = new System.Drawing.Size(193, 47);
			this.btn_HastaKaydi.TabIndex = 4;
			this.btn_HastaKaydi.Text = "Hasta Kaydı";
			this.btn_HastaKaydi.UseVisualStyleBackColor = false;
			this.btn_HastaKaydi.Click += new System.EventHandler(this.btn_HastaKaydi_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Bisque;
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Location = new System.Drawing.Point(550, 170);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(407, 197);
			this.panel2.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Bisque;
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Location = new System.Drawing.Point(1101, 170);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(407, 197);
			this.panel3.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1206, 30);
			this.label1.TabIndex = 9;
			this.label1.Text = "Randevu oluşturabilmek için Hastane Otomasyona kayıtlı olmak gerekmektedir. Hasta" +
    " Kaydınız bulunmuyorsa Hasta Kaydı sayfasından kaydınızı oluşturunuz.";
			// 
			// FormGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.MistyRose;
			this.ClientSize = new System.Drawing.Size(1782, 513);
			this.Controls.Add(this.btn_HastaKaydi);
			this.Controls.Add(this.btn_DoktorGirisi);
			this.Controls.Add(this.btn_SekreterGirisi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btn_HastaGirisi);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hastane Otomasyonu";
			this.Load += new System.EventHandler(this.FormGiris_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HastaGirisi;
        private System.Windows.Forms.Button btn_SekreterGirisi;
        private System.Windows.Forms.Button btn_DoktorGirisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_HastaKaydi;
        private System.Windows.Forms.Label label1;
    }
}

