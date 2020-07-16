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
    public partial class PhongForm : Form
    {
        BinhTriThienContext context = new BinhTriThienContext();

        public PhongForm()
        {
            InitializeComponent();
        }

        private void PhongForm_Load(object sender, EventArgs e)
        {
            dtgvPhong.DataSource = context.Phong.Select(phong => new
            {
                phong.MaPhong,
                phong.Ten,
                TruongPhong = phong.TruongPhongNavigation.Ho + " " + phong.TruongPhongNavigation.Ten,
                PhoPhong = phong.PhoPhongNavigation.Ho + " " + phong.PhoPhongNavigation.Ten
            }).ToList();
        }
    }
}
