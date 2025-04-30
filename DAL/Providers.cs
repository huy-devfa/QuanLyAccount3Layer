using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyAccount3Layer.DAL
{
    internal class Providers
    {
        public SqlConnection connection;
        
        public bool Connect()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["ConnectStr"].ConnectionString.ToString();
            connection = new SqlConnection(connectionStr);

            if ((connection.State == ConnectionState.Closed) || (connection.State == ConnectionState.Broken))
            {
                connection.Open();
                return true;
            }
            else
            {
                return false;
            }
        }//ket thuc Connect()

        public void Disconnect()
        {
            connection.Close();
            connection.Dispose();
        }//ket thuc Disconnect()

        //ham thuc thi doi tuong SqlCommand
        //- Hàm có 4 tham số truyền vào
        //- queryOrSpName: Tham số truyền vào câu lệnh Sql hoặc tên
        //- Parameters: Mảng chứa các tham số của câu lệnh Sql hoặc tên của Stored Procedure
        //- Values: Mảng chứa giá trị truyền vào cho các tham số củacâu lệnh Sql hoặc tên của Stored Procedure
        //- isStored: True là Stored Procedure; false là câu lệnh SQL


        public SqlCommand Command(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(queryOrSpName,
            connection);
            if (isStored)
            {
                cmd.CommandText = queryOrSpName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = connection;
            }
            else
            {
                cmd.CommandType = CommandType.Text;
            }
            if (Parameters != null)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(Parameters[i], Values[i]);
                }
            }
            return cmd;
        }//Kết thúc Command

        //Khai báo hàm thực thi phương thức ExecuteReader của đối tượng SqlCommand
        public SqlDataReader ExecuteReader(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            SqlDataReader reader = Command(queryOrSpName, Parameters, Values, isStored).ExecuteReader();
            Disconnect();
            return reader;
        }//Kết thúc ExecuteReader

        //Khai báo hàm thực thi phương thức ExecuteNonQuery của đối tượng SqlCommand
        public int ExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            int rec = Command(queryOrSpName, Parameters, Values, isStored).ExecuteNonQuery();
            Disconnect();
            return rec;
        }//Kết thúc ExecuteNonQuery

        //Khai báo hàm thực thi phương thức ExecuteNonQuery của đối tượng SqlCommand
        public int ExecuteScalar(string queryOrSpName, string[] Parameters, object[] Values)
        {
            int Scalar = (int)Command(queryOrSpName, Parameters, Values, false).ExecuteScalar();
            Disconnect();
            return Scalar;
            
        }//Kết thúc ExecuteScalar   

        //Khai báo hàm thực thi phương thức ExecuteNonQuery của đối tượng SqlCommand
        public DataTable GetData(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            // Khai báo biến kiểu dữ liệu DataTable
            DataTable tbl = new DataTable();
            //Khai báo biến đối tượng SqlCommand
            SqlCommand cmd = Command(queryOrSpName, Parameters, Values, isStored);
            //Dùng biến đối tượng SqlDataAdapter thực thi lấy dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // Đổ dữ liệu từ biến kiểu dữ liệu SqlDataAdapter vào biến tbl kiểu dữ liệu DataTable
            da.Fill(tbl);
            //Đóng kết nối
            Disconnect();
            //Trả về kết quả
            return tbl;
        }//Kết thúc GetData
    }
}