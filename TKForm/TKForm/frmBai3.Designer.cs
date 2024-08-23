namespace TKForm
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lblNghia = new System.Windows.Forms.Label();
            this.txbNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nghĩa:";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(132, 28);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(154, 20);
            this.txtTuMoi.TabIndex = 2;
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(132, 60);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(154, 20);
            this.txtNghia.TabIndex = 3;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(147, 101);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(75, 23);
            this.btnThemTu.TabIndex = 4;
            this.btnThemTu.Text = "Thêm từ mới";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh Sách Từ";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Location = new System.Drawing.Point(69, 203);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(217, 186);
            this.lbDanhSach.TabIndex = 6;
            this.lbDanhSach.SelectedIndexChanged += new System.EventHandler(this.lbDanhSach_SelectedIndexChanged);
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghia.Location = new System.Drawing.Point(532, 162);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(46, 18);
            this.lblNghia.TabIndex = 7;
            this.lblNghia.Text = "Nghĩa";
            // 
            // txbNghia
            // 
            this.txbNghia.Location = new System.Drawing.Point(458, 203);
            this.txbNghia.Multiline = true;
            this.txbNghia.Name = "txbNghia";
            this.txbNghia.ReadOnly = true;
            this.txbNghia.Size = new System.Drawing.Size(202, 186);
            this.txbNghia.TabIndex = 8;
            // 
            // frmBai3
            // 
            this.AcceptButton = this.btnThemTu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNghia);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.TextBox txbNghia;
    }
}