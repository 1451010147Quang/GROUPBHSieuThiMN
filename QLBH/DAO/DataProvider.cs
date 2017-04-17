using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    class DataProvider
    {
        SqlConnection cn = new SqlConnection();
        string cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;

        public DataProvider()
        {
            cn.ConnectionString = cnStr;
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        public DataTable Laydulieu(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Laydulieu(string sql, string[] name, object[] value, int para)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < para; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ADD(string sql, string[] name, object[] value, int para)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            for (int i = 0; i < para; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return (cmd.ExecuteNonQuery());
        }

    }
}
