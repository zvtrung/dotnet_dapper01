using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.Model
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TieuDe { get; set; }
        public string DanhSachTacGia { get; set; } /// khác với tên cột trong CSDL!
        public int SoTrang { get; set; }
        public int MaNhaXuatBan { get; set; }
        public DateTime NgayMua { get; set; }

    }
}
