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

namespace QuanLyAccount3Layer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string Current_User = "";
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
            
        }

        private void mnuTaiKhoan_QuanTri_Click(object sender, EventArgs e)
        {
            frmAdmin_Thongke admin = new frmAdmin_Thongke(Current_User);
            admin.Show();
            
        }
    }
}
