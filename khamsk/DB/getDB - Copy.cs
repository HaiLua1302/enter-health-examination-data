using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace khamsk.DB
{
    class getDB
    {//Chuỗi kết nối

        //connect sql khong can user pass
        /*        public static String _connectionString = @"Server=TenServer;Database=tenDATABASE;Integrated Security = true;";*/

        //connect sql co user pass
        public static String _connectionString = @"Data Source= TenServer;
                                                                      Initial Catalog = tenDATABASE;
                                                                      Persist Security Info = True;
                                                                      User ID = TenUSER;
                                                                      Password = MATKHAU";
        

        public static DataTable ExecuteQuery(String sql)
        {
            
            SqlConnection connect = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connect.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }
        //lay id
        public static string get_valueSQL(String sql)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.Connection = connect;
            connect.Open();
            string value = Convert.ToString(command.ExecuteScalar());
            connect.Close();
            return value;
        }
       
        //check duplicate
        public static int checkDuplicate(String sql)
        {
            SqlConnection connect = new SqlConnection(_connectionString);
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.Connection = connect;
            connect.Open();
            int CustomerCount = Convert.ToInt32(command.ExecuteScalar());
            connect.Close();
            return CustomerCount;
        }
        //ExecuteNonQuery: Insert, Update, Delete
        public static bool ExecuteNonQuery(String sql)
        {
            bool kq;
            SqlConnection connect = new SqlConnection(_connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            connect.Close();
            return kq;
        }


    }
}
