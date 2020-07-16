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

namespace BinhTriThienQuanLyNhanSu.GUI
{
    public partial class CungForm : Form
    {
        BinhTriThienContext context = new BinhTriThienContext();

        public CungForm()
        {
            InitializeComponent();
        }

        private void CungForm_Load(object sender, EventArgs e)
        {
            dtgvCung.DataSource = context.Cung.Select(cung => new
            {
                cung.Ma,
                cung.Ten,
                CungTruong = cung.CungTruongNavigation.Ho + " " + cung.CungTruongNavigation.Ten,
                CungPho = cung.CungPhoNavigation.Ho + " " + cung.CungPhoNavigation.Ten,
                AnToanVeSinhVien = cung.AnToanVeSinhVienNavigation.Ho + " " + cung.AnToanVeSinhVienNavigation.Ten,
                CongDoanVien = cung.CongDoanVienNavigation.Ho + " " + cung.CongDoanVienNavigation.Ten
            }).ToList();
        }
    }
}
