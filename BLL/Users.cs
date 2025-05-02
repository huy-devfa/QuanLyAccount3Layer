using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyAccount3Layer.DAL;
using System.Diagnostics.Eventing.Reader;
using System.Configuration;

namespace QuanLyAccount3Layer.BLL
{
    internal class Users
    {
        Providers providers = new Providers();
        public SqlConnection Connection()
        {
            return providers.connection;
        }//ket thuc Connection

        public Boolean Connect()
        {
            return providers.Connect();
        }//ket thuc Connect()

        public void Disconnect()
        {
            providers.Disconnect();
        }//ket thuc Disconnect()

        //Viet ham CheckUser voi tham so truyen vao la ten tai khoan va mat khau
        //Ket qua tra ve 1 la User va mat khau da ton tai trong Table Users nguoc lai tra ve 0  la User va mat khau chua co trong Table

        public int CheckUser(string User, string Pass, string vaitro)
        {
            providers.Connect();
            string strsql = "Select count(*) from Users where ((username=@TaiKhoan) and (pass=@MatKhau)) and (vaitro=@PVaitro)";

            SqlCommand Cmd = new SqlCommand(strsql, Connection());

            SqlParameter para1 = new SqlParameter("@TaiKhoan", User);
            SqlParameter para2 = new SqlParameter("@MatKhau", Pass);
            SqlParameter para3 = new SqlParameter("@PVaitro", vaitro);
                
            Cmd.Parameters.Add(para1);
            Cmd.Parameters.Add(para2);
            Cmd.Parameters.Add(para3);
            //tao cac Parameters cho cau lenh SQL
            //Cmd.Parameters.Add(new SqlParameter("@TaiKhoan", User));
            //Cmd.Parameters.Add(new SqlParameter("@MatKhauNguoiDung",Pass));

            int kqsql = (int)Cmd.ExecuteScalar();
            return kqsql;
        }//ket thuc CheckUser


        public DataTable GetDataUser()
        {
            string[] parameters = { };
            string[] values = { };
            return providers.GetData("Select * from Users",parameters,values,false);
        }//ket thuc GetDataUser()
        public int Count_User()
        {
            providers.Connect();
            string query = "Select count(*) from Users where vaitro='User'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return (int)cmd.ExecuteScalar();
        }//ket thuc Count_User()

        public int Count_SoldAccount()
        {
            providers.Connect();

            string query = "Select count(*) from Accounts where trangthai=N'Đã bán'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return (int)cmd.ExecuteScalar();
        }//ket thuc Count_SoldAccount()

        public Decimal Sum_Revenue()
        {
            providers.Connect();

            string query = "Select sum(GiaBan) from Accounts where trangthai=N'Đã bán'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }//Ket thuc Sum_Revenue()

        public decimal Sum_TotalUserBalance()
        {
            providers.Connect();

            string query = "Select sum(sodu) from Users where vaitro='User'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }//ket thuc Sum_TotalUserBalance()

        public decimal GetBalanceUser(string User)
        {
            providers.Connect();

            string query = $"Select sodu from Users where username='{User}'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return Convert.ToDecimal(cmd.ExecuteScalar());
        }//ket thuc GetBalanceUser()

        public int UserExecuteNonQuery(string queryOrSpName, string[] Parameters, object[] Values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, Parameters, Values, isStored);
        }//Kết thúc UserExecuteNonQuery

        public int UserExecuteScalar(string queryOrSpName, string[] Parameters, object[] Values)
        {
            return providers.ExecuteScalar(queryOrSpName, Parameters, Values);
        }//Kết thúc UserExecuteScalar

    }
}
