using QuanLySach.Data;
using QuanLySach.GUI;
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

namespace QuanLySach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNapLai_Click(object sender, EventArgs e)
        {
            var dataSach = new DataSach();
            //var lstSach = dataSach.GetListSach();
            var lstSach = dataSach.GetListSachFull();
            bsSach.DataSource = lstSach;
            gridSach.DataSource = bsSach;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnNapLai.PerformClick();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            var frm = new FormSach_TaoMoi();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnNapLai.PerformClick();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xem thử người dùng có đang chọn Sach hay không
            // Nếu có thì xoá + nạp lại danh sách
            // Nếu không thì báo lỗi

            Sach sach = null;
            if (bsSach.Current != null)
            {
                sach = (Sach)bsSach.Current;
            }

            if (sach == null)
            {
                MessageBox.Show("Vui lòng chọn 1 quyển sách để xoá");
            }
            else
            {
                var dataSach = new DataSach();
                dataSach.Delete(sach.MaSach);
                btnNapLai.PerformClick();
            }
        }
    }
}
