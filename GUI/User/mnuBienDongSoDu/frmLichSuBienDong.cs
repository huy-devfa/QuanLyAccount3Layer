using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using QuanLyAccount3Layer.BLL;

namespace QuanLyAccount3Layer.GUI.User.mnuBienDongSoDu
{
    public partial class frmLichSuBienDong : Form
    {
        public frmLichSuBienDong()
        {
            InitializeComponent();
        }

        private string Current_User = "";
        public frmLichSuBienDong(string User)
        {
            InitializeComponent();
            Current_User = User;
        }

        LichSuGiaoDich lsgd;

        private void LoadGiaoDichGanDay_User()
        {
            ChayStatus();
            DataTable tbllsbd = new DataTable();
            lsgd = new LichSuGiaoDich();

            if (lsgd.Connect())
            {
                tbllsbd = lsgd.GetDataLichSuDongTien_User(Current_User);
                dgvLichSuDongTien_User.DataSource = tbllsbd;
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai!", "THong bao!");
            }

            dgvLichSuDongTien_User.Columns["UserId"].HeaderText = "user ảnh hưởng";
            dgvLichSuDongTien_User.Columns["UserId"].Width = 100;
            dgvLichSuDongTien_User.Columns["LoaiGiaoDich"].HeaderText = "Loại giao dịch";
            dgvLichSuDongTien_User.Columns["LoaiGiaoDich"].Width = 100;
            dgvLichSuDongTien_User.Columns["sotiengiaodich"].HeaderText = "Số tiền";
            dgvLichSuDongTien_User.Columns["sotiengiaodich"].Width = 100;
            dgvLichSuDongTien_User.Columns["Motagiaodich"].HeaderText = "Mô tả";
            dgvLichSuDongTien_User.Columns["Motagiaodich"].Width = 215;
            dgvLichSuDongTien_User.Columns["ThoiGianGiaoDich"].HeaderText = "Thời gian";
            dgvLichSuDongTien_User.Columns["ThoiGianGiaoDich"].Width = 200;
            dgvLichSuDongTien_User.Columns["idGiaoDich"].HeaderText = "ID Giao dịch";
            dgvLichSuDongTien_User.Columns["idGiaoDich"].Width = 100;

            for(int i = 0; i < dgvLichSuDongTien_User.Rows.Count; i++)
            {
                string GiaTri = dgvLichSuDongTien_User.Rows[i].Cells["LoaiGiaoDich"].Value?.ToString();
                
                if(GiaTri == "Cộng tiền")
                {
                    dgvLichSuDongTien_User.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                }
                else
                {
                    dgvLichSuDongTien_User.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }

        }//ket thuc LoadGiaoDichGanDay_User()

        private void LichSuBienDong_Load(object sender, EventArgs e)
        {
            LoadGiaoDichGanDay_User();
        }//ket thuc LichSuBienDong_Load()

        private  async void ChayStatus()
        {
            for (int i = 10; i >= 0; i--)
            {
                StatusLoadLaiTrang.Text = $"Load lại sau : {i} giây";
                await Task.Delay(1000);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ChayStatus();
            LoadGiaoDichGanDay_User();
        }
    }
}
