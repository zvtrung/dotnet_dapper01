
namespace QuanLySach.GUI
{
    partial class FormSach_TaoMoi
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
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            this.lnkTaoMoiNhaXuatBan = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề:";
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(108, 17);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(342, 20);
            this.txtTieuDe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tác giả:";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(108, 43);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(342, 20);
            this.txtTacGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số trang:";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(108, 69);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(100, 20);
            this.txtSoTrang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhà xuất bản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày mua:";
            // 
            // cbxNhaXuatBan
            // 
            this.cbxNhaXuatBan.FormattingEnabled = true;
            this.cbxNhaXuatBan.Location = new System.Drawing.Point(108, 94);
            this.cbxNhaXuatBan.Name = "cbxNhaXuatBan";
            this.cbxNhaXuatBan.Size = new System.Drawing.Size(199, 21);
            this.cbxNhaXuatBan.TabIndex = 7;
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(108, 124);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(121, 20);
            this.dtpNgayMua.TabIndex = 10;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(375, 193);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 29);
            this.btnBoQua.TabIndex = 12;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(294, 193);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 29);
            this.btnDongY.TabIndex = 11;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // lnkTaoMoiNhaXuatBan
            // 
            this.lnkTaoMoiNhaXuatBan.AutoSize = true;
            this.lnkTaoMoiNhaXuatBan.Location = new System.Drawing.Point(313, 97);
            this.lnkTaoMoiNhaXuatBan.Name = "lnkTaoMoiNhaXuatBan";
            this.lnkTaoMoiNhaXuatBan.Size = new System.Drawing.Size(45, 13);
            this.lnkTaoMoiNhaXuatBan.TabIndex = 8;
            this.lnkTaoMoiNhaXuatBan.TabStop = true;
            this.lnkTaoMoiNhaXuatBan.Text = "Tạo mới";
            // 
            // FormSach_TaoMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 234);
            this.Controls.Add(this.lnkTaoMoiNhaXuatBan);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.dtpNgayMua);
            this.Controls.Add(this.cbxNhaXuatBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTieuDe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSach_TaoMoi";
            this.Text = "Tạo mới một quyển sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNhaXuatBan;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.LinkLabel lnkTaoMoiNhaXuatBan;
    }
}