using QuanLySach.Data;
using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.GUI
{
    public partial class FormSach_TaoMoi : Form
    {
        public FormSach_TaoMoi()
        {
            InitializeComponent();

            // Nạp danh sách các nhà xuất bản vào combobox
            var dataNXB = new DataNhaXuatBan();
            var lstNXB = dataNXB.GetListNhaXuatBan();
            cbxNhaXuatBan.DisplayMember = "TenNhaXuatBan";
            cbxNhaXuatBan.DataSource = lstNXB;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            #region Thu thập dữ liệu trên GUI
            var tieuDe = txtTieuDe.Text.Trim();
            var tacGia = txtTacGia.Text.Trim();
            
            var stSoTrang = txtSoTrang.Text.Trim();
            var soTrang = Int32.Parse(stSoTrang);

            var maNhaXuatBan = -1;
            if (cbxNhaXuatBan.SelectedItem != null)
            {
                var nxb = (NhaXuatBan)cbxNhaXuatBan.SelectedItem;
                maNhaXuatBan = nxb.MaNhaXuatBan;
            }

            var ngayMua = dtpNgayMua.Value;
            #endregion

            #region Thực hiện update lên CSDL
            var dataSach = new DataSach();
            dataSach.Insert(tieuDe, tacGia, soTrang, maNhaXuatBan, ngayMua);

            this.DialogResult = DialogResult.OK;
            this.Close();
            #endregion
        }
    }
}
