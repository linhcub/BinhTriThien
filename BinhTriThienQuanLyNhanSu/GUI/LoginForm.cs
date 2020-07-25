using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinhTriThienQuanLyNhanSu.Models;

namespace BinhTriThienQuanLyNhanSu.GUI
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			using (BinhTriThienContext context = new BinhTriThienContext())
			{
				string username = txtMaNhanVien.Text;
				string password = txtMatKhau.Text;
				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				{
					string message = "Mã nhân viên hoặc mật khẩu đang trống";
					string caption = "Đăng nhập";
					MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				var nhanVien = context.NhanVien
					.Where(nv => nv.Ma == username && nv.MatKhau == password)
					.FirstOrDefault();

				if (nhanVien == null)
				{
					string message = "Mã nhân viên hoặc mật khẩu không đúng";
					string caption = "Đăng nhập";
					MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				this.Hide();
				var home = new HomeForm();
				home.setLoginUser(nhanVien);
				home.Show();
			}
		}

		private void BtnWindowClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
