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
    public partial class GaForm : Form
    {
        BinhTriThienContext context = new BinhTriThienContext();

        public GaForm()
        {
            InitializeComponent();
        }

        private void GaForm_Load(object sender, EventArgs e)
        {
            dtgvGa.DataSource = context.Ga.Select(ga => new
            {
                ga.MaGa,
                ga.Ten,
                ga.DiaChi,
                cung = ga.Cung.Ten
            }).ToList();
        }
    }
}
