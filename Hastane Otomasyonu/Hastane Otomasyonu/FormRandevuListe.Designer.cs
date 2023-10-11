namespace Hastane_Otomasyonu
{
    partial class FormRandevuListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRandevuListe));
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewListe.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.RowTemplate.Height = 24;
            this.dataGridViewListe.Size = new System.Drawing.Size(920, 450);
            this.dataGridViewListe.TabIndex = 0;
            // 
            // FormRandevuListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.dataGridViewListe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRandevuListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FormRandevuListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListe;
    }
}