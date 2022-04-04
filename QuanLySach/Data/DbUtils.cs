using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.Data
{
    public static class DbUtils
    {
        public static DbConnection GetConnection()
        {
            try
            {
                var connectionString = "Server=localhost;Database=BookMan2;User Id=sa;Password=123;";
                var cnn = new SqlConnection(connectionString);

                cnn.Open();
                cnn.Close();

                return cnn;
            }
            catch (Exception exc)
            {
                throw new Exception("Không kết nối đến cơ sở dữ liệu được", exc);
            }
        }
    }
}
