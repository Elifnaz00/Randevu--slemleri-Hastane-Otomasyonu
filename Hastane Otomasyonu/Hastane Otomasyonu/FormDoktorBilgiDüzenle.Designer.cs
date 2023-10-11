namespace Hastane_Otomasyonu
{
    partial class FormDoktorBilgiDüzenle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorBilgiDüzenle));
			this.msdTC = new System.Windows.Forms.MaskedTextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// msdTC
			// 
			this.msdTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.msdTC.Location = new System.Drawing.Point(322, 44);
			this.msdTC.Mask = "00000000000";
			this.msdTC.Name = "msdTC";
			this.msdTC.Size = new System.Drawing.Size(229, 27);
			this.msdTC.TabIndex = 29;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(322, 138);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(229, 27);
			this.txtSoyad.TabIndex = 28;
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(322, 95);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(229, 27);
			this.txtAd.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(79, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "Soyad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(79, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 20);
			this.label2.TabIndex = 25;
			this.label2.Text = "Ad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(79, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 24;
			this.label1.Text = "TC Kimlik No:";
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(322, 230);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(229, 27);
			this.txtSifre.TabIndex = 31;
			this.txtSifre.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(79, 231);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 20);
			this.label6.TabIndex = 30;
			this.label6.Text = "Şifre:";
			// 
			// cmbBrans
			// 
			this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Location = new System.Drawing.Point(322, 187);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(229, 28);
			this.cmbBrans.TabIndex = 32;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(80, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 20);
			this.label3.TabIndex = 33;
			this.label3.Text = "Branş";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(322, 287);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(229, 53);
			this.btnGuncelle.TabIndex = 34;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			// 
			// FormDoktorBilgiDüzenle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.OldLace;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbBrans);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.msdTC);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormDoktorBilgiDüzenle";
			this.Text = "Doktor Bilgi Düzenle";
			this.Load += new System.EventHandler(this.FormDoktorBilgiDüzenle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msdTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
    }
}