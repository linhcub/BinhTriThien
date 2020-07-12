namespace BinhTriThienQuanLyNhanSu
{
    partial class QuanLyNhanVienForm
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
            this.nhanVienGrid = new System.Windows.Forms.DataGridView();
            this.txbMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDienThoaiDiDong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDienThoaiCoDinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.cbLoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBacXepHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienGrid
            // 
            this.nhanVienGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienGrid.Location = new System.Drawing.Point(31, 253);
            this.nhanVienGrid.Name = "nhanVienGrid";
            this.nhanVienGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nhanVienGrid.Size = new System.Drawing.Size(886, 232);
            this.nhanVienGrid.TabIndex = 0;
            // 
            // txbMaNhanVien
            // 
            this.txbMaNhanVien.AccessibleName = "";
            this.txbMaNhanVien.Location = new System.Drawing.Point(203, 32);
            this.txbMaNhanVien.Name = "txbMaNhanVien";
            this.txbMaNhanVien.Size = new System.Drawing.Size(145, 20);
            this.txbMaNhanVien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ";
            // 
            // txbHo
            // 
            this.txbHo.AccessibleName = "";
            this.txbHo.Location = new System.Drawing.Point(203, 58);
            this.txbHo.Name = "txbHo";
            this.txbHo.Size = new System.Drawing.Size(145, 20);
            this.txbHo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // txbTen
            // 
            this.txbTen.AccessibleName = "";
            this.txbTen.Location = new System.Drawing.Point(491, 59);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(145, 20);
            this.txbTen.TabIndex = 5;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnView.Location = new System.Drawing.Point(203, 190);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 40);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Chartreuse;
            this.btnAdd.Location = new System.Drawing.Point(309, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Location = new System.Drawing.Point(415, 190);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(521, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.Location = new System.Drawing.Point(678, 32);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(142, 152);
            this.picAnhDaiDien.TabIndex = 11;
            this.picAnhDaiDien.TabStop = false;
            this.picAnhDaiDien.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điện Thoại Di Động";
            // 
            // txbDienThoaiDiDong
            // 
            this.txbDienThoaiDiDong.AccessibleName = "";
            this.txbDienThoaiDiDong.Location = new System.Drawing.Point(203, 84);
            this.txbDienThoaiDiDong.Name = "txbDienThoaiDiDong";
            this.txbDienThoaiDiDong.Size = new System.Drawing.Size(145, 20);
            this.txbDienThoaiDiDong.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điện Thoại Cố Định";
            // 
            // txbDienThoaiCoDinh
            // 
            this.txbDienThoaiCoDinh.AccessibleName = "";
            this.txbDienThoaiCoDinh.Location = new System.Drawing.Point(491, 85);
            this.txbDienThoaiCoDinh.Name = "txbDienThoaiCoDinh";
            this.txbDienThoaiCoDinh.Size = new System.Drawing.Size(145, 20);
            this.txbDienThoaiCoDinh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.AccessibleName = "";
            this.txbEmail.Location = new System.Drawing.Point(203, 138);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(433, 20);
            this.txbEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Địa Chỉ";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AccessibleName = "";
            this.txbDiaChi.Location = new System.Drawing.Point(203, 164);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(433, 20);
            this.txbDiaChi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mật Khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.AccessibleName = "";
            this.txbMatKhau.Location = new System.Drawing.Point(491, 33);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(145, 20);
            this.txbMatKhau.TabIndex = 20;
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(203, 110);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(145, 21);
            this.cbLoaiTaiKhoan.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Loại Tài Khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bậc Xếp Hạng";
            // 
            // cbBacXepHang
            // 
            this.cbBacXepHang.FormattingEnabled = true;
            this.cbBacXepHang.Location = new System.Drawing.Point(490, 111);
            this.cbBacXepHang.Name = "cbBacXepHang";
            this.cbBacXepHang.Size = new System.Drawing.Size(146, 21);
            this.cbBacXepHang.TabIndex = 25;
            // 
            // QuanLyNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbBacXepHang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbLoaiTaiKhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDienThoaiCoDinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDienThoaiDiDong);
            this.Controls.Add(this.picAnhDaiDien);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbHo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNhanVien);
            this.Controls.Add(this.nhanVienGrid);
            this.Name = "QuanLyNhanVienForm";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nhanVienGrid;
        private System.Windows.Forms.TextBox txbMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picAnhDaiDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDienThoaiDiDong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDienThoaiCoDinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.ComboBox cbLoaiTaiKhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbBacXepHang;
    }
}

