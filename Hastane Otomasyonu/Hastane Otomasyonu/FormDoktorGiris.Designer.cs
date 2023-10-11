namespace Hastane_Otomasyonu
{
    partial class FormDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoktorGiris));
            this.maskedTextBoxSifre = new System.Windows.Forms.MaskedTextBox();
            this.maskedtextboxTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HastaGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxSifre
            // 
            this.maskedTextBoxSifre.Location = new System.Drawing.Point(353, 141);
            this.maskedTextBoxSifre.Mask = "0000";
            this.maskedTextBoxSifre.Name = "maskedTextBoxSifre";
            this.maskedTextBoxSifre.Size = new System.Drawing.Size(210, 22);
            this.maskedTextBoxSifre.TabIndex = 2;
            // 
            // maskedtextboxTc
            // 
            this.maskedtextboxTc.Location = new System.Drawing.Point(353, 98);
            this.maskedtextboxTc.Mask = "00000000000";
            this.maskedtextboxTc.Name = "maskedtextboxTc";
            this.maskedtextboxTc.Size = new System.Drawing.Size(210, 22);
            this.maskedtextboxTc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifrenizi Giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "T.C. Kimlik Numaranızı Giriniz:";
            // 
            // btn_HastaGirisi
            // 
            this.btn_HastaGirisi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_HastaGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HastaGirisi.Location = new System.Drawing.Point(351, 180);
            this.btn_HastaGirisi.Name = "btn_HastaGirisi";
            this.btn_HastaGirisi.Size = new System.Drawing.Size(212, 48);
            this.btn_HastaGirisi.TabIndex = 9;
            this.btn_HastaGirisi.Text = "Giris Yap";
            this.btn_HastaGirisi.UseVisualStyleBackColor = false;
            this.btn_HastaGirisi.Click += new System.EventHandler(this.btn_HastaGirisi_Click);
            // 
            // FormDoktorGiris
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
            this.Name = "FormDoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Girişi";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxSifre;
        private System.Windows.Forms.MaskedTextBox maskedtextboxTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HastaGirisi;
    }
}