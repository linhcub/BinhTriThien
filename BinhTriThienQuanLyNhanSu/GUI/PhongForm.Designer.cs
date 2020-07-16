namespace BinhTriThienQuanLyNhanSu.GUI
{
    partial class PhongForm
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
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TruongPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.Ten,
            this.TruongPhong,
            this.PhoPhong});
            this.dtgvPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvPhong.Location = new System.Drawing.Point(0, 286);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.Size = new System.Drawing.Size(1028, 272);
            this.dtgvPhong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đang phát triển";
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã";
            this.MaPhong.Name = "MaPhong";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Phòng";
            this.Ten.Name = "Ten";
            // 
            // TruongPhong
            // 
            this.TruongPhong.DataPropertyName = "TruongPhong";
            this.TruongPhong.HeaderText = "Trưởng Phòng";
            this.TruongPhong.Name = "TruongPhong";
            // 
            // PhoPhong
            // 
            this.PhoPhong.DataPropertyName = "PhoPhong";
            this.PhoPhong.HeaderText = "Phó Phòng";
            this.PhoPhong.Name = "PhoPhong";
            // 
            // PhongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvPhong);
            this.Name = "PhongForm";
            this.Text = "PHÒNG";
            this.Load += new System.EventHandler(this.PhongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruongPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoPhong;
    }
}