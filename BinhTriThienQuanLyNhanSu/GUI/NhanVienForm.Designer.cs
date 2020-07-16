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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txbMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCung = new System.Windows.Forms.ComboBox();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacXepHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoaiDiDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoaiCoDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AllowUserToAddRows = false;
            this.dtgvNhanVien.AllowUserToDeleteRows = false;
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.MatKhau,
            this.Ho,
            this.Ten,
            this.LoaiTaiKhoan,
            this.BacXepHang,
            this.Phong,
            this.Cung,
            this.DienThoaiDiDong,
            this.DienThoaiCoDinh,
            this.Email,
            this.DiaChi});
            this.dtgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvNhanVien.Location = new System.Drawing.Point(0, 277);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersVisible = false;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1028, 281);
            this.dtgvNhanVien.TabIndex = 0;
            // 
            // txbMaNhanVien
            // 
            this.txbMaNhanVien.AccessibleName = "";
            this.txbMaNhanVien.Location = new System.Drawing.Point(367, 26);
            this.txbMaNhanVien.Name = "txbMaNhanVien";
            this.txbMaNhanVien.Size = new System.Drawing.Size(145, 20);
            this.txbMaNhanVien.TabIndex = 1;
            this.txbMaNhanVien.Validating += new System.ComponentModel.CancelEventHandler(this.txbMaNhanVien_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ";
            // 
            // txbHo
            // 
            this.txbHo.AccessibleName = "";
            this.txbHo.Location = new System.Drawing.Point(367, 52);
            this.txbHo.Name = "txbHo";
            this.txbHo.Size = new System.Drawing.Size(145, 20);
            this.txbHo.TabIndex = 3;
            this.txbHo.Validating += new System.ComponentModel.CancelEventHandler(this.txbHo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // txbTen
            // 
            this.txbTen.AccessibleName = "";
            this.txbTen.Location = new System.Drawing.Point(635, 52);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(145, 20);
            this.txbTen.TabIndex = 5;
            this.txbTen.Validating += new System.ComponentModel.CancelEventHandler(this.txbTen_Validating);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(0, 250);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(74, 20);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "Làm mới";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(851, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picAnhDaiDien
            // 
            this.picAnhDaiDien.Location = new System.Drawing.Point(70, 26);
            this.picAnhDaiDien.Name = "picAnhDaiDien";
            this.picAnhDaiDien.Size = new System.Drawing.Size(159, 179);
            this.picAnhDaiDien.TabIndex = 11;
            this.picAnhDaiDien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Điện Thoại Di Động";
            // 
            // txbDienThoaiDiDong
            // 
            this.txbDienThoaiDiDong.AccessibleName = "";
            this.txbDienThoaiDiDong.Location = new System.Drawing.Point(366, 135);
            this.txbDienThoaiDiDong.Name = "txbDienThoaiDiDong";
            this.txbDienThoaiDiDong.Size = new System.Drawing.Size(145, 20);
            this.txbDienThoaiDiDong.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điện Thoại Cố Định";
            // 
            // txbDienThoaiCoDinh
            // 
            this.txbDienThoaiCoDinh.AccessibleName = "";
            this.txbDienThoaiCoDinh.Location = new System.Drawing.Point(636, 133);
            this.txbDienThoaiCoDinh.Name = "txbDienThoaiCoDinh";
            this.txbDienThoaiCoDinh.Size = new System.Drawing.Size(145, 20);
            this.txbDienThoaiCoDinh.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.AccessibleName = "";
            this.txbEmail.Location = new System.Drawing.Point(366, 161);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(415, 20);
            this.txbEmail.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Địa Chỉ";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.AccessibleName = "";
            this.txbDiaChi.Location = new System.Drawing.Point(366, 188);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(415, 20);
            this.txbDiaChi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mật Khẩu";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.AccessibleName = "";
            this.txbMatKhau.Location = new System.Drawing.Point(636, 26);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(145, 20);
            this.txbMatKhau.TabIndex = 20;
            this.txbMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txbMatKhau_Validating);
            // 
            // cbLoaiTaiKhoan
            // 
            this.cbLoaiTaiKhoan.FormattingEnabled = true;
            this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(366, 79);
            this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(145, 21);
            this.cbLoaiTaiKhoan.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Loại Tài Khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bậc Xếp Hạng";
            // 
            // cbBacXepHang
            // 
            this.cbBacXepHang.FormattingEnabled = true;
            this.cbBacXepHang.Location = new System.Drawing.Point(635, 79);
            this.cbBacXepHang.Name = "cbBacXepHang";
            this.cbBacXepHang.Size = new System.Drawing.Size(146, 21);
            this.cbBacXepHang.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(851, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(851, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(946, 250);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 20);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.Location = new System.Drawing.Point(758, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(851, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(366, 107);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(145, 21);
            this.cbPhong.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Phòng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(598, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Cung";
            // 
            // cbCung
            // 
            this.cbCung.FormattingEnabled = true;
            this.cbCung.Location = new System.Drawing.Point(635, 106);
            this.cbCung.Name = "cbCung";
            this.cbCung.Size = new System.Drawing.Size(145, 21);
            this.cbCung.TabIndex = 34;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã Nhân Viên";
            this.Ma.Name = "Ma";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // Ho
            // 
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.Name = "Ho";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.Name = "Ten";
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            // 
            // BacXepHang
            // 
            this.BacXepHang.DataPropertyName = "BacXepHang";
            this.BacXepHang.HeaderText = "Bậc Xếp Hạng";
            this.BacXepHang.Name = "BacXepHang";
            // 
            // Phong
            // 
            this.Phong.DataPropertyName = "Phong";
            this.Phong.HeaderText = "Phòng";
            this.Phong.Name = "Phong";
            // 
            // Cung
            // 
            this.Cung.DataPropertyName = "Cung";
            this.Cung.HeaderText = "Cung";
            this.Cung.Name = "Cung";
            // 
            // DienThoaiDiDong
            // 
            this.DienThoaiDiDong.DataPropertyName = "DienThoaiDiDong";
            this.DienThoaiDiDong.HeaderText = "Điện Thoại Di Động";
            this.DienThoaiDiDong.Name = "DienThoaiDiDong";
            // 
            // DienThoaiCoDinh
            // 
            this.DienThoaiCoDinh.DataPropertyName = "DienThoaiCoDinh";
            this.DienThoaiCoDinh.HeaderText = "Điện Thoại Cố Định";
            this.DienThoaiCoDinh.Name = "DienThoaiCoDinh";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // QuanLyNhanVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCung);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPhong);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
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
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbHo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbMaNhanVien);
            this.Controls.Add(this.dtgvNhanVien);
            this.Name = "QuanLyNhanVienForm";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.QuanLyNhanVienForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.TextBox txbMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Button btnView;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacXepHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoaiDiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoaiCoDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}

