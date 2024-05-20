using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_BanHang
{
    public class DbConnection
    {
        SqlConnection conn;
        string connection = @"SERVER=LAPTOP-7G4SD6KE\ANHTUAN_SQL; Database = QLBH;Integrated Security=True";
        public DbConnection()
        {
            conn = new SqlConnection(connection);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        } 

        public SqlConnection GetConnection() 
        {
            return conn;
        }

        public SqlDataReader Query(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;

            return cmd.ExecuteReader();
        }
    }
}
