namespace TKForm
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.lbHangHoa = new System.Windows.Forms.ListBox();
            this.lblHangHoa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.lbKhachMua = new System.Windows.Forms.ListBox();
            this.lblKhachMua = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.lbHangHoa);
            this.panel1.Controls.Add(this.lblHangHoa);
            this.panel1.Location = new System.Drawing.Point(25, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 322);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(234, 121);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(75, 23);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn Hàng";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // lbHangHoa
            // 
            this.lbHangHoa.FormattingEnabled = true;
            this.lbHangHoa.Items.AddRange(new object[] {
            "Chuột",
            "Bàn Phím",
            "Máy In",
            "USB Kingmax"});
            this.lbHangHoa.Location = new System.Drawing.Point(21, 55);
            this.lbHangHoa.Name = "lbHangHoa";
            this.lbHangHoa.Size = new System.Drawing.Size(196, 160);
            this.lbHangHoa.TabIndex = 1;
            // 
            // lblHangHoa
            // 
            this.lblHangHoa.AutoSize = true;
            this.lblHangHoa.Location = new System.Drawing.Point(71, 18);
            this.lblHangHoa.Name = "lblHangHoa";
            this.lblHangHoa.Size = new System.Drawing.Size(107, 13);
            this.lblHangHoa.TabIndex = 0;
            this.lblHangHoa.Text = "Danh sách hàng hóa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.lbKhachMua);
            this.panel2.Controls.Add(this.lblKhachMua);
            this.panel2.Location = new System.Drawing.Point(445, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 322);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(160, 273);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(15, 24);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(183, 233);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(17, 121);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(75, 23);
            this.btnBoHang.TabIndex = 2;
            this.btnBoHang.Text = "Bỏ Hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // lbKhachMua
            // 
            this.lbKhachMua.FormattingEnabled = true;
            this.lbKhachMua.Location = new System.Drawing.Point(107, 55);
            this.lbKhachMua.Name = "lbKhachMua";
            this.lbKhachMua.Size = new System.Drawing.Size(196, 160);
            this.lbKhachMua.TabIndex = 1;
            // 
            // lblKhachMua
            // 
            this.lblKhachMua.AutoSize = true;
            this.lblKhachMua.Location = new System.Drawing.Point(146, 18);
            this.lblKhachMua.Name = "lblKhachMua";
            this.lblKhachMua.Size = new System.Drawing.Size(129, 13);
            this.lblKhachMua.TabIndex = 0;
            this.lblKhachMua.Text = "Các mặt hàng khách mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "đ";
            // 
            // frmBai2
            // 
            this.AcceptButton = this.btnThanhToan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán phụ kiện máy tính";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox lbHangHoa;
        private System.Windows.Forms.Label lblHangHoa;
        private System.Windows.Forms.ListBox lbKhachMua;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.Label lblKhachMua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label2;
    }
}