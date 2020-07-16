namespace BinhTriThienQuanLyNhanSu.GUI
{
    partial class CungForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCung = new System.Windows.Forms.DataGridView();
            this.MaCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CungTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CungPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnToanVeSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongDoanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Đang phát triển";
            // 
            // dtgvCung
            // 
            this.dtgvCung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCung,
            this.Ten,
            this.CungTruong,
            this.CungPho,
            this.AnToanVeSinhVien,
            this.CongDoanVien});
            this.dtgvCung.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvCung.Location = new System.Drawing.Point(0, 273);
            this.dtgvCung.Name = "dtgvCung";
            this.dtgvCung.Size = new System.Drawing.Size(1028, 285);
            this.dtgvCung.TabIndex = 4;
            // 
            // MaCung
            // 
            this.MaCung.DataPropertyName = "MaCung";
            this.MaCung.HeaderText = "Mã";
            this.MaCung.Name = "MaCung";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Cung";
            this.Ten.Name = "Ten";
            // 
            // CungTruong
            // 
            this.CungTruong.DataPropertyName = "CungTruong";
            this.CungTruong.HeaderText = "Cung Trưởng";
            this.CungTruong.Name = "CungTruong";
            // 
            // CungPho
            // 
            this.CungPho.DataPropertyName = "CungPho";
            this.CungPho.HeaderText = "Cung Phó";
            this.CungPho.Name = "CungPho";
            // 
            // AnToanVeSinhVien
            // 
            this.AnToanVeSinhVien.DataPropertyName = "AnToanVeSinhVien";
            this.AnToanVeSinhVien.HeaderText = "An Toàn Vệ Sinh Viên";
            this.AnToanVeSinhVien.Name = "AnToanVeSinhVien";
            // 
            // CongDoanVien
            // 
            this.CongDoanVien.DataPropertyName = "CongDoanVien";
            this.CongDoanVien.HeaderText = "Công Đoàn Viên";
            this.CongDoanVien.Name = "CongDoanVien";
            // 
            // CungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvCung);
            this.Name = "CungForm";
            this.Text = "CUNG";
            this.Load += new System.EventHandler(this.CungForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CungTruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CungPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnToanVeSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongDoanVien;
    }
}