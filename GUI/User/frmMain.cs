using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyAccount3Layer.GUI;
using QuanLyAccount3Layer.GUI.User.mnuTienIch;
using System.Data.SqlClient;
using QuanLyAccount3Layer.BLL;

namespace QuanLyAccount3Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string Current_User = "";
        public frmMain(int CheckAdminOrUser,string UserLogin)
        {
            InitializeComponent();
            if(CheckAdminOrUser > 0)
            {
                mnuTaiKhoan_QuanTri.Visible = true;
            }
            else
            {
                mnuTaiKhoan_QuanTri.Visible = false;
            }
            Current_User = UserLogin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSoDu();
        }

        private void LoadSoDu()
        {
            Users user = new Users();

            if (user.Connect())
            {
                mnuTaiKhoan_SoDu.Text = $"Số dư : {user.GetBalanceUser(Current_User)}";
            }
            else
            {
                MessageBox.Show("Da co loi khi thuc hien GetBalanceUser tu co so du lieu!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mnuTaiKhoan.Text = Current_User;
        }//ket thuc LoadSoDu()

        private void mnuTaiKhoan_QuanTri_Click(object sender, EventArgs e)
        {
            frmAdmin_Thongke admin = new frmAdmin_Thongke(Current_User);
            admin.Show();

        }//ket thuc mnuTaiKhoan_QuanTri_Click()

        private void mnuTienich_CatChuoi_Click(object sender, EventArgs e)
        {
            frmCatChuoi catchuoi = new frmCatChuoi();
            catchuoi.Show();
        }//ket thuc mnuTienich_CatChuoi_Click()

        private void mnuTaiKhoan_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin LogOut = new frmLogin(Current_User);
            LogOut.Show();
        }//ket thuc mnuTaiKhoan_DangXuat_Click()

        private void btnMuaAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
