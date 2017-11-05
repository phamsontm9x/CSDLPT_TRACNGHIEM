﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TracNghiem
{
    class Database
    {
        #region thuộc tính
        public static String database = "TRACNGHIEM";
        public static String SP_LOGIN = "LOGIN";
        public static String SP_GIANG_VIEN = "GIAOVIEN";
        public static String SP_MON_HOC = "MONHOC";
        public static String SP_LOP = "LOP";
        public static String SP_SINH_VIEN = "SINHVIEN";
        public static String SP_BO_DE = "BODE";
        public static String SP_GIAOVIEN_DANGKY = "GIAOVIEN_DANGKY";
        public static String SP_TAO_LOGIN = "TAO_LOGIN";
        // Role User
        public static int DENNY_ACCESS = 0;
        public static int TRUONG_ACCESS = 1;
        public static int COSO_ACCESS = 2;
        public static int GIANGVIEN_ACCESS = 3;
        public static int SINHVIEN_ACCESS = 4;
        #endregion

        public static SqlDataAdapter dataAdapter;
        public static SqlConnection Connection(String serverName, String loginName, String pass)
        {
            SqlConnection conn;
            String connectionString = @"Data Source=" + serverName + ";Initial Catalog=" + database + ";User ID=" + loginName + ";Password=" + pass;
            try
            {
                // tạo 1 kết nối đến CSDL thông qua chuỗi kết nối connectionString
                conn = new SqlConnection(connectionString);
                conn.Open(); // mở kết nối
                Program.connectStr = connectionString;
                Program.isLogin = true;
            }
            catch (SqlException)
            {

                MessageBox.Show("Lỗi kết nối Server? \nTài khoản hoặc mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   // hiển thị thông báo
                return null;
            }
            return conn;
        }

        public static SqlConnection ConnectAuthentication()
        {

            try
            {
                Program.connect.ConnectionString = Program.connectStr;
                Program.isLogin = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Kết nối đến server thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return Program.connect;
        }

        public static int Authentication(String servername, String loginname, String password)
        {
            SqlConnection conn = new SqlConnection(); // khởi tạo đối tượng conn 
            conn = Connection(servername, loginname, password); // mở kết nối

            if (Program.isLogin == true)
            {
                // bước 1: tạo 1 đối tượng giữ lệnh cần thực thi
                SqlCommand cmd = new SqlCommand("SP_LOGIN", conn);
                // xác định kiểu truy vấn
                cmd.CommandType = CommandType.StoredProcedure;

                // bước 2: tạo 1 đối tượng SqlParameter để định nghĩa cho parameter của câu SQL
                // mỗi SqlParameter chỉ định nghĩa cho 1 tham số trong command SQL
                SqlParameter para = new SqlParameter();
                para.ParameterName = "@TENLOGIN";
                para.Value = loginname;
                // bước 3: gán parameter vào SqlCommand
                cmd.Parameters.Add(para);

                var role = cmd.Parameters.Add("@PER", SqlDbType.Int);
                role.Direction = ParameterDirection.ReturnValue;  // trả về giá trị trong Store Procedure            
                //SqlDataReader reader = cmd.ExecuteReader(); // thực thi command SQL
                cmd.ExecuteNonQuery();
                conn.Close();
                int role_1 = Int32.Parse(role.Value.ToString());

                if (role_1 == 0)
                {
                    Program.connectStr = ""; // nếu như role_1 = 0 <=> nghĩa là tài khoản không tồn tại ==> cập nhật lại chuỗi kết nối
                }
                else
                {
                    return role_1;
                }
            }
            return 0; // kết nối không thành công
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.connect;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader(); return myReader;
            }
            catch (SqlException ex)
            {
                Program.connect.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            SqlConnection connect = new SqlConnection();
            DataTable dataTable = new DataTable();
            connect = new SqlConnection(connectionstring);
            dataAdapter = new SqlDataAdapter(cmd, connect);
            dataAdapter.Fill(dataTable);
            return dataTable;

        }


        public static int ExecSqlNonQuery(String cmd, String connectionString)
        {
            SqlConnection connect = new SqlConnection();
            connect = new SqlConnection(connectionString);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = connect;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (connect.State == ConnectionState.Closed) connect.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); connect.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
                return 0;
            }
        }
    }
}
