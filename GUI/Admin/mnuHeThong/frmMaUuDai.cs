using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccount3Layer.BLL;


namespace QuanLyAccount3Layer.GUI.Admin.mnuHeThong
{
    public partial class frmMaUuDai : Form
    {
        public frmMaUuDai()
        {
            InitializeComponent();
        }

        MaUuDai mauudai;

        private void BingDingdataMaUuDai()
        {
            txtGiftCode.DataBindings.Clear();
            txtPhanTramUuDai.DataBindings.Clear();
            numberUpDown_HanSuDung.DataBindings.Clear();
            NumberUpDown_SoLuotSuDung.DataBindings.Clear();
            txtLoaiUuDai.DataBindings.Clear();

            txtGiftCode.DataBindings.Add("Text", dgvMaUuDai.DataSource, "GiftCode");
            numberUpDown_HanSuDung.DataBindings.Add("Value", dgvMaUuDai.DataSource, "HanSuDungUuDai");
            txtLoaiUuDai.DataBindings.Add("Text", dgvMaUuDai.DataSource, "TenUuDai");
            NumberUpDown_SoLuotSuDung.DataBindings.Add("Value", dgvMaUuDai.DataSource, "LuotSuDung");
            txtPhanTramUuDai.DataBindings.Add("Text", dgvMaUuDai.DataSource, "UuDai");
            
        }

        private void LoadMaUuDai()
        {
            
            DataTable tblMaUuDai;
            mauudai = new MaUuDai();

            if (mauudai.Connect())
            {
                tblMaUuDai = mauudai.GetDataMaUuDai();
                dgvMaUuDai.DataSource = tblMaUuDai;
            }
            else
            {
                MessageBox.Show("Da co loi trong qua trinh ket noi den co so du lieu!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BingDingdataMaUuDai();
        }

        
        private void frmMaUuDai_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            CountDownStatusAutoCheck();
            LoadMaUuDai();
        }

        private void txtPhanTramUuDai_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtGiftCode.Clear();
            txtPhanTramUuDai.Clear();
            numberUpDown_HanSuDung.Value = 1;
            NumberUpDown_SoLuotSuDung.Value = 1;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            

        }

        private int InsertGiftCode(MaUuDai mauudai)
        {
            //string spName = "Usp_InsertGiftCode";

            string[] parameters = { "@PGiftCode", "@PLoaiUuDai", "@PUuDai", "@PHanSuDungUuDai", "@PLuotSuDung"  };

            object[] values = { txtGiftCode.Text, 1, txtPhanTramUuDai.Text, numberUpDown_HanSuDung.Value, NumberUpDown_SoLuotSuDung.Value }; ;

            return mauudai.MaUuDaiExecuteNonQuery($"Insert into MaUuDai(GiftCode,LoaiUuDai,UuDai,HanSuDungUuDai,ThoiGianHetHanUuDai,LuotSuDung) values(@PGiftCode,@PLoaiUuDai,@PUuDai,@PHanSuDungUuDai,dateadd(day,{numberUpDown_HanSuDung.Value},Getdate()),@PLuotSuDung)", parameters, values, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            mauudai = new MaUuDai();

            if (mauudai.Connect())
            {
                int rec = InsertGiftCode(mauudai);
                if(rec > 0)
                {
                    MessageBox.Show("Them giftcode thanh cong!", "Thong bao!");
                }
                else
                {
                    MessageBox.Show("Da co loi trong qua trinh them giftcode", "Thong bao!");
                }
            }
            else
            {
                MessageBox.Show("Ket noi csdl that bai!","Thong bao!");
            }
            LoadMaUuDai();
        }

        private async void CountDownStatusAutoCheck()
        {
            for(int i = 60; i>=0;i--)
            {
                StatusAutoCheckDate.Text = $"Check date giftcode : {i} second";
                await Task.Delay(1000);
            }
        }// ket thuc CountDownStatusAutoCheck()


        private int UpdateTrangThaiUuDai(MaUuDai mauudai,string giftcode)
        {
            string[] parameters = { /*"@PGiftcode" */};

            object[] values = { /*giftcode*/ };

            return mauudai.MaUuDaiExecuteNonQuery($"Update Mauudai set TrangThaiUuDai = N'Hết hạn' where Giftcode = '{giftcode}'",parameters,values,false);

        }//ket thuc UpdateTrangThaiUuDai()



        private void timerCheckDateGiftCode_Tick(object sender, EventArgs e)
        {
            mauudai = new MaUuDai();
            for(int i = 0; i < dgvMaUuDai.Rows.Count; i++)
            {
                string GiaTri = dgvMaUuDai.Rows[i].Cells["GiftCode"].Value?.ToString();

                if (mauudai.AutoCheckDateGiftCode(GiaTri) > 0)
                {
                    UpdateTrangThaiUuDai(mauudai, GiaTri);
                }
            }
            CountDownStatusAutoCheck();
        }//ket thuc timerCheckDateGiftCode_Tick()

        private void TimerCheckLuotSuDung_Tick(object sender, EventArgs e)
        {
            mauudai = new MaUuDai();

            for(int i = 0; i < dgvMaUuDai.Rows.Count; i++)
            {
                string GiaTri = dgvMaUuDai.Rows[i].Cells["GiftCode"].Value?.ToString();


                if (mauudai.AutoCheckSoLanSuDung(GiaTri) == 0)
                {
                    UpdateTrangThaiUuDai(mauudai, GiaTri);

                    int rec = (int)UpdateTrangThaiUuDai(mauudai, GiaTri);
                }
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadMaUuDai();
        }
    }
}
