using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccount3Layer.GUI.Admin;
using QuanLyAccount3Layer.BLL;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyAccount3Layer.DAL;
using QuanLyAccount3Layer.GUI.Admin.mnuQuanLy;
using System.Threading;
using System.Security.AccessControl;
using QuanLyAccount3Layer.GUI.Admin.mnuHeThong;

namespace QuanLyAccount3Layer.GUI
{
    public partial class frmAdmin_Thongke : Form
    {
        public frmAdmin_Thongke()
        {
            InitializeComponent();
        }

        private string Current_User = "";
        public frmAdmin_Thongke(string userLogin)
        {
            InitializeComponent();
            Current_User = userLogin;
        }

        LichSuGiaoDich lsgd;

        private void mnuAdmin_HeThong_ThongTinThanhToan_Click(object sender, EventArgs e)
        {
            frmThongTinThanhToan tttt = new frmThongTinThanhToan();
            tttt.Show();
        }

        private void LoadAdmin()
        {
            Users user = new Users();

            if (user.Connect())
            {
                lblTongKhachHang.Text = user.Count_User().ToString();
                lblTongTaiKhoanDaBan.Text = user.Count_SoldAccount().ToString();
                lblTongDoanhThu.Text = user.Sum_Revenue().ToString() + " vnđ";
                lblTongTienConLaiCuaKhachHang.Text = user.Sum_TotalUserBalance().ToString() + " vnđ";
            }
            else
            {
                MessageBox.Show("Da co loi trong qua trinh ket noi den co so du lieu nen hien khong the lay thong so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGiaoDichGanDay()
        {
            DataTable tbllsgd;
            lsgd = new LichSuGiaoDich();

            if (lsgd.Connect())
            {
                tbllsgd = lsgd.GetDataLichSuGiaoDich();
                dgvGiaoDichGanDay.DataSource = tbllsgd;
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvGiaoDichGanDay.Columns["UserId"].HeaderText = "user ảnh hưởng";
            dgvGiaoDichGanDay.Columns["UserId"].Width = 100;
            dgvGiaoDichGanDay.Columns["LoaiGiaoDich"].HeaderText = "Loại giao dịch";
            dgvGiaoDichGanDay.Columns["LoaiGiaoDich"].Width = 100;
            dgvGiaoDichGanDay.Columns["sotiengiaodich"].HeaderText = "Số tiền";
            dgvGiaoDichGanDay.Columns["sotiengiaodich"].Width = 100;
            dgvGiaoDichGanDay.Columns["Motagiaodich"].HeaderText = "Mô tả";
            dgvGiaoDichGanDay.Columns["Motagiaodich"].Width = 215;
            dgvGiaoDichGanDay.Columns["ThoiGianGiaoDich"].HeaderText = "Thời gian";
            dgvGiaoDichGanDay.Columns["ThoiGianGiaoDich"].Width = 200;
            dgvGiaoDichGanDay.Columns["idGiaoDich"].HeaderText = "ID Giao dịch";
            dgvGiaoDichGanDay.Columns["idGiaoDich"].Width = 100;
        }//ket thuc LoadGiaoDichGanDay()

        private void frmAdmin_Thongke_Load(object sender, EventArgs e)
        {
            LoadAdmin();
            statusLoadThongKe();
            lblXinChaoUser.Text = $"Xin chào, {Current_User} !" ;
            LoadGiaoDichGanDay();
        }//ket thuc frmAdmin_Thongke_Load()

        

        private void mnuAdmin_QuanLy_QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang qlkh = new frmQuanLyKhachHang(Current_User);
            qlkh.Show();
        }//ket thuc mnuAdmin_QuanLy_QuanLyKhachHang_Click

        private void mnuAdmin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void statusLoadThongKe()
        {
            for (int i = 10; i >= 0; i--)
            {
                statusLoad.Text = $"Tải lại sau : {i} giây";
                await Task.Delay(1000);
            }
        }//ket thuc statusLoadThongKe()

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            LoadAdmin();
            statusLoadThongKe();
            if(txtTimUser.Text == "" || txtTimUser.Text == "Nhập tên cần tìm..")
            {
                LoadGiaoDichGanDay();
            }
        }//ket thuc timerLoad_Tick()

        private void FindUserByName()
        {
            DataTable tblLsgd;

            lsgd = new LichSuGiaoDich();

            if (lsgd.Connect())
            {
                tblLsgd = lsgd.FindUserByName(txtTimUser.Text);
                dgvGiaoDichGanDay.DataSource = tblLsgd;
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvGiaoDichGanDay.Columns["UserId"].HeaderText = "user ảnh hưởng";
            dgvGiaoDichGanDay.Columns["UserId"].Width = 100;
            dgvGiaoDichGanDay.Columns["LoaiGiaoDich"].HeaderText = "Loại giao dịch";
            dgvGiaoDichGanDay.Columns["LoaiGiaoDich"].Width = 100;
            dgvGiaoDichGanDay.Columns["sotiengiaodich"].HeaderText = "Số tiền";
            dgvGiaoDichGanDay.Columns["sotiengiaodich"].Width = 100;
            dgvGiaoDichGanDay.Columns["Motagiaodich"].HeaderText = "Mô tả";
            dgvGiaoDichGanDay.Columns["Motagiaodich"].Width = 215;
            dgvGiaoDichGanDay.Columns["ThoiGianGiaoDich"].HeaderText = "Thời gian";
            dgvGiaoDichGanDay.Columns["ThoiGianGiaoDich"].Width = 200;
            dgvGiaoDichGanDay.Columns["idGiaoDich"].HeaderText = "ID Giao dịch";
            dgvGiaoDichGanDay.Columns["idGiaoDich"].Width = 100;

        }//ket thuc FindUserByName()

        private void txtTimUser_TextChanged(object sender, EventArgs e)
        {
            if (txtTimUser.Text.Equals(""))
            {
                LoadGiaoDichGanDay();
            }
            else
            {
                FindUserByName();
            }
        }

        private void btnTimUser_Click(object sender, EventArgs e)
        {
            
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtTimUser.Text = "";
        }

        private void mnuAdmin_HeThong_MaUuDai_Click(object sender, EventArgs e)
        {
            frmMaUuDai mdu = new frmMaUuDai();
            mdu.Show();
        }
    }
}
