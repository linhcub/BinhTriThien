using BinhTriThienQuanLyNhanSu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BinhTriThienQuanLyNhanSu
{
	public partial class QuanLyNhanVienForm : Form
	{
		BinhTriThienContext context = new BinhTriThienContext();
		private ErrorProvider errorProviderMaNhanVien = new ErrorProvider();
		private ErrorProvider errorProviderMatKhau = new ErrorProvider();
		private ErrorProvider errorProviderHo = new ErrorProvider();
		private ErrorProvider errorProviderTen = new ErrorProvider();
		private bool isDataValid = false;
		List<NhanVienDisplay> nhanVienList;

		public QuanLyNhanVienForm()
		{
			InitializeComponent();
			View();
		}

		public class NhanVienDisplay
		{
			public string Ma;
			public string MatKhau;
			public string Ho;
			public string Ten;
			public string LoaiTaiKhoan;
			public string BacXepHang;
			public string Phong;
			public string Cung;
			public string DienThoaiDiDong;
			public string DienThoaiCoDinh;
			public string Email;
			public string DiaChi;

			public LoaiTaiKhoan LoaiTaiKhoanRef;
			public BacXepHang BacXepHangRef;
			public Phong PhongRef;
			public Cung CungRef;
		}

		private void View()
		{
			var nhanViens = context.NhanVien.Select(nhanVien => new
			{
				Ma = nhanVien.Ma,
				MatKhau = nhanVien.MatKhau,
				Ho = nhanVien.Ho,
				Ten = nhanVien.Ten,
				LoaiTaiKhoan = nhanVien.LoaiTaiKhoan.Ten,
				BacXepHang = nhanVien.BacXepHang.Ten,
				Phong = nhanVien.Phong.Ten,
				Cung = nhanVien.Cung.Ten,
				DienThoaiDiDong = nhanVien.DienThoaiDiDong,
				DienThoaiCoDinh = nhanVien.DienThoaiCoDinh,
				Email = nhanVien.Email,
				DiaChi = nhanVien.DiaChi,
			});

			var nhanVienLists = nhanViens.ToList();
			dtgvNhanVien.DataSource = nhanVienLists;

			cbLoaiTaiKhoan.DataSource = context.LoaiTaiKhoan.ToList();
			cbLoaiTaiKhoan.ValueMember = "Ma";
			cbLoaiTaiKhoan.DisplayMember = "Ten";

			cbBacXepHang.DataSource = context.BacXepHang.ToList();
			cbBacXepHang.ValueMember = "Ma";
			cbBacXepHang.DisplayMember = "Ten";

			cbPhong.DataSource = context.Phong.ToList();
			cbPhong.ValueMember = "Ma";
			cbPhong.DisplayMember = "Ten";

			cbCung.DataSource = context.Cung.ToList();
			cbCung.ValueMember = "Ma";
			cbCung.DisplayMember = "Ten";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!isDataValid)
			{
				string message = "Hãy nhập đúng dữ liệu trước khi lưu";
				string caption = "Lỗi nhập dữ liệu ";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
				return;
			}
			NhanVien nhanVien = context.NhanVien.FirstOrDefault(nv => nv.Ma == txbMaNhanVien.Text);
			if (nhanVien != null)
			{
				// sửa
				nhanVien.Ma = txbMaNhanVien.Text;
				nhanVien.MatKhau = txbMatKhau.Text;
				nhanVien.Ho = txbHo.Text;
				nhanVien.Ten = txbTen.Text;
				nhanVien.DiaChi = txbDiaChi.Text;
				nhanVien.Email = txbEmail.Text;
				nhanVien.DienThoaiDiDong = txbDienThoaiDiDong.Text;
				nhanVien.DienThoaiCoDinh = txbDienThoaiCoDinh.Text;
				//nhanVien.LoaiTaiKhoan = taiKhoanAdmin;
				//nhanVien.BacXepHang = bac1;
				context.SaveChanges();
			}
			else
			{
				// thêm
				var taiKhoanAdmin = context.LoaiTaiKhoan.First(taikhoan => taikhoan.Ma == "TK01");
				var bac1 = context.BacXepHang.First(bacxephang => bacxephang.Ma == "Bac01");
				var newNhanVien = new NhanVien()
				{
					Ma = txbMaNhanVien.Text,
					MatKhau = txbMaNhanVien.Text,
					Ho = txbHo.Text,
					Ten = txbTen.Text,
					DiaChi = txbDiaChi.Text,
					Email = txbEmail.Text,
					DienThoaiDiDong = txbDienThoaiDiDong.Text,
					DienThoaiCoDinh = txbDienThoaiCoDinh.Text,
					LoaiTaiKhoan = taiKhoanAdmin,
					BacXepHang = bac1
				};
				context.Add(newNhanVien);
				context.SaveChanges();
				dtgvNhanVien.Enabled = true;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			txbMaNhanVien.Text = "";
			txbMatKhau.Text = "";
			txbHo.Text = "";
			txbTen.Text = "";
			txbDienThoaiDiDong.Text = "";
			txbDienThoaiCoDinh.Text = "";
			txbEmail.Text = "";
			txbDiaChi.Text = "";
			cbLoaiTaiKhoan.SelectedItem = null;
			cbBacXepHang.SelectedItem = null;

			btnCancel.Visible = true;
			dtgvNhanVien.Enabled = false;
			dtgvNhanVien.ClearSelection();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			dtgvNhanVien.Enabled = true;
			btnCancel.Visible = false;
		}

		private void btnView_Click(object sender, System.EventArgs e)
		{
			View();
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			NhanVien nhanVien = context.NhanVien.FirstOrDefault(nv => nv.Ma == txbMaNhanVien.Text);
			if (nhanVien != null)
			{
				const string message = "Bạn có chắc xóa nhân viên này ?";
				const string caption = "Xóa nhân viên";
				DialogResult result = MessageBox.Show(message, caption,
											 MessageBoxButtons.YesNo,
											 MessageBoxIcon.Warning);
				if (result == DialogResult.No)
				{
					return;
				}
				context.Remove(nhanVien);
				context.SaveChanges();
				MessageBox.Show("Xóa thành công", "Thông báo",
											 MessageBoxButtons.OK,
											 MessageBoxIcon.Information);
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chưa phát triển", "Thông báo",
							 MessageBoxButtons.OK,
							 MessageBoxIcon.Information);
		}

		private void QuanLyNhanVienForm_Load(object sender, EventArgs e)
		{

		}

		#region validation
		private void validateRequired(TextBox textBox, ErrorProvider errorProvider)
		{
			if (string.IsNullOrEmpty(textBox.Text.Trim()))
			{
				errorProvider.SetError(textBox, "Bắt buộc");
				isDataValid = false;
			}
			else
			{
				errorProvider.SetError(textBox, string.Empty);
				isDataValid = true;
			}
		}

		private void txbMaNhanVien_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validateRequired(txbMaNhanVien, errorProviderMaNhanVien);
		}

		private void txbMatKhau_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validateRequired(txbMatKhau, errorProviderMatKhau);
		}

		private void txbHo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validateRequired(txbHo, errorProviderHo);
		}
		#endregion

		private void txbTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			validateRequired(txbTen, errorProviderTen);

		}

		private void DtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = dtgvNhanVien.Rows[e.RowIndex];
			string maNhanVien = row.Cells[0].Value?.ToString();
			NhanVien nhanVien = context.NhanVien
				.Include(nv => nv.LoaiTaiKhoan)
				.Include(nv => nv.BacXepHang)
				.Include(nv => nv.Phong)
				.Include(nv => nv.Cung)
				.Where(nv => nv.Ma == maNhanVien)
				.FirstOrDefault();
			txbMaNhanVien.Text = nhanVien.Ma;
			txbMatKhau.Text = nhanVien.MatKhau;
			txbHo.Text = nhanVien.Ho;
			txbTen.Text = nhanVien.Ten;

			cbLoaiTaiKhoan.SelectedValue = nhanVien.LoaiTaiKhoan.Ma;
			cbBacXepHang.SelectedValue = nhanVien.BacXepHang.Ma;
			cbPhong.SelectedValue = nhanVien.Phong == null ? string.Empty : nhanVien.Phong.Ma;
			cbCung.SelectedValue = nhanVien.Cung == null ? string.Empty : nhanVien.Cung.Ma;

			txbDienThoaiDiDong.Text = nhanVien.DienThoaiDiDong;
			txbDienThoaiCoDinh.Text = nhanVien.DienThoaiCoDinh;
			txbEmail.Text = nhanVien.Email;
			txbDiaChi.Text = nhanVien.DiaChi;
		}
	}
}
