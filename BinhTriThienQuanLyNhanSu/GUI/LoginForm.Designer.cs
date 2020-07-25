namespace BinhTriThienQuanLyNhanSu.GUI
{
	partial class LoginForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaNhanVien = new System.Windows.Forms.TextBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.btnLogin = new FontAwesome.Sharp.IconButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnWindowClose = new FontAwesome.Sharp.IconButton();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.Gainsboro;
			this.label2.Location = new System.Drawing.Point(20, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã Nhân Viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.Gainsboro;
			this.label3.Location = new System.Drawing.Point(61, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật Khẩu";
			// 
			// txtMaNhanVien
			// 
			this.txtMaNhanVien.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtMaNhanVien.Location = new System.Drawing.Point(162, 139);
			this.txtMaNhanVien.Name = "txtMaNhanVien";
			this.txtMaNhanVien.Size = new System.Drawing.Size(220, 34);
			this.txtMaNhanVien.TabIndex = 4;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.txtMatKhau.Location = new System.Drawing.Point(162, 192);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(220, 34);
			this.txtMatKhau.TabIndex = 5;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnLogin.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
			this.btnLogin.IconColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnLogin.IconSize = 50;
			this.btnLogin.Location = new System.Drawing.Point(400, 139);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Rotation = 0D;
			this.btnLogin.Size = new System.Drawing.Size(98, 87);
			this.btnLogin.TabIndex = 6;
			this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(187, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng Nhập";
			// 
			// btnWindowClose
			// 
			this.btnWindowClose.FlatAppearance.BorderSize = 0;
			this.btnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWindowClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnWindowClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
			this.btnWindowClose.IconColor = System.Drawing.Color.Gainsboro;
			this.btnWindowClose.IconSize = 30;
			this.btnWindowClose.Location = new System.Drawing.Point(514, 12);
			this.btnWindowClose.Name = "btnWindowClose";
			this.btnWindowClose.Rotation = 0D;
			this.btnWindowClose.Size = new System.Drawing.Size(30, 30);
			this.btnWindowClose.TabIndex = 7;
			this.btnWindowClose.UseVisualStyleBackColor = true;
			this.btnWindowClose.Click += new System.EventHandler(this.BtnWindowClose_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(556, 318);
			this.Controls.Add(this.btnWindowClose);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtMaNhanVien);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMaNhanVien;
		private System.Windows.Forms.TextBox txtMatKhau;
		private FontAwesome.Sharp.IconButton btnLogin;
		private System.Windows.Forms.Label label1;
		private FontAwesome.Sharp.IconButton btnWindowClose;
	}
}