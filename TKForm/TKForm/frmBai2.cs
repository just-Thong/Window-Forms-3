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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            lbKhachMua.Items.Add(lbHangHoa.SelectedItem);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            lbKhachMua.Items.Remove(lbKhachMua.SelectedItem);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach(string item in lbKhachMua.Items)
            {
                switch(item)
                {
                    case "Chuột":
                        tongTien += 100000;
                        break;
                    case "Bàn Phím":
                        tongTien += 150000;
                        break;
                    case "Máy In":
                        tongTien += 2000000;
                        break;
                    case "USB Kingmax":
                        tongTien += 200000;
                        break;
                }
            }
            lblTongTien.Text = tongTien.ToString();
        }
    }
}
