using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyAccount3Layer.DAL;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLyAccount3Layer.BLL
{
    internal class ThongTinThanhToan
    {
        Providers providers = new Providers();

        public SqlConnection Connection()
        {
            return providers.connection;
        }//ket thuc Connection()

        public Boolean Connect()
        {
            return providers.Connect();
        }//ket thuc Connect()

        public void Disconnect()
        {
            providers.Disconnect();
        }//ket thuc Disconnect()

        public DataTable GetDataThongTinThanhToan()
        {
            string[] parameters = { };
            string[] values = { };
            return providers.GetData("select * from ThongTinThanhToan", parameters, values, false);
        }//ket thuc GetDataThongTinThanhToan()

        public int ThongTinThanhToanExecuteNonQuery(string queryOrSpName, string[] parameters, Object[] values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName,parameters,values,isStored);
        }//ket thuc ThongTinThanhToanExecuteNonQuery()


    }
}
