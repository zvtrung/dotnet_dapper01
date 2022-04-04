using Dapper;
using QuanLySach.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.Data
{
    class DataNhaXuatBan
    {
        public List<NhaXuatBan> GetListNhaXuatBan()
        {
            using (var cnn = DbUtils.GetConnection())
            {
                var lst = cnn.Query<NhaXuatBan>("SELECT MaNhaXuatBan, TenNhaXuatBan FROM NhaXuatBan ORDER BY TenNhaXuatBan").ToList();
                return lst;
            }
        }
    }
}
