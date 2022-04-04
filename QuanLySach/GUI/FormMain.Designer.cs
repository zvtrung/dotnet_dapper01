
namespace QuanLySach
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNapLai = new System.Windows.Forms.ToolStripButton();
            this.btnTaoMoi = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridSach = new System.Windows.Forms.DataGridView();
            this.bsSach = new System.Windows.Forms.BindingSource(this.components);
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNapLai,
            this.btnTaoMoi,
            this.btnSua,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(815, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNapLai
            // 
            this.btnNapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNapLai.Image")));
            this.btnNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNapLai.Name = "btnNapLai";
            this.btnNapLai.Size = new System.Drawing.Size(64, 22);
            this.btnNapLai.Text = "Nạp lại";
            this.btnNapLai.Click += new System.EventHandler(this.btnNapLai_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoMoi.Image")));
            this.btnTaoMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(70, 22);
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gridSach
            // 
            this.gridSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTieuDe,
            this.colTacGia,
            this.colSoTrang,
            this.colMaNhaXuatBan,
            this.colNgayMua,
            this.colTenNXB});
            this.gridSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSach.Location = new System.Drawing.Point(0, 25);
            this.gridSach.Name = "gridSach";
            this.gridSach.Size = new System.Drawing.Size(815, 305);
            this.gridSach.TabIndex = 2;
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 80;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Visible = false;
            this.colMaSach.Width = 80;
            // 
            // colTieuDe
            // 
            this.colTieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTieuDe.DataPropertyName = "TieuDe";
            this.colTieuDe.HeaderText = "Tiêu đề";
            this.colTieuDe.MinimumWidth = 150;
            this.colTieuDe.Name = "colTieuDe";
            // 
            // colTacGia
            // 
            this.colTacGia.DataPropertyName = "DanhSachTacGia";
            this.colTacGia.HeaderText = "Tác giả";
            this.colTacGia.MinimumWidth = 160;
            this.colTacGia.Name = "colTacGia";
            this.colTacGia.Width = 160;
            // 
            // colSoTrang
            // 
            this.colSoTrang.DataPropertyName = "SoTrang";
            this.colSoTrang.HeaderText = "Số trang";
            this.colSoTrang.Name = "colSoTrang";
            // 
            // colMaNhaXuatBan
            // 
            this.colMaNhaXuatBan.DataPropertyName = "MaNhaXuatBan";
            this.colMaNhaXuatBan.HeaderText = "Mã NXB";
            this.colMaNhaXuatBan.Name = "colMaNhaXuatBan";
            this.colMaNhaXuatBan.Visible = false;
            // 
            // colNgayMua
            // 
            this.colNgayMua.DataPropertyName = "NgayMua";
            this.colNgayMua.HeaderText = "Ngày mua";
            this.colNgayMua.Name = "colNgayMua";
            // 
            // colTenNXB
            // 
            this.colTenNXB.DataPropertyName = "TenNhaXuatBan";
            this.colTenNXB.HeaderText = "TenNXB";
            this.colTenNXB.Name = "colTenNXB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 352);
            this.Controls.Add(this.gridSach);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNapLai;
        private System.Windows.Forms.ToolStripButton btnTaoMoi;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView gridSach;
        private System.Windows.Forms.BindingSource bsSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNXB;
    }
}

