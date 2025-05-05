using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyAccount3Layer.DAL;

namespace QuanLyAccount3Layer.BLL
{
    internal class LichSuGiaoDich
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

        public DataTable GetDataLichSuGiaoDich()
        {
            string[] parameters = { };
            object[] values = { };

            return providers.GetData("Select * from LichSuGiaoDich order by idGiaoDich DESC", parameters, values, false);
        }// ket thuc GetDataLichSuGiaoDich

        public DataTable FindUserByName(string User)
        {
            string query = $"Select * from LichSuGiaoDich where UserId like '{User}' ";

            string[] parameters = { };

            object[] values = { };

            return providers.GetData(query, parameters, values, false);
        }//ket thuc FindUserByName()
    }
}
