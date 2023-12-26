namespace Project.PL.Forms
{
    partial class SanatciBilgileriForm
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
            txtSanatciAdi = new TextBox();
            label3 = new Label();
            dgvSanatcilar = new DataGridView();
            btnEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanatcilar).BeginInit();
            SuspendLayout();
            // 
            // txtSanatciAdi
            // 
            txtSanatciAdi.Location = new Point(12, 37);
            txtSanatciAdi.Name = "txtSanatciAdi";
            txtSanatciAdi.Size = new Size(548, 31);
            txtSanatciAdi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 6;
            label3.Text = "Sanatçı / Grup Adı";
            // 
            // dgvSanatcilar
            // 
            dgvSanatcilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanatcilar.Location = new Point(12, 100);
            dgvSanatcilar.Name = "dgvSanatcilar";
            dgvSanatcilar.RowHeadersWidth = 62;
            dgvSanatcilar.Size = new Size(548, 475);
            dgvSanatcilar.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(448, 594);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(112, 34);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // SanatciBilgileriForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 732);
            Controls.Add(btnEkle);
            Controls.Add(dgvSanatcilar);
            Controls.Add(label3);
            Controls.Add(txtSanatciAdi);
            Name = "SanatciBilgileriForm";
            Text = "Sanatcı/Grup Bilgileri Form";
            ((System.ComponentModel.ISupportInitialize)dgvSanatcilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSanatciAdi;
        private Label label3;
        private DataGridView dgvSanatcilar;
        private Button btnEkle;
    }
}