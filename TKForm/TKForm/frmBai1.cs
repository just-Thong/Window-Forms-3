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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(tbSoLuong.Text);
            int donGia = int.Parse(tbDonGia.Text);
            int thanhTien = soLuong * donGia;
             lblSoTien.Text=thanhTien.ToString();
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "5600000";
            pictureBox1.Image = TKForm.Properties.Resources.VenenoBlue;
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "6000000";
            pictureBox1.Image = TKForm.Properties.Resources.VenenoRed;
        }

        private void rdXam_CheckedChanged(object sender, EventArgs e)
        {
            tbDonGia.Text = "5700000";
            pictureBox1.Image = TKForm.Properties.Resources.VenenoGray;
        }

      
    }
}
