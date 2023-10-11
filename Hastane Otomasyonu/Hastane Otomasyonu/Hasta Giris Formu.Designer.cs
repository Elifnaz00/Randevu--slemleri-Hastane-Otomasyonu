namespace Hastane_Otomasyonu
{
    partial class Hasta_Giris_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hasta_Giris_Formu));
            this.btn_HastaGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedtextboxTc = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSifre = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_HastaGirisi
            // 
            this.btn_HastaGirisi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_HastaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaGirisi.Location = new System.Drawing.Point(310, 162);
            this.btn_HastaGirisi.Name = "btn_HastaGirisi";
            this.btn_HastaGirisi.Size = new System.Drawing.Size(212, 48);
            this.btn_HastaGirisi.TabIndex = 0;
            this.btn_HastaGirisi.Text = "Giris Yap";
            this.btn_HastaGirisi.UseVisualStyleBackColor = false;
            this.btn_HastaGirisi.Click += new System.EventHandler(this.btn_HastaGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C. Kimlik numaranızı giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifrenizi giriniz:";
            // 
            // maskedtextboxTc
            // 
            this.maskedtextboxTc.Location = new System.Drawing.Point(312, 80);
            this.maskedtextboxTc.Mask = "00000000000";
            this.maskedtextboxTc.Name = "maskedtextboxTc";
            this.maskedtextboxTc.Size = new System.Drawing.Size(210, 22);
            this.maskedtextboxTc.TabIndex = 7;
            // 
            // maskedTextBoxSifre
            // 
            this.maskedTextBoxSifre.Location = new System.Drawing.Point(312, 123);
            this.maskedTextBoxSifre.Mask = "0000";
            this.maskedTextBoxSifre.Name = "maskedTextBoxSifre";
            this.maskedTextBoxSifre.Size = new System.Drawing.Size(210, 22);
            this.maskedTextBoxSifre.TabIndex = 8;
            // 
            // Hasta_Giris_Formu
            // 
            this.AcceptButton = this.btn_HastaGirisi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.maskedTextBoxSifre);
            this.Controls.Add(this.maskedtextboxTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HastaGirisi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hasta_Giris_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HastaGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedtextboxTc;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSifre;
    }
}