using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyAccount3Layer.DAL;

namespace QuanLyAccount3Layer.BLL
{
    internal class MaUuDai
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

        public DataTable GetDataMaUuDai()
        {
            string[] parameters = { };
            object[] values = { };

            return providers.GetData("select m.GiftCode,m.HanSuDungUuDai,l.TenUuDai,m.LuotSuDung,m.ThoiGianHetHanUuDai,m.ThoiGianTaoUuDai,m.TrangThaiUuDai,m.UuDai from MaUuDai m, LoaiUuDai l where m.LoaiUuDai = l.idLoaiUuDai\r\n", parameters, values, false);
        }// ket thuc GetDataLichSuGiaoDich

        public int MaUuDaiExecuteNonQuery(string queryOrSpName, string[] parameters, object[] values, bool isStored)
        {
            return providers.ExecuteNonQuery(queryOrSpName, parameters, values, isStored);
        }//ket thuc MaUuDaiExecuteNonQuery()

        public int MaUuDaiExecuteScalar(string queryOrSpName, string[] parameters, object[] values)
        {
            return providers.ExecuteScalar(queryOrSpName, parameters, values);
        }//ket thuc MaUuDaiExecuteScalar()

        public int AutoCheckDateGiftCode(string giftcode)
        {
            providers.Connect();

            string query = $"Select count(Giftcode) from MaUuDai where GiftCode = '{giftcode}' and ThoiGianHetHanUuDai < GETDATE()";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return Convert.ToInt32(cmd.ExecuteScalar());
        }//ket thuc AutoCheckDateGiftCode()


        public int AutoCheckSoLanSuDung(string giftcode)
        {
            providers.Connect();

            string query = $"Select LuotSuDung from MaUuDai where giftcode = '{giftcode}'";

            SqlCommand cmd = new SqlCommand(query, Connection());

            return Convert.ToInt32(cmd.ExecuteScalar());

        }//ket thuc AutoCheckSoLanSuDung()

    }
}
