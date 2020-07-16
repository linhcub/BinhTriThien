namespace BinhTriThienQuanLyNhanSu
{
    partial class LoaiTaiKhoanForm
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
            this.dtgvLoaiTaiKhoan = new System.Windows.Forms.DataGridView();
            this.MaLoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLoaiTaiKhoan
            // 
            this.dtgvLoaiTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoaiTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiTaiKhoan,
            this.Ten,
            this.CapDo});
            this.dtgvLoaiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvLoaiTaiKhoan.Location = new System.Drawing.Point(0, 273);
            this.dtgvLoaiTaiKhoan.Name = "dtgvLoaiTaiKhoan";
            this.dtgvLoaiTaiKhoan.Size = new System.Drawing.Size(1028, 285);
            this.dtgvLoaiTaiKhoan.TabIndex = 0;
            // 
            // MaLoaiTaiKhoan
            // 
            this.MaLoaiTaiKhoan.DataPropertyName = "MaLoaiTaiKhoan";
            this.MaLoaiTaiKhoan.HeaderText = "Mã";
            this.MaLoaiTaiKhoan.Name = "MaLoaiTaiKhoan";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Loại Tài Khoản";
            this.Ten.Name = "Ten";
            // 
            // CapDo
            // 
            this.CapDo.DataPropertyName = "CapDo";
            this.CapDo.HeaderText = "Cấp Độ";
            this.CapDo.Name = "CapDo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đang phát triển";
            // 
            // LoaiTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvLoaiTaiKhoan);
            this.Name = "LoaiTaiKhoanForm";
            this.Text = "LOẠI TÀI KHOẢN";
            this.Load += new System.EventHandler(this.LoaiTaiKhoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapDo;
        private System.Windows.Forms.Label label1;
    }
}