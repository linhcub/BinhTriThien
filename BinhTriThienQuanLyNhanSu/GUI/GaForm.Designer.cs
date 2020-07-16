namespace BinhTriThienQuanLyNhanSu.GUI
{
    partial class GaForm
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
            this.dtgvGa = new System.Windows.Forms.DataGridView();
            this.MaGa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đang phát triển";
            // 
            // dtgvGa
            // 
            this.dtgvGa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvGa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGa,
            this.Ten,
            this.DiaChi,
            this.Cung});
            this.dtgvGa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvGa.Location = new System.Drawing.Point(0, 273);
            this.dtgvGa.Name = "dtgvGa";
            this.dtgvGa.Size = new System.Drawing.Size(1028, 285);
            this.dtgvGa.TabIndex = 2;
            // 
            // MaGa
            // 
            this.MaGa.DataPropertyName = "MaGa";
            this.MaGa.HeaderText = "Mã";
            this.MaGa.Name = "MaGa";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Ga";
            this.Ten.Name = "Ten";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Cung
            // 
            this.Cung.DataPropertyName = "Cung";
            this.Cung.HeaderText = "Cung";
            this.Cung.Name = "Cung";
            // 
            // GaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvGa);
            this.Name = "GaForm";
            this.Text = "GA";
            this.Load += new System.EventHandler(this.GaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvGa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cung;
    }
}