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

        private void frmAdmin_Thongke_Load(object sender, EventArgs e)
        {
            lblXinChaoUser.Text = $"Xin chào, {Current_User} !" ;
        }
    }
}
