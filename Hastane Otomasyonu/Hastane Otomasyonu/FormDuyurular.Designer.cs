namespace Hastane_Otomasyonu
{
    partial class FormDuyurular
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
            this.dataGridViewDuyurular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyurular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDuyurular
            // 
            this.dataGridViewDuyurular.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDuyurular.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDuyurular.Name = "dataGridViewDuyurular";
            this.dataGridViewDuyurular.RowHeadersWidth = 51;
            this.dataGridViewDuyurular.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewDuyurular.TabIndex = 0;
            // 
            // FormDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDuyurular);
            this.Name = "FormDuyurular";
            this.Text = "FormDuyurular";
            this.Load += new System.EventHandler(this.FormDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuyurular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDuyurular;
    }
}