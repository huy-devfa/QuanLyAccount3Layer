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
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        Users user;
        private void lblChuyenHuongSangRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }


        //hàm check xem có user này tồn tài hay không
        private bool IsUsernameExists(string Username)
        {
            user = new Users();
            string query = "SELECT COUNT(*) FROM Users WHERE username = @username";

            string[] parameters = { "@username" };

            object[] values = { Username };

            int count = (int)user.UserExecuteScalar(query, parameters, values);
            return count > 0;
        }

        //Ham xu ly Insert taikhoan mat khau moi vao bang
        private int InsertUsers(Users user)
        {
            //Khai báo biến chứa tên của Stored Procedure
            string spName = "Usp1_InsertUsers";
            //Mảng chứa danh sách các tham số của Stored Procedure
            string[] parameters = { "@username", "@pass" };
            //Mảng chứa giá trị các tham số của Stored Procedure
            object[] values = {txtTaikhoan.Text, txtMatKhau.Text};
            //Gọi thực thi và trả về kết quả
            return user.UserExecuteNonQuery(spName, parameters, values, true);
        }//ket thuc InsertUsers()


        private void btnRegister_Click(object sender, EventArgs e)
        {
            user = new Users();

            if(txtTaikhoan.TextLength == 0)
            {
                txtTaikhoan.Focus();
                Error.SetError(txtTaikhoan, "Khong duoc de trong tai khoan");
                return;
            }
            
            if (txtMatKhau.TextLength == 0)
            {
                txtMatKhau.Focus();
                Error.SetError(txtTaikhoan, "Khong duoc de trong mat khau");
                return;
            }
            if(txtNhaplaimatkhau.TextLength == 0)
            {
                txtNhaplaimatkhau.Focus();
                return;
            }

            if (txtNhaplaimatkhau.Text != txtMatKhau.Text)
            {
                txtNhaplaimatkhau.Focus();
                Error.SetError(txtNhaplaimatkhau, "Mat khau khong giong nhau!");
            }
            else
            {
                if (user.Connect())
                {
                    if (IsUsernameExists(txtTaikhoan.Text))
                    {
                        Error.SetError(txtTaikhoan, "Tài khoản đã tồn tại!");
                        MessageBox.Show("Tài khoản đã tồn tại!","Thông báo!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int rec = InsertUsers(user);
                        if (rec > 0)
                        {
                            MessageBox.Show("Dang ki thanh cong");
                            this.Hide();
                        }
                        return;
                    }
                }
            }
        }

        private void txtNhaplaimatkhau_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void frmregister_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ClosingForm = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ClosingForm == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ClosingForm = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ClosingForm == DialogResult.Yes) this.Close();
        }

        
        private void txtNutHienAn_Click(object sender, EventArgs e)
        {
            if (anpass)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhaplaimatkhau.UseSystemPasswordChar = false;
                anpass = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhaplaimatkhau.UseSystemPasswordChar = true ;
                anpass = true;
            }
        }

        private void frmregister_Load(object sender, EventArgs e)
        {
            btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\NhamMat.png");
           
            toolTip1.SetToolTip(btnNutHienAn, "Hiện password");
        }

        bool anpass = true;
        private void btnNutHienAn_Click(object sender, EventArgs e)
        {
            if (anpass)
            {
                toolTip1.SetToolTip(btnNutHienAn, "Ẩn mật khẩu");
                btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\NhamMat.png");
             
                txtMatKhau.UseSystemPasswordChar = false;
                txtNhaplaimatkhau.UseSystemPasswordChar = false;
              
                anpass = false;
            }
            else
            {
                toolTip1.SetToolTip(btnNutHienAn, "Hiện mật khẩu");
                btnNutHienAn.Image = Image.FromFile(Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\images\\MoMat.png");
                txtMatKhau.UseSystemPasswordChar = true;
                txtNhaplaimatkhau .UseSystemPasswordChar = true ;
                anpass = true;
            }
        }
    }
}
