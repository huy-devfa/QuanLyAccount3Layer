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
using QuanLyAccount3Layer.BLL;

namespace QuanLyAccount3Layer.GUI.Admin.mnuQuanLy
{
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        Users user;

        private void TrangThaiNutLenh(string TenNut)
        {
            switch (TenNut)
            {
                case "Sửa":
                    {
                        btnSua.Enabled = false;
                        btnHuy.Enabled = true;
                        btnLuu.Enabled = true;
                        txtTaiKhoan.ReadOnly = true;
                        txtMatKhau.ReadOnly = false;
                        txtSoDu.ReadOnly = false;
                        txtVaiTro.ReadOnly = true;
                        cmbChonVaiTro.Enabled = true;
                        break;
                    }
                case "Hủy":
                    {
                        btnSua.Enabled = true;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        txtTaiKhoan.ReadOnly = true;
                        txtMatKhau.ReadOnly = true;
                        txtSoDu.ReadOnly = true;
                        txtVaiTro.ReadOnly = true;
                        cmbChonVaiTro.Enabled = false;
                        break;
                    }
                case "Lưu":
                    {
                        btnSua.Enabled = true;
                        btnHuy.Enabled = false;
                        btnLuu.Enabled = false;
                        txtTaiKhoan.ReadOnly = true;
                        txtMatKhau.ReadOnly = true;
                        txtSoDu.ReadOnly = true;
                        txtVaiTro.ReadOnly = true;
                        cmbChonVaiTro.Enabled = false;
                        break;
                    }
            }
        }//ket thuc TrangThaiNutLenh()


        private void BindingDataUser()
        {
            txtTaiKhoan.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtSoDu.DataBindings.Clear();
            txtVaiTro.DataBindings.Clear();

            txtTaiKhoan.DataBindings.Add("Text", dgvQuanLyKhachHang.DataSource, "username");
            txtMatKhau.DataBindings.Add("Text", dgvQuanLyKhachHang.DataSource, "pass");
            txtSoDu.DataBindings.Add("Text", dgvQuanLyKhachHang.DataSource, "SoDu");
            txtVaiTro.DataBindings.Add("Text", dgvQuanLyKhachHang.DataSource, "vaitro");
        }//ket thuc BindingDataUser()

        private void LoadDataUser()
        {
            DataTable tblUser;
            user = new Users();

            if (user.Connect())
            {
                tblUser = user.GetDataUser();
                dgvQuanLyKhachHang.DataSource = tblUser;
            }
            else
            {
                MessageBox.Show("Da co loi trong qua trinh ket noi den co so du lieu!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvQuanLyKhachHang.Columns["username"].HeaderText = "Tài khoản";
            dgvQuanLyKhachHang.Columns["username"].Width = 100;
            dgvQuanLyKhachHang.Columns["pass"].HeaderText = "Mật khẩu";
            dgvQuanLyKhachHang.Columns["pass"].Width = 200;
            dgvQuanLyKhachHang.Columns["SoDu"].HeaderText = "Số dư";
            dgvQuanLyKhachHang.Columns["SoDu"].Width = 100;
            dgvQuanLyKhachHang.Columns["vaitro"].HeaderText = "Vai trò";
            dgvQuanLyKhachHang.Columns["vaitro"].Width = 250;

            BindingDataUser();
        }//ket thuc LoadDataUser()

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            cmbChonVaiTro.Enabled = false;
            LoadDataUser();
        }//ket thuc frmQuanLyKhachHang_Load()

        private int UpdateUser(Users user)
        {
            string spName = "Usp_UpdateUsers";

            string[] parameters = { "@Pusername", "@Ppass", "@Psodu", "@Pvaitro" };

            object[] values = { txtTaiKhoan.Text, txtMatKhau.Text, Convert.ToDecimal(txtSoDu.Text),txtVaiTro.Text };

            return user.UserExecuteNonQuery(spName, parameters, values, true);
        }//ket thuc UpdateUser()

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Sửa");
        }//ket thuc btnSua_Click()

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Hủy");
        }//ket thuc btnHuy_Click()

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            if (user.Connect())
            {
                int rec = UpdateUser(user);
                if(rec > 0)
                {
                    MessageBox.Show("Sua thong tin thanh cong!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Da xay ra loi trong qua trinh thay doi thong tin!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            TrangThaiNutLenh("Lưu");
           
        }//ket thuc btnLuu_Click()

        private void cmbChonVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtVaiTro.Text = cmbChonVaiTro.Text;
        }//ket thuc cmbChonVaiTro_SelectedIndexChanged()
    }
}
