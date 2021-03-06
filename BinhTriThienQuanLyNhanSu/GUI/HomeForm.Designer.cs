﻿namespace BinhTriThienQuanLyNhanSu.GUI
{
    partial class HomeForm
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
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnLoaiTaiKhoan = new FontAwesome.Sharp.IconButton();
			this.btnBacXepHang = new FontAwesome.Sharp.IconButton();
			this.btnGa = new FontAwesome.Sharp.IconButton();
			this.btnCung = new FontAwesome.Sharp.IconButton();
			this.btnPhong = new FontAwesome.Sharp.IconButton();
			this.btnNhanVien = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.btnMinimize = new FontAwesome.Sharp.IconButton();
			this.btnMaximize = new FontAwesome.Sharp.IconButton();
			this.btnExit = new FontAwesome.Sharp.IconButton();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.lblUsername = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.panelTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
			this.panelDesktop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.Controls.Add(this.btnLoaiTaiKhoan);
			this.panelMenu.Controls.Add(this.btnBacXepHang);
			this.panelMenu.Controls.Add(this.btnGa);
			this.panelMenu.Controls.Add(this.btnCung);
			this.panelMenu.Controls.Add(this.btnPhong);
			this.panelMenu.Controls.Add(this.btnNhanVien);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(220, 629);
			this.panelMenu.TabIndex = 0;
			// 
			// btnLoaiTaiKhoan
			// 
			this.btnLoaiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnLoaiTaiKhoan.FlatAppearance.BorderSize = 0;
			this.btnLoaiTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoaiTaiKhoan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnLoaiTaiKhoan.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnLoaiTaiKhoan.IconChar = FontAwesome.Sharp.IconChar.UserCog;
			this.btnLoaiTaiKhoan.IconColor = System.Drawing.Color.Gainsboro;
			this.btnLoaiTaiKhoan.IconSize = 32;
			this.btnLoaiTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoaiTaiKhoan.Location = new System.Drawing.Point(0, 404);
			this.btnLoaiTaiKhoan.Name = "btnLoaiTaiKhoan";
			this.btnLoaiTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnLoaiTaiKhoan.Rotation = 0D;
			this.btnLoaiTaiKhoan.Size = new System.Drawing.Size(220, 55);
			this.btnLoaiTaiKhoan.TabIndex = 6;
			this.btnLoaiTaiKhoan.Text = "Loại Tài Khoản";
			this.btnLoaiTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLoaiTaiKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLoaiTaiKhoan.UseVisualStyleBackColor = true;
			this.btnLoaiTaiKhoan.Click += new System.EventHandler(this.btnLoaiTaiKhoan_Click);
			// 
			// btnBacXepHang
			// 
			this.btnBacXepHang.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnBacXepHang.FlatAppearance.BorderSize = 0;
			this.btnBacXepHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBacXepHang.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnBacXepHang.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnBacXepHang.IconChar = FontAwesome.Sharp.IconChar.Medal;
			this.btnBacXepHang.IconColor = System.Drawing.Color.Gainsboro;
			this.btnBacXepHang.IconSize = 32;
			this.btnBacXepHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBacXepHang.Location = new System.Drawing.Point(0, 349);
			this.btnBacXepHang.Name = "btnBacXepHang";
			this.btnBacXepHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnBacXepHang.Rotation = 0D;
			this.btnBacXepHang.Size = new System.Drawing.Size(220, 55);
			this.btnBacXepHang.TabIndex = 5;
			this.btnBacXepHang.Text = "Bậc Xếp Hạng";
			this.btnBacXepHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBacXepHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBacXepHang.UseVisualStyleBackColor = true;
			this.btnBacXepHang.Click += new System.EventHandler(this.btnBacXepHang_Click);
			// 
			// btnGa
			// 
			this.btnGa.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGa.FlatAppearance.BorderSize = 0;
			this.btnGa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGa.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnGa.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnGa.IconChar = FontAwesome.Sharp.IconChar.Train;
			this.btnGa.IconColor = System.Drawing.Color.Gainsboro;
			this.btnGa.IconSize = 32;
			this.btnGa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGa.Location = new System.Drawing.Point(0, 294);
			this.btnGa.Name = "btnGa";
			this.btnGa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnGa.Rotation = 0D;
			this.btnGa.Size = new System.Drawing.Size(220, 55);
			this.btnGa.TabIndex = 4;
			this.btnGa.Text = "Ga";
			this.btnGa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGa.UseVisualStyleBackColor = true;
			this.btnGa.Click += new System.EventHandler(this.btnGa_Click);
			// 
			// btnCung
			// 
			this.btnCung.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCung.FlatAppearance.BorderSize = 0;
			this.btnCung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCung.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnCung.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnCung.IconChar = FontAwesome.Sharp.IconChar.Subway;
			this.btnCung.IconColor = System.Drawing.Color.Gainsboro;
			this.btnCung.IconSize = 32;
			this.btnCung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCung.Location = new System.Drawing.Point(0, 239);
			this.btnCung.Name = "btnCung";
			this.btnCung.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnCung.Rotation = 0D;
			this.btnCung.Size = new System.Drawing.Size(220, 55);
			this.btnCung.TabIndex = 3;
			this.btnCung.Text = "Cung";
			this.btnCung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCung.UseVisualStyleBackColor = true;
			this.btnCung.Click += new System.EventHandler(this.btnCung_Click);
			// 
			// btnPhong
			// 
			this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnPhong.FlatAppearance.BorderSize = 0;
			this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPhong.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnPhong.IconChar = FontAwesome.Sharp.IconChar.Building;
			this.btnPhong.IconColor = System.Drawing.Color.Gainsboro;
			this.btnPhong.IconSize = 32;
			this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPhong.Location = new System.Drawing.Point(0, 184);
			this.btnPhong.Name = "btnPhong";
			this.btnPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnPhong.Rotation = 0D;
			this.btnPhong.Size = new System.Drawing.Size(220, 55);
			this.btnPhong.TabIndex = 2;
			this.btnPhong.Text = "Phòng";
			this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPhong.UseVisualStyleBackColor = true;
			this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
			// 
			// btnNhanVien
			// 
			this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNhanVien.FlatAppearance.BorderSize = 0;
			this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNhanVien.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.User;
			this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
			this.btnNhanVien.IconSize = 32;
			this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhanVien.Location = new System.Drawing.Point(0, 129);
			this.btnNhanVien.Name = "btnNhanVien";
			this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnNhanVien.Rotation = 0D;
			this.btnNhanVien.Size = new System.Drawing.Size(220, 55);
			this.btnNhanVien.TabIndex = 1;
			this.btnNhanVien.Text = "Nhân Viên";
			this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNhanVien.UseVisualStyleBackColor = true;
			this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.btnHome);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(220, 129);
			this.panelLogo.TabIndex = 0;
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnHome.Image = global::BinhTriThienQuanLyNhanSu.Properties.Resources.logo_binhtrithien;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(220, 129);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelTitleBar
			// 
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panelTitleBar.Controls.Add(this.pictureBox1);
			this.panelTitleBar.Controls.Add(this.lblUsername);
			this.panelTitleBar.Controls.Add(this.btnMinimize);
			this.panelTitleBar.Controls.Add(this.btnMaximize);
			this.panelTitleBar.Controls.Add(this.btnExit);
			this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
			this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
			this.panelTitleBar.Name = "panelTitleBar";
			this.panelTitleBar.Size = new System.Drawing.Size(1044, 69);
			this.panelTitleBar.TabIndex = 1;
			this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
			this.btnMinimize.IconSize = 20;
			this.btnMinimize.Location = new System.Drawing.Point(935, 11);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Rotation = 0D;
			this.btnMinimize.Size = new System.Drawing.Size(25, 23);
			this.btnMinimize.TabIndex = 4;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
			// 
			// btnMaximize
			// 
			this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximize.FlatAppearance.BorderSize = 0;
			this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
			this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
			this.btnMaximize.IconSize = 20;
			this.btnMaximize.Location = new System.Drawing.Point(971, 11);
			this.btnMaximize.Name = "btnMaximize";
			this.btnMaximize.Rotation = 0D;
			this.btnMaximize.Size = new System.Drawing.Size(25, 23);
			this.btnMaximize.TabIndex = 3;
			this.btnMaximize.UseVisualStyleBackColor = true;
			this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
			this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
			this.btnExit.IconSize = 20;
			this.btnExit.Location = new System.Drawing.Point(1007, 11);
			this.btnExit.Name = "btnExit";
			this.btnExit.Rotation = 0D;
			this.btnExit.Size = new System.Drawing.Size(25, 23);
			this.btnExit.TabIndex = 2;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblTitleChildForm.Location = new System.Drawing.Point(56, 32);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(83, 12);
			this.lblTitleChildForm.TabIndex = 1;
			this.lblTitleChildForm.Text = "TRANG CHÍNH";
			// 
			// iconCurrentChildForm
			// 
			this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
			this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
			this.iconCurrentChildForm.IconSize = 30;
			this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 24);
			this.iconCurrentChildForm.Name = "iconCurrentChildForm";
			this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 30);
			this.iconCurrentChildForm.TabIndex = 0;
			this.iconCurrentChildForm.TabStop = false;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(220, 69);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(1044, 8);
			this.panelShadow.TabIndex = 2;
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.panelDesktop.Controls.Add(this.label2);
			this.panelDesktop.Controls.Add(this.label1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(220, 77);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1044, 552);
			this.panelDesktop.TabIndex = 3;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblUsername.Location = new System.Drawing.Point(798, 25);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(44, 20);
			this.lblUsername.TabIndex = 5;
			this.lblUsername.Text = "Linh";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::BinhTriThienQuanLyNhanSu.Properties.Resources.person;
			this.pictureBox1.Location = new System.Drawing.Point(729, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(63, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.Tomato;
			this.label1.Location = new System.Drawing.Point(357, 188);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(366, 54);
			this.label1.TabIndex = 0;
			this.label1.Text = "Quản lí nhân sự";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.Tomato;
			this.label2.Location = new System.Drawing.Point(277, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(497, 67);
			this.label2.TabIndex = 1;
			this.label2.Text = "BÌNH TRỊ THIÊN";
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 629);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitleBar);
			this.Controls.Add(this.panelMenu);
			this.Name = "HomeForm";
			this.Text = "BINH TRI THIEN";
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnBacXepHang;
        private FontAwesome.Sharp.IconButton btnGa;
        private FontAwesome.Sharp.IconButton btnCung;
        private FontAwesome.Sharp.IconButton btnPhong;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnLoaiTaiKhoan;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}