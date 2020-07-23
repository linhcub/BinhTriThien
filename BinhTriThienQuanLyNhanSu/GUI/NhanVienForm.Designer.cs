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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
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
			this.txbMaNhanVien = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txbHo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbTen = new System.Windows.Forms.TextBox();
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
			this.cbPhong = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cbCung = new System.Windows.Forms.ComboBox();
			this.picAnhDaiDien = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.btnEdit = new FontAwesome.Sharp.IconButton();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.btnDelete = new FontAwesome.Sharp.IconButton();
			this.btnCancel = new FontAwesome.Sharp.IconButton();
			this.btnAddNew = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAnhDaiDien)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgvNhanVien
			// 
			this.dtgvNhanVien.AllowUserToAddRows = false;
			this.dtgvNhanVien.AllowUserToDeleteRows = false;
			this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
			this.dtgvNhanVien.Location = new System.Drawing.Point(0, 256);
			this.dtgvNhanVien.Name = "dtgvNhanVien";
			this.dtgvNhanVien.RowHeadersVisible = false;
			this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgvNhanVien.Size = new System.Drawing.Size(1028, 259);
			this.dtgvNhanVien.TabIndex = 0;
			this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvNhanVien_CellClick);
			this.dtgvNhanVien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DtgvNhanVien_DataBindingComplete);
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
			// txbMaNhanVien
			// 
			this.txbMaNhanVien.AccessibleName = "";
			this.txbMaNhanVien.Location = new System.Drawing.Point(407, 24);
			this.txbMaNhanVien.MaxLength = 10;
			this.txbMaNhanVien.Name = "txbMaNhanVien";
			this.txbMaNhanVien.Size = new System.Drawing.Size(145, 19);
			this.txbMaNhanVien.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(326, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã Nhân Viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(380, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Họ";
			// 
			// txbHo
			// 
			this.txbHo.AccessibleName = "";
			this.txbHo.Location = new System.Drawing.Point(407, 48);
			this.txbHo.MaxLength = 50;
			this.txbHo.Name = "txbHo";
			this.txbHo.Size = new System.Drawing.Size(145, 19);
			this.txbHo.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(669, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tên";
			// 
			// txbTen
			// 
			this.txbTen.AccessibleName = "";
			this.txbTen.Location = new System.Drawing.Point(701, 48);
			this.txbTen.MaxLength = 50;
			this.txbTen.Name = "txbTen";
			this.txbTen.Size = new System.Drawing.Size(145, 19);
			this.txbTen.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(300, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 12);
			this.label4.TabIndex = 13;
			this.label4.Text = "Điện Thoại Di Động";
			// 
			// txbDienThoaiDiDong
			// 
			this.txbDienThoaiDiDong.AccessibleName = "";
			this.txbDienThoaiDiDong.Location = new System.Drawing.Point(406, 125);
			this.txbDienThoaiDiDong.Name = "txbDienThoaiDiDong";
			this.txbDienThoaiDiDong.Size = new System.Drawing.Size(145, 19);
			this.txbDienThoaiDiDong.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(596, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 12);
			this.label5.TabIndex = 15;
			this.label5.Text = "Điện Thoại Cố Định";
			// 
			// txbDienThoaiCoDinh
			// 
			this.txbDienThoaiCoDinh.AccessibleName = "";
			this.txbDienThoaiCoDinh.Location = new System.Drawing.Point(702, 123);
			this.txbDienThoaiCoDinh.Name = "txbDienThoaiCoDinh";
			this.txbDienThoaiCoDinh.Size = new System.Drawing.Size(144, 19);
			this.txbDienThoaiCoDinh.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(368, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "Email";
			// 
			// txbEmail
			// 
			this.txbEmail.AccessibleName = "";
			this.txbEmail.Location = new System.Drawing.Point(406, 149);
			this.txbEmail.Name = "txbEmail";
			this.txbEmail.Size = new System.Drawing.Size(440, 19);
			this.txbEmail.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(360, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 19;
			this.label7.Text = "Địa Chỉ";
			// 
			// txbDiaChi
			// 
			this.txbDiaChi.AccessibleName = "";
			this.txbDiaChi.Location = new System.Drawing.Point(406, 174);
			this.txbDiaChi.Name = "txbDiaChi";
			this.txbDiaChi.Size = new System.Drawing.Size(440, 19);
			this.txbDiaChi.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(643, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 12);
			this.label8.TabIndex = 21;
			this.label8.Text = "Mật Khẩu";
			// 
			// txbMatKhau
			// 
			this.txbMatKhau.AccessibleName = "";
			this.txbMatKhau.Location = new System.Drawing.Point(702, 24);
			this.txbMatKhau.MaxLength = 50;
			this.txbMatKhau.Name = "txbMatKhau";
			this.txbMatKhau.Size = new System.Drawing.Size(145, 19);
			this.txbMatKhau.TabIndex = 20;
			// 
			// cbLoaiTaiKhoan
			// 
			this.cbLoaiTaiKhoan.FormattingEnabled = true;
			this.cbLoaiTaiKhoan.Location = new System.Drawing.Point(406, 73);
			this.cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
			this.cbLoaiTaiKhoan.Size = new System.Drawing.Size(145, 20);
			this.cbLoaiTaiKhoan.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(326, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 12);
			this.label10.TabIndex = 24;
			this.label10.Text = "Loại Tài Khoản";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(619, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 12);
			this.label11.TabIndex = 26;
			this.label11.Text = "Bậc Xếp Hạng";
			// 
			// cbBacXepHang
			// 
			this.cbBacXepHang.FormattingEnabled = true;
			this.cbBacXepHang.Location = new System.Drawing.Point(701, 73);
			this.cbBacXepHang.Name = "cbBacXepHang";
			this.cbBacXepHang.Size = new System.Drawing.Size(146, 20);
			this.cbBacXepHang.TabIndex = 25;
			// 
			// cbPhong
			// 
			this.cbPhong.FormattingEnabled = true;
			this.cbPhong.Location = new System.Drawing.Point(406, 99);
			this.cbPhong.Name = "cbPhong";
			this.cbPhong.Size = new System.Drawing.Size(145, 20);
			this.cbPhong.TabIndex = 32;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(362, 102);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 12);
			this.label9.TabIndex = 33;
			this.label9.Text = "Phòng";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(664, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 12);
			this.label12.TabIndex = 35;
			this.label12.Text = "Cung";
			// 
			// cbCung
			// 
			this.cbCung.FormattingEnabled = true;
			this.cbCung.Location = new System.Drawing.Point(701, 98);
			this.cbCung.Name = "cbCung";
			this.cbCung.Size = new System.Drawing.Size(145, 20);
			this.cbCung.TabIndex = 34;
			// 
			// picAnhDaiDien
			// 
			this.picAnhDaiDien.Image = global::BinhTriThienQuanLyNhanSu.Properties.Resources.person;
			this.picAnhDaiDien.Location = new System.Drawing.Point(91, 24);
			this.picAnhDaiDien.Name = "picAnhDaiDien";
			this.picAnhDaiDien.Size = new System.Drawing.Size(159, 165);
			this.picAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAnhDaiDien.TabIndex = 11;
			this.picAnhDaiDien.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(558, 27);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(11, 12);
			this.label13.TabIndex = 36;
			this.label13.Text = "*";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.Color.Red;
			this.label14.Location = new System.Drawing.Point(558, 51);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(11, 12);
			this.label14.TabIndex = 37;
			this.label14.Text = "*";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(853, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(11, 12);
			this.label15.TabIndex = 38;
			this.label15.Text = "*";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.ForeColor = System.Drawing.Color.Red;
			this.label16.Location = new System.Drawing.Point(853, 51);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(11, 12);
			this.label16.TabIndex = 39;
			this.label16.Text = "*";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.ForeColor = System.Drawing.Color.Red;
			this.label17.Location = new System.Drawing.Point(558, 76);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(11, 12);
			this.label17.TabIndex = 40;
			this.label17.Text = "*";
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Orange;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
			this.btnEdit.IconColor = System.Drawing.Color.Black;
			this.btnEdit.IconSize = 25;
			this.btnEdit.Location = new System.Drawing.Point(406, 199);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Rotation = 0D;
			this.btnEdit.Size = new System.Drawing.Size(100, 30);
			this.btnEdit.TabIndex = 42;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
			this.btnAdd.IconColor = System.Drawing.Color.Black;
			this.btnAdd.IconSize = 25;
			this.btnAdd.Location = new System.Drawing.Point(406, 199);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Rotation = 0D;
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 43;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Tomato;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
			this.btnDelete.IconColor = System.Drawing.Color.Black;
			this.btnDelete.IconSize = 25;
			this.btnDelete.Location = new System.Drawing.Point(746, 199);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Rotation = 0D;
			this.btnDelete.Size = new System.Drawing.Size(100, 30);
			this.btnDelete.TabIndex = 44;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Undo;
			this.btnCancel.IconColor = System.Drawing.Color.Black;
			this.btnCancel.IconSize = 25;
			this.btnCancel.Location = new System.Drawing.Point(517, 199);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Rotation = 0D;
			this.btnCancel.Size = new System.Drawing.Size(100, 30);
			this.btnCancel.TabIndex = 46;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.LimeGreen;
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
			this.btnAddNew.IconColor = System.Drawing.Color.Black;
			this.btnAddNew.IconSize = 25;
			this.btnAddNew.Location = new System.Drawing.Point(406, 199);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Rotation = 0D;
			this.btnAddNew.Size = new System.Drawing.Size(100, 30);
			this.btnAddNew.TabIndex = 47;
			this.btnAddNew.Text = "Thêm Mới";
			this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNew_Click);
			// 
			// QuanLyNhanVienForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 515);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cbCung);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cbPhong);
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
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txbTen);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txbHo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbMaNhanVien);
			this.Controls.Add(this.dtgvNhanVien);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
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
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private FontAwesome.Sharp.IconButton btnEdit;
		private FontAwesome.Sharp.IconButton btnAdd;
		private FontAwesome.Sharp.IconButton btnDelete;
		private FontAwesome.Sharp.IconButton btnCancel;
		private FontAwesome.Sharp.IconButton btnAddNew;
	}
}

