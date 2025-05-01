using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAccount3Layer.GUI.User.mnuTienIch
{
    public partial class frmCatChuoi : Form
    {
        public frmCatChuoi()
        {
            InitializeComponent();
        }

        private void contextmnu_rtxtNhapTaiKhoan_SaoChep_Click(object sender, EventArgs e)
        {
            rtxtNhapTaiKhoan.Copy();
        }

        private void contextmnu_rtxtNhapTaiKhoan_Dan_Click(object sender, EventArgs e)
        {
            rtxtNhapTaiKhoan.Paste();
        }

        private void contextmnu_rtxtNhapTaiKhoan_ChonTatCa_Click(object sender, EventArgs e)
        {
            rtxtNhapTaiKhoan.SelectAll();
        }

        private void rtxtNhapTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void rtxtNhapTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            int sodong = rtxtNhapTaiKhoan.Lines.Length;
            statusSoDong.Text = $"Số dòng : {sodong}";
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            int batdaucat = Convert.ToInt32(txtBatDauCat.Text);
            int dencum = Convert.ToInt32(txtDenCum.Text);
            int demcat = 0;
            int sodong = rtxtNhapTaiKhoan.Lines.Length;
            int demkytungancach = 0;
            int laydiembatdau = 0;
            string kytungancach = txtNganCachBoiKyTu.Text;

            string ketqua = "";
            if(sodong > 0)
            {
                if(batdaucat <= 1)
                {

                    for (int i = 0; i < sodong; i++)
                    {
                        string donghientai = rtxtNhapTaiKhoan.Lines[i];

                        for (int j = 0; j < donghientai.Length; j++)
                        {

                            if (donghientai[j].ToString() == kytungancach)
                            {
                                demkytungancach++;
                                if (demkytungancach == dencum)
                                {
                                    int index = j;
                                    ketqua += donghientai.Substring(0, index) + "\r\n";
                                }
                            }

                        }
                        demkytungancach = 0;
                    }
                }

                else
                {
                    demkytungancach = 0;
                    int BatDau = 0;
                    int index = 0;
                    for(int i = 0; i < sodong; i++)
                    {
                        string donghientai = rtxtNhapTaiKhoan.Lines[i] + kytungancach;
                        
                        for(int j = 0; j < donghientai.Length; j++)
                        {
                            if (donghientai[j].ToString() == kytungancach)
                            {
                                demkytungancach++;
                                if(demkytungancach == batdaucat - 1)
                                {
                                    BatDau = j;
                                }
                                if(demkytungancach == dencum)
                                {
                                    index = j;
                                    ketqua += donghientai.Substring(BatDau+1, index - BatDau-1) + "\r\n";
                                }
                                
                            }
                        }
                        demkytungancach = 0;
                    }
                }
            }
            rtxtKetQuaCat.Text = ketqua;
        }//ket thuc btnCat_Click()

        private void rtxtNhapTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBatDauCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDenCum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDenCum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmCatChuoi_Load(object sender, EventArgs e)
        {
            txtBatDauCat.Text = "1";
            txtDenCum.Text = "2";
            cmbLoaiCat.SelectedIndex = 0;

            txtNganCachBoiKyTu.Text = ":";
            rtxtNhapTaiKhoan.Text = "banhmi:hotvitlon:bapxao\r\nconmeo:concho:convoi\r\ncongau:conchim:conma";
            rtxtKetQuaCat.Text = "banhmi:hotvitlon\r\nconmeo:concho\r\ncongau:conchim";
        }

        private void Contextmnu_rtxtKetQua_SaoChep_Click(object sender, EventArgs e)
        {
            rtxtKetQuaCat.Copy();
        }

        private void Contextmnu_rtxtKetQua_Dan_Click(object sender, EventArgs e)
        {
            rtxtKetQuaCat.Paste();
        }

        private void Contextmnu_rtxtKetQua_ChonTatCa_Click(object sender, EventArgs e)
        {
            rtxtKetQuaCat.SelectAll();
        }
    }
}
