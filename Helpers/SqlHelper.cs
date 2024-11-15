using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    static class SqlHelper
    {
        const string _connStr = "Server = .\\SQLEXPRESS;Database = AB108;Trusted_Connection=True;TrustServerCertificate=True";
        static readonly SqlConnection conn = new(_connStr);
        public static bool Exec(string cmdStr)
        {
            using SqlCommand command = new(cmdStr, conn);
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        public static DataTable Read(string cmdStr)
        {
            DataTable dt = new DataTable();
            using SqlDataAdapter sda = new(cmdStr, conn);
            conn.Open();
            sda.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
