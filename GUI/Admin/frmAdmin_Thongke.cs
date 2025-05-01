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
                lblTongDoanhThu.Text = user.Sum_Revenue().ToString();
            }
            else
            {
                MessageBox.Show("Da co loi trong qua trinh ket noi den co so du lieu nen hien khong the lay thong so!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdmin_Thongke_Load(object sender, EventArgs e)
        {
            LoadAdmin();
            lblXinChaoUser.Text = $"Xin chào, {Current_User} !" ;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadAdmin();
        }
    }
}
