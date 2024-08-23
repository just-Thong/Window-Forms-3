using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtNghia.Text;
            lbDanhSach.Items.Add(tu);
            list.Add(nghia);          
        }

        private void lbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbDanhSach.SelectedIndex;
            txbNghia.Text = list[stt];
        }
    }
}
