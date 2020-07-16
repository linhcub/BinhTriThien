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
    public partial class BacXepHangForm : Form
    {
        BinhTriThienContext context = new BinhTriThienContext();
        public BacXepHangForm()
        {
            InitializeComponent();
        }

        private void BacXepHangForm_Load(object sender, EventArgs e)
        {
            dtgvBacXepHang.DataSource = context.BacXepHang.Select(bxh => new
            {
                bxh.MaBacXepHang,
                bxh.Ten,
                bxh.HeSoLuong
            }).ToList();
        }
    }
}
