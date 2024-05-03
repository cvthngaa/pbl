using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    internal class DBHelper
    {
        private SqlConnection _conn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string s = @"Data Source=LAPTOP-VOUN1RK2\CVTHNGA;Initial Catalog=PBL3;Integrated Security=True;Trust Server Certificate=True";
                    _Instance = new DBHelper(s);
                }
                return _Instance;
            }
            private set { }
        }
        private DBHelper(string s)
        {
            _conn = new SqlConnection(s);
        }
        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter(query, _conn);
            _conn.Open();
            adt.Fill(dt);
            _conn.Close();
            return dt;
        }

        public DataTable GetRecord(string query, SqlParameter[] para)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            if (para != null)
                cmd.Parameters.AddRange(para);
            cmd.Connection = _conn;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            _conn.Open();
            da.Fill(dt);
            _conn.Close();
            return dt;
        }
        public int ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            _conn.Open();
            int row = cmd.ExecuteNonQuery();
            _conn.Close();
            return row;
        }

        public int ExecuteDB(string query, SqlParameter[] para)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = _conn;
            if (para != null)
                cmd.Parameters.AddRange(para);
            _conn.Open();
            int row = cmd.ExecuteNonQuery();
            _conn.Close();
            return row;

        }
        


    }
}
