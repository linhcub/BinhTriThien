using BinhTriThienQuanLyNhanSu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinhTriThienQuanLyNhanSu
{
    public partial class LoaiTaiKhoanForm : Form
    {
        BinhTriThienContext context = new BinhTriThienContext();
        public LoaiTaiKhoanForm()
        {
            InitializeComponent();
        }

        private void LoaiTaiKhoanForm_Load(object sender, EventArgs e)
        {
            dtgvLoaiTaiKhoan.DataSource = context.LoaiTaiKhoan.Select(ltk => new
            {
                ltk.Ma,
                ltk.Ten,
                ltk.CapDo
            }).ToList();
        }
    }
}
