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
using QuanLyAccount3Layer.GUI.User.mnuBienDongSoDu;

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
            LoadLaiMain();
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
            mnuTaiKhoan.Text = Current_User + " ▼";
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

        private void EnterNutMua()
        {
            btnMuaAcc.BackColor = Color.White;
            btnMuaAcc.ForeColor = Color.Black;
        }
        private void btnMuaAcc_MouseHover(object sender, EventArgs e)
        {
            EnterNutMua();
        }

        private void btnMuaAcc_MouseEnter(object sender, EventArgs e)
        {
            EnterNutMua();
        }

        private void LeaveNutMua()
        {
            btnMuaAcc.BackColor = Color.RoyalBlue;
            btnMuaAcc.ForeColor = Color.White;
        }
        private void btnMuaAcc_MouseLeave(object sender, EventArgs e)
        {
            LeaveNutMua();
        }

        private void mnuBienDongSoDu_LichSuBienDong_Click(object sender, EventArgs e)
        {
            frmLichSuBienDong lsbd = new frmLichSuBienDong(Current_User);
            lsbd.Show();
        }//ket thuc mnuBienDongSoDu_LichSuBienDong_Click()

        private async void LoadLaiMain()
        {
            for (int i = 10; i >= 0; i--)
            {
                statusLoadLaiMain.Text = $"Load lại sau : {i} giây";
                await Task.Delay(1000);
            }
        }//ket thuc LoadLaiMain()

        private void TimerLoadLaiMain_Tick(object sender, EventArgs e)
        {
            LoadLaiMain();
            LoadSoDu();
        }
    }
}
