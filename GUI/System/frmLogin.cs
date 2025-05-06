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

namespace QuanLyAccount3Layer.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(string UserLogOut)
        {
            InitializeComponent();
            txtTaikhoan.Text = UserLogOut; 
        }
        private void WebLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNutHienAn, "Hiện mật khẩu");
            btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\NhamMat.png");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ClosingForm = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ClosingForm == DialogResult.Yes) this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ClosingForm = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(ClosingForm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users user = new Users();

            if(txtTaikhoan.TextLength == 0)
            {
                txtTaikhoan.Focus();
                return;
            }
            if(txtMatKhau.TextLength == 0)
            {
                txtMatKhau.Focus();
                return;
            }

            if (user.Connect())
            {
                if(user.CheckUser(txtTaikhoan.Text,txtMatKhau.Text,"Administrator") > 0)
                {
                    string userLogin = txtTaikhoan.Text;
                    frmMain frm = new frmMain(1,userLogin);
                    frm.Show();
                    //this.Hide();
                }
                else if(user.CheckUser(txtTaikhoan.Text,txtMatKhau.Text,"User") > 0)
                {
                    string userLogin = txtTaikhoan.Text;
                    frmMain frm = new frmMain(0,userLogin);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tai khoan hoac mat khau khong dung!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("He thong dang bao tri");
            }

            
        }//ket thuc btnLogin

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblChuyenHuongSangRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmregister register = new frmregister();
            register.ShowDialog();
        }

        bool anpass = true;

        private void btnNutHienAn_Click(object sender, EventArgs e)
        {
            if (anpass)
            {
                toolTip1.SetToolTip(btnNutHienAn, "Ẩn mật khẩu");
                btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\NhamMat.png");
                txtMatKhau.UseSystemPasswordChar = false;
                anpass = false;
            }
            else
            {
                toolTip1.SetToolTip(btnNutHienAn, "Hiện mật khẩu");
                btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\MoMat.png");
                txtMatKhau.UseSystemPasswordChar = true;
                anpass = true;
            }
            
        }
    }
}
