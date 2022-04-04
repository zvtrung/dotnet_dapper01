
namespace QuanLySach.GUI
{
    partial class FormNhaXuatBan_TaoMoi
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
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLaNhaXuatBanQuocTe = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(262, 91);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 29);
            this.btnDongY.TabIndex = 11;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(343, 91);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 29);
            this.btnBoQua.TabIndex = 12;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(107, 15);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(311, 20);
            this.txtTenNhaXuatBan.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Nhà xuất bản:";
            // 
            // chkLaNhaXuatBanQuocTe
            // 
            this.chkLaNhaXuatBanQuocTe.AutoSize = true;
            this.chkLaNhaXuatBanQuocTe.Location = new System.Drawing.Point(107, 54);
            this.chkLaNhaXuatBanQuocTe.Name = "chkLaNhaXuatBanQuocTe";
            this.chkLaNhaXuatBanQuocTe.Size = new System.Drawing.Size(142, 17);
            this.chkLaNhaXuatBanQuocTe.TabIndex = 13;
            this.chkLaNhaXuatBanQuocTe.Text = "Là nhà xuất bản quốc tế";
            this.chkLaNhaXuatBanQuocTe.UseVisualStyleBackColor = true;
            // 
            // FormNhaXuatBan_TaoMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 141);
            this.Controls.Add(this.chkLaNhaXuatBanQuocTe);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.txtTenNhaXuatBan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNhaXuatBan_TaoMoi";
            this.Text = "FormNhaXuatBan_TaoMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLaNhaXuatBanQuocTe;
    }
}