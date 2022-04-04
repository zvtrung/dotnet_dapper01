using Dapper;
using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.Data
{
    public class DataSach
    {
        public List<Sach> GetListSach()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = "SELECT MaSach, TieuDe, TacGia AS DanhSachTacGia, SoTrang, MaNhaXuatBan, NgayMua FROM Sach";
                var lstSach = cnn.Query<Sach>(sql).ToList();
                return lstSach;
            }
        }

        /// <summary>
        /// Lấy danh sách các quyển sách -- kèm thông tin tên nhà xuất bản
        /// </summary>
        /// <returns></returns>
        public List<SachFull> GetListSachFull()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"SELECT Sach.MaSach, Sach.TieuDe, Sach.TacGia AS DanhSachTacGia, Sach.SoTrang, Sach.MaNhaXuatBan, Sach.NgayMua, NhaXuatBan.TenNhaXuatBan
                                FROM NhaXuatBan INNER JOIN
                                Sach ON NhaXuatBan.MaNhaXuatBan = Sach.MaNhaXuatBan";
                var lstSach = cnn.Query<SachFull>(sql).ToList();
                return lstSach;
            }
        }

        internal bool Insert(string tieuDe, string tacGia, int soTrang, int maNhaXuatBan, DateTime ngayMua)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql =
                    @"INSERT INTO Sach (TieuDe, TacGia, SoTrang, MaNhaXuatBan, NgayMua)
                    VALUES (@TieuDe, @TacGia, @SoTrang, @MaNhaXuatBan, @NgayMua)";

                var param = new
                {
                    TieuDe = tieuDe,
                    TacGia = tacGia,
                    SoTrang = soTrang,
                    MaNhaXuatBan = maNhaXuatBan,
                    NgayMua = ngayMua
                };

                //int nEffectedRows = cnn.Execute(sql, param);
                
                int nEffectedRows = cnn.Execute("sp_Sach_Insert", param, commandType: CommandType.StoredProcedure);
                
                return nEffectedRows == 1;
            }
        }

        public bool Delete(int maSach)
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var sql = @"DELETE FROM Sach WHERE (MaSach = @MaSach)";
                var param = new { MaSach = maSach };
                int nEffectedRows = cnn.Execute(sql, param);
                return nEffectedRows == 1;
            }
        }
    }
}
