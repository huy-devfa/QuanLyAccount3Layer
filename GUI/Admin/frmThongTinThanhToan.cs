using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QuanLyAccount3Layer.BLL;
using System.Collections;


namespace QuanLyAccount3Layer.GUI.Admin
{
    public partial class frmThongTinThanhToan : Form
    {
        public frmThongTinThanhToan()
        {
            InitializeComponent();
        }

        ThongTinThanhToan tttt;
        bool SaveFlag = true;

        private void TrangThaiNutLenh(string tennutlenh)
        {
            switch (tennutlenh)
            {
                case "Thêm":
                    {
                        btnSua.Enabled = false;
                        btnLuu.Enabled = true;
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnDong.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case "Sửa":
                    {
                        btnSua.Enabled = true;
                        btnLuu.Enabled = true;
                        btnThem.Enabled = false;
                        btnXoa.Enabled = false;
                        btnDong.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case "Xóa":
                    {
                        btnSua.Enabled = true;
                        btnLuu.Enabled = true;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnDong.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case "Lưu":
                    {
                        btnSua.Enabled = true;
                        btnLuu.Enabled = true;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnDong.Enabled = true;
                        btnHuy.Enabled = true;
                        break;
                    }
                case "Hủy":
                    {
                        btnSua.Enabled = true;
                        btnLuu.Enabled = true;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnDong.Enabled = true;
                        btnHuy.Enabled = true;
                        txtChuTaiKhoan.Enabled = true;
                        txtSoTaiKhoan.Enabled = true;
                        txtTenNganHang.Enabled = true;
                        break;
                    }
            }
        }//Ket thuc trangthainutlenh()

        private void BindingDataKhoa()
        {
            txtSoTaiKhoan.DataBindings.Clear();
            txtChuTaiKhoan.DataBindings.Clear();
            txtTenNganHang.DataBindings.Clear();

            txtSoTaiKhoan.DataBindings.Add("Text", dgvThongTinThanhToan.DataSource, "STK");
            txtChuTaiKhoan.DataBindings.Add("Text", dgvThongTinThanhToan.DataSource, "TenCTK");
            txtTenNganHang.DataBindings.Add("Text", dgvThongTinThanhToan.DataSource, "TenNH");
            
        }//ket thuc BindingDataKhoa()
        private void LoadDataThongTinThanhToan()
        {
            DataTable tblTTTT;
            tttt = new ThongTinThanhToan();

            if (tttt.Connect())
            {
                tblTTTT = tttt.GetDataThongTinThanhToan();
                dgvThongTinThanhToan.DataSource = tblTTTT;
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai", "Thong bao!");
            }

            dgvThongTinThanhToan.Columns["STK"].HeaderText = "Số tài khoản";
            dgvThongTinThanhToan.Columns["STK"].Width = 305;
            dgvThongTinThanhToan.Columns["TenCTK"].HeaderText = "Tên tài khoản";
            dgvThongTinThanhToan.Columns["TenCTK"].Width = 305;
            dgvThongTinThanhToan.Columns["TenNH"].HeaderText = "Ngân Hàng";
            dgvThongTinThanhToan.Columns["TenNH"].Width = 305;
            BindingDataKhoa();
        }//ket thuc LoadDataThongTinThanhToan()

        private void ResetAll_Text()
        {
            txtTenNganHang.Clear();
            txtSoTaiKhoan.Clear();
            txtChuTaiKhoan.Clear();
        }//Ket thuc ResetAll_text()


        private void frmThongTinThanhToan_Load(object sender, EventArgs e)
        {
            LoadDataThongTinThanhToan();
        }//ket thuc frmThongTinThanHToan_Load()


        private int InsertThongTinThanhToan(ThongTinThanhToan tttt)
        {
            string spName = "Usp_InsertThongTinThanhToan";

            string[] parameters = { "@Pstk", "@PTenCTK", "@PTenNH" };

            object[] values = { txtSoTaiKhoan.Text, txtChuTaiKhoan.Text, txtTenNganHang.Text };

            return tttt.ThongTinThanhToanExecuteNonQuery(spName, parameters, values, true);
        }//ket thuc InsertThongTinThanhToan()

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Thêm");
            SaveFlag = true;
            ResetAll_Text();
            
        }//ket thuc btnThem_Click()


        private int UpdateThongTinThanhToan(ThongTinThanhToan tttt)
        {
            string spName = "Usp_UpdateThongTinThanhToan";

            string[] parameters = { "@PStk", "@PTenCTK", "@PTenNH" };

            object[] values = { txtSoTaiKhoan.Text, txtChuTaiKhoan.Text, txtTenNganHang.Text };

            return tttt.ThongTinThanhToanExecuteNonQuery(spName, parameters, values, true);
        }//ket thuc UpdateThongTinThanhToan()

        private void btnSua_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Sửa");
            SaveFlag = false;
            txtSoTaiKhoan.Enabled = false;
            LoadDataThongTinThanhToan();
        }//ket thuc btnSuaClick()

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Hủy");
            LoadDataThongTinThanhToan();
        }//ket thuc btnHuy_Click

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Lưu");
            
            tttt = new ThongTinThanhToan();

            if (tttt.Connect())
            {
                if (SaveFlag == true)
                {
                    int rec = InsertThongTinThanhToan(tttt);
                    if (rec > 0)
                    {
                        MessageBox.Show("Them thong tin thanh toan thanh cong!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataThongTinThanhToan();
                    }
                    else
                    {
                        MessageBox.Show("Da co loi trong qua trinh them thong tin thanh toan!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int rec = UpdateThongTinThanhToan(tttt);
                    if(rec > 0)
                    {
                        MessageBox.Show("Sua thong tin thanh cong!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataThongTinThanhToan();
                    }
                    else
                    {
                        MessageBox.Show("Da co loi trong qua trinh sua thong tin thanh toan!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai!","Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//ket thuc btnLuu_Click


        private int DeleteThongTinThanhToan(ThongTinThanhToan tttt)
        {
            string spName = "Usp_DeleteThongTinThanhToan1";

            string[] parameters = { "@Pstk" };

            object[] values = { txtSoTaiKhoan.Text };

            return tttt.ThongTinThanhToanExecuteNonQuery(spName, parameters, values, true);
        }//ket thuc DeleteThongTinThanhToan()

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TrangThaiNutLenh("Xóa");
            tttt = new ThongTinThanhToan();
            if (tttt.Connect())
            {
                int rec = DeleteThongTinThanhToan(tttt);
                if(rec > 0)
                {
                    MessageBox.Show("Xoa Thanh Cong!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataThongTinThanhToan();
                }
                else
                {
                    MessageBox.Show("Da xay ra loi trong qua trinh xoa thong tin thanh toan!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ket noi voi co so du lieu that bai!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//ket thuc btnXoa_Click

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult DongTTTT = MessageBox.Show("Ban co chac muon dong khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(DongTTTT == DialogResult.Yes)
            {
                this.Close();
            }
        }//ket thuc btnDong_Click
    }
}
