using BinhTriThienQuanLyNhanSu.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

		public QuanLyNhanVienForm()
		{
			InitializeComponent();
		}

		private void EnableAllDataControls()
		{
			txbMaNhanVien.Enabled = true;
			txbMatKhau.Enabled = true;
			txbHo.Enabled = true;
			txbTen.Enabled = true;
			cbLoaiTaiKhoan.Enabled = true;
			cbBacXepHang.Enabled = true;
			cbPhong.Enabled = true;
			cbCung.Enabled = true;
			txbDienThoaiDiDong.Enabled = true;
			txbDienThoaiCoDinh.Enabled = true;
			txbEmail.Enabled = true;
			txbDiaChi.Enabled = true;
		}

		private void DisableAllDataControls()
		{
			txbMaNhanVien.Enabled = false;
			txbMatKhau.Enabled = false;
			txbHo.Enabled = false;
			txbTen.Enabled = false;
			cbLoaiTaiKhoan.Enabled = false;
			cbBacXepHang.Enabled = false;
			cbPhong.Enabled = false;
			cbCung.Enabled = false;
			txbDienThoaiDiDong.Enabled = false;
			txbDienThoaiCoDinh.Enabled = false;
			txbEmail.Enabled = false;
			txbDiaChi.Enabled = false;
		}

		private void ResetDataInputControls()
		{
			txbMaNhanVien.Text = "";
			txbMatKhau.Text = "";
			txbHo.Text = "";
			txbTen.Text = "";
			cbLoaiTaiKhoan.SelectedItem = null;
			cbBacXepHang.SelectedItem = null;
			cbPhong.SelectedItem = null;
			cbCung.SelectedItem = null;
			txbDienThoaiDiDong.Text = "";
			txbDienThoaiCoDinh.Text = "";
			txbEmail.Text = "";
			txbDiaChi.Text = "";
		}

		private void FetchNhanVien()
		{
			dtgvNhanVien.DataSource = context.NhanVien.Select(nhanVien => new
			{
				nhanVien.Ma,
				nhanVien.MatKhau,
				nhanVien.Ho,
				nhanVien.Ten,
				LoaiTaiKhoan = nhanVien.LoaiTaiKhoan.Ten,
				BacXepHang = nhanVien.BacXepHang.Ten,
				Phong = nhanVien.Phong.Ten,
				Cung = nhanVien.Cung.Ten,
				nhanVien.DienThoaiDiDong,
				nhanVien.DienThoaiCoDinh,
				nhanVien.Email,
				nhanVien.DiaChi,
			}).ToList();

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

		#region State Mangement
		private void GoToInitState()
		{
			ResetDataInputControls();
			DisableAllDataControls();
			btnAddNew.Visible = true;
			btnAdd.Visible = false;
			btnCancel.Visible = false;
			btnEdit.Visible = false;
			btnDelete.Visible = false;
			dtgvNhanVien.Enabled = true;
			dtgvNhanVien.ClearSelection();
		}

		private void GoToAddNewState()
		{
			EnableAllDataControls();
			ResetDataInputControls();
			btnAddNew.Visible = false;
			btnAdd.Visible = true;
			btnCancel.Visible = true;
			btnEdit.Visible = false;
			btnDelete.Visible = false;
			dtgvNhanVien.Enabled = false;
			dtgvNhanVien.ClearSelection();
		}

		private void GoToChangeState()
		{
			EnableAllDataControls();
			btnAddNew.Visible = false;
			btnAdd.Visible = false;
			btnCancel.Visible = true;
			btnEdit.Visible = true;
			btnDelete.Visible = true;
		}
		#endregion

		private bool isRequiredOk()
		{
			return !string.IsNullOrEmpty(txbMaNhanVien.Text)
				&& !string.IsNullOrEmpty(txbMatKhau.Text)
				&& !string.IsNullOrEmpty(txbHo.Text)
				&& !string.IsNullOrEmpty(txbTen.Text)
				&& cbLoaiTaiKhoan.SelectedValue != null;
		}

		#region Events
		private void QuanLyNhanVienForm_Load(object sender, EventArgs e)
		{
			FetchNhanVien();
			GoToInitState();
		}

		private void BtnAddNew_Click(object sender, EventArgs e)
		{
			GoToAddNewState();
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			if (!isRequiredOk())
			{
				string message = "Hãy nhập đúng dữ liệu trước khi lưu";
				string caption = "Lỗi nhập dữ liệu ";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
				return;
			}
			var maLoaiTaiKhoan = cbLoaiTaiKhoan.SelectedValue?.ToString();
			var loaiTaiKhoan = context.LoaiTaiKhoan.FirstOrDefault(ltk => ltk.Ma == maLoaiTaiKhoan);
			var maBacXepHang = cbBacXepHang.SelectedValue?.ToString();
			var bacXepHang = context.BacXepHang.FirstOrDefault(bxh => bxh.Ma == maBacXepHang);
			var maPhong = cbPhong.SelectedValue?.ToString();
			var phong = context.Phong.FirstOrDefault(p => p.Ma == maPhong);
			var maCung = cbCung.SelectedValue?.ToString();
			var cung = context.Cung.FirstOrDefault(c => c.Ma == maCung);
			var newNhanVien = new NhanVien()
			{
				Ma = txbMaNhanVien.Text,
				MatKhau = txbMaNhanVien.Text,
				Ho = txbHo.Text,
				Ten = txbTen.Text,
				LoaiTaiKhoan = loaiTaiKhoan,
				BacXepHang = bacXepHang,
				Phong = phong,
				Cung = cung,
				DienThoaiDiDong = txbDienThoaiDiDong.Text,
				DienThoaiCoDinh = txbDienThoaiCoDinh.Text,
				Email = txbEmail.Text,
				DiaChi = txbDiaChi.Text
			};
			context.Add(newNhanVien);
			await context.SaveChangesAsync();
			FetchNhanVien();
			GoToInitState();
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			if (!isRequiredOk())
			{
				string message = "Hãy nhập đúng dữ liệu trước khi lưu";
				string caption = "Lỗi nhập dữ liệu ";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBox.Show(message, caption, buttons);
				return;
			}
			NhanVien nhanVien = context.NhanVien.FirstOrDefault(nv => nv.Ma == txbMaNhanVien.Text);
			var maLoaiTaiKhoan = cbLoaiTaiKhoan.SelectedValue?.ToString();
			var loaiTaiKhoan = context.LoaiTaiKhoan.FirstOrDefault(ltk => ltk.Ma == maLoaiTaiKhoan);
			var maBacXepHang = cbBacXepHang.SelectedValue?.ToString();
			var bacXepHang = context.BacXepHang.FirstOrDefault(bxh => bxh.Ma == maBacXepHang);
			var maPhong = cbPhong.SelectedValue?.ToString();
			var phong = context.Phong.FirstOrDefault(p => p.Ma == maPhong);
			var maCung = cbCung.SelectedValue?.ToString();
			var cung = context.Cung.FirstOrDefault(c => c.Ma == maCung);
			if (nhanVien != null)
			{
				nhanVien.Ma = txbMaNhanVien.Text;
				nhanVien.MatKhau = txbMatKhau.Text;
				nhanVien.Ho = txbHo.Text;
				nhanVien.Ten = txbTen.Text;
				nhanVien.DienThoaiDiDong = txbDienThoaiDiDong.Text;
				nhanVien.DienThoaiCoDinh = txbDienThoaiCoDinh.Text;
				nhanVien.Email = txbEmail.Text;
				nhanVien.DiaChi = txbDiaChi.Text;
				nhanVien.LoaiTaiKhoan = loaiTaiKhoan;
				nhanVien.BacXepHang = bacXepHang;
				nhanVien.Phong = phong;
				nhanVien.Cung = cung;
				context.SaveChanges();
			}
			FetchNhanVien();
			GoToInitState();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			GoToInitState();
			dtgvNhanVien.Enabled = true;
			btnCancel.Visible = false;
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			NhanVien nhanVien = context.NhanVien.FirstOrDefault(nv => nv.Ma == txbMaNhanVien.Text);
			if (nhanVien != null)
			{
				const string message = "Bạn có chắc xóa nhân viên này ?";
				const string caption = "Xóa nhân viên";
				const MessageBoxButtons button = MessageBoxButtons.YesNo;
				const MessageBoxIcon icon = MessageBoxIcon.Warning;
				DialogResult result = MessageBox.Show(message, caption, button, icon);
				if (result == DialogResult.No) return;
				context.Remove(nhanVien);
				context.SaveChanges();
				MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				GoToInitState();
				FetchNhanVien();
			}
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
			cbBacXepHang.SelectedValue = nhanVien.BacXepHang == null ? string.Empty : nhanVien.BacXepHang.Ma;
			cbPhong.SelectedValue = nhanVien.Phong == null ? string.Empty : nhanVien.Phong.Ma;
			cbCung.SelectedValue = nhanVien.Cung == null ? string.Empty : nhanVien.Cung.Ma;

			txbDienThoaiDiDong.Text = nhanVien.DienThoaiDiDong;
			txbDienThoaiCoDinh.Text = nhanVien.DienThoaiCoDinh;
			txbEmail.Text = nhanVien.Email;
			txbDiaChi.Text = nhanVien.DiaChi;

			GoToChangeState();
		}

		private void DtgvNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (dtgvNhanVien.Rows.Count > 0) dtgvNhanVien.Rows[0].Selected = false;
		}
		#endregion
	}
}
