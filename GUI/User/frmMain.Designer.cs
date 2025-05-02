namespace QuanLyAccount3Layer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTienich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienich_CatChuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienich_GhepChuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBienDongSoDu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhiteSpace1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhiteSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuBienDongSoDu_LichSuBienDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang_DonHangDaMua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang_DongHangDaDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_BaoMat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien_Momo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien_NganHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_SoDu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_QuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabMuaAcc = new System.Windows.Forms.TabPage();
            this.tabOrderAcc = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTienich,
            this.abcToolStripMenuItem,
            this.mnuDonHang,
            this.mnuBienDongSoDu,
            this.mnuWhiteSpace1,
            this.mnuWhiteSpace,
            this.mnuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(811, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTienich
            // 
            this.mnuTienich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTienich_CatChuoi,
            this.mnuTienich_GhepChuoi});
            this.mnuTienich.Name = "mnuTienich";
            this.mnuTienich.Size = new System.Drawing.Size(60, 25);
            this.mnuTienich.Text = "Tiện ích";
            // 
            // mnuTienich_CatChuoi
            // 
            this.mnuTienich_CatChuoi.Name = "mnuTienich_CatChuoi";
            this.mnuTienich_CatChuoi.Size = new System.Drawing.Size(180, 22);
            this.mnuTienich_CatChuoi.Text = "Cắt chuỗi";
            this.mnuTienich_CatChuoi.Click += new System.EventHandler(this.mnuTienich_CatChuoi_Click);
            // 
            // mnuTienich_GhepChuoi
            // 
            this.mnuTienich_GhepChuoi.Name = "mnuTienich_GhepChuoi";
            this.mnuTienich_GhepChuoi.Size = new System.Drawing.Size(180, 22);
            this.mnuTienich_GhepChuoi.Text = "Ghép chuỗi";
            // 
            // abcToolStripMenuItem
            // 
            this.abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            this.abcToolStripMenuItem.Size = new System.Drawing.Size(38, 25);
            this.abcToolStripMenuItem.Text = "abc";
            // 
            // mnuDonHang
            // 
            this.mnuDonHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDonHang_DonHangDaMua,
            this.mnuDonHang_DongHangDaDat});
            this.mnuDonHang.Name = "mnuDonHang";
            this.mnuDonHang.Size = new System.Drawing.Size(71, 25);
            this.mnuDonHang.Text = "Đơn hàng";
            // 
            // mnuBienDongSoDu
            // 
            this.mnuBienDongSoDu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBienDongSoDu_LichSuBienDong});
            this.mnuBienDongSoDu.Name = "mnuBienDongSoDu";
            this.mnuBienDongSoDu.Size = new System.Drawing.Size(105, 25);
            this.mnuBienDongSoDu.Text = "Biến động số dư";
            // 
            // mnuWhiteSpace1
            // 
            this.mnuWhiteSpace1.Enabled = false;
            this.mnuWhiteSpace1.Name = "mnuWhiteSpace1";
            this.mnuWhiteSpace1.Size = new System.Drawing.Size(12, 25);
            // 
            // mnuWhiteSpace
            // 
            this.mnuWhiteSpace.Enabled = false;
            this.mnuWhiteSpace.Name = "mnuWhiteSpace";
            this.mnuWhiteSpace.Size = new System.Drawing.Size(388, 25);
            this.mnuWhiteSpace.Text = "                                                                                 " +
    "                                          ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuBienDongSoDu_LichSuBienDong
            // 
            this.mnuBienDongSoDu_LichSuBienDong.Name = "mnuBienDongSoDu_LichSuBienDong";
            this.mnuBienDongSoDu_LichSuBienDong.Size = new System.Drawing.Size(180, 22);
            this.mnuBienDongSoDu_LichSuBienDong.Text = "Lịch sử biến động";
            // 
            // mnuDonHang_DonHangDaMua
            // 
            this.mnuDonHang_DonHangDaMua.Name = "mnuDonHang_DonHangDaMua";
            this.mnuDonHang_DonHangDaMua.Size = new System.Drawing.Size(180, 22);
            this.mnuDonHang_DonHangDaMua.Text = "Đơn hàng đã mua";
            // 
            // mnuDonHang_DongHangDaDat
            // 
            this.mnuDonHang_DongHangDaDat.Name = "mnuDonHang_DongHangDaDat";
            this.mnuDonHang_DongHangDaDat.Size = new System.Drawing.Size(180, 22);
            this.mnuDonHang_DongHangDaDat.Text = "Đơn hàng đã đặt";
            // 
            // mnuTaiKhoan_ThongTin
            // 
            this.mnuTaiKhoan_ThongTin.Name = "mnuTaiKhoan_ThongTin";
            this.mnuTaiKhoan_ThongTin.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_ThongTin.Text = "Thông tin";
            // 
            // mnuTaiKhoan_BaoMat
            // 
            this.mnuTaiKhoan_BaoMat.Name = "mnuTaiKhoan_BaoMat";
            this.mnuTaiKhoan_BaoMat.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_BaoMat.Text = "Bảo mật";
            // 
            // mnuTaiKhoan_NapTien
            // 
            this.mnuTaiKhoan_NapTien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan_NapTien_Momo,
            this.mnuTaiKhoan_NapTien_NganHang});
            this.mnuTaiKhoan_NapTien.Name = "mnuTaiKhoan_NapTien";
            this.mnuTaiKhoan_NapTien.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_NapTien.Text = "Nạp tiền";
            // 
            // mnuTaiKhoan_NapTien_Momo
            // 
            this.mnuTaiKhoan_NapTien_Momo.Name = "mnuTaiKhoan_NapTien_Momo";
            this.mnuTaiKhoan_NapTien_Momo.Size = new System.Drawing.Size(180, 26);
            this.mnuTaiKhoan_NapTien_Momo.Text = "Momo";
            // 
            // mnuTaiKhoan_NapTien_NganHang
            // 
            this.mnuTaiKhoan_NapTien_NganHang.Name = "mnuTaiKhoan_NapTien_NganHang";
            this.mnuTaiKhoan_NapTien_NganHang.Size = new System.Drawing.Size(180, 26);
            this.mnuTaiKhoan_NapTien_NganHang.Text = "Ngân Hàng";
            // 
            // mnuTaiKhoan_SoDu
            // 
            this.mnuTaiKhoan_SoDu.Enabled = false;
            this.mnuTaiKhoan_SoDu.Name = "mnuTaiKhoan_SoDu";
            this.mnuTaiKhoan_SoDu.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_SoDu.Text = "Số dư";
            // 
            // mnuTaiKhoan_DangXuat
            // 
            this.mnuTaiKhoan_DangXuat.Name = "mnuTaiKhoan_DangXuat";
            this.mnuTaiKhoan_DangXuat.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_DangXuat.Text = "Đăng xuất";
            this.mnuTaiKhoan_DangXuat.Click += new System.EventHandler(this.mnuTaiKhoan_DangXuat_Click);
            // 
            // mnuTaiKhoan_QuanTri
            // 
            this.mnuTaiKhoan_QuanTri.Image = global::QuanLyAccount3Layer.Properties.Resources.boss;
            this.mnuTaiKhoan_QuanTri.Name = "mnuTaiKhoan_QuanTri";
            this.mnuTaiKhoan_QuanTri.Size = new System.Drawing.Size(184, 26);
            this.mnuTaiKhoan_QuanTri.Text = "Quản trị";
            this.mnuTaiKhoan_QuanTri.Click += new System.EventHandler(this.mnuTaiKhoan_QuanTri_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaiKhoan_ThongTin,
            this.mnuTaiKhoan_BaoMat,
            this.mnuTaiKhoan_NapTien,
            this.mnuTaiKhoan_SoDu,
            this.mnuTaiKhoan_DangXuat,
            this.mnuTaiKhoan_QuanTri});
            this.mnuTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTaiKhoan.Image = global::QuanLyAccount3Layer.Properties.Resources.people;
            this.mnuTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(107, 25);
            this.mnuTaiKhoan.Text = "Tài khoản";
            this.mnuTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabMuaAcc);
            this.TabMain.Controls.Add(this.tabOrderAcc);
            this.TabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMain.Location = new System.Drawing.Point(27, 60);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(748, 352);
            this.TabMain.TabIndex = 1;
            // 
            // TabMuaAcc
            // 
            this.TabMuaAcc.Location = new System.Drawing.Point(4, 25);
            this.TabMuaAcc.Name = "TabMuaAcc";
            this.TabMuaAcc.Padding = new System.Windows.Forms.Padding(3);
            this.TabMuaAcc.Size = new System.Drawing.Size(740, 323);
            this.TabMuaAcc.TabIndex = 0;
            this.TabMuaAcc.Text = "Mua Acc Blox Fruit";
            this.TabMuaAcc.UseVisualStyleBackColor = true;
            // 
            // tabOrderAcc
            // 
            this.tabOrderAcc.Location = new System.Drawing.Point(4, 22);
            this.tabOrderAcc.Name = "tabOrderAcc";
            this.tabOrderAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderAcc.Size = new System.Drawing.Size(740, 326);
            this.tabOrderAcc.TabIndex = 1;
            this.tabOrderAcc.Text = "Order Acc BloxFruit";
            this.tabOrderAcc.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 424);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTienich;
        private System.Windows.Forms.ToolStripMenuItem mnuTienich_CatChuoi;
        private System.Windows.Forms.ToolStripMenuItem mnuTienich_GhepChuoi;
        private System.Windows.Forms.ToolStripMenuItem abcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang;
        private System.Windows.Forms.ToolStripMenuItem mnuBienDongSoDu;
        private System.Windows.Forms.ToolStripMenuItem mnuWhiteSpace1;
        private System.Windows.Forms.ToolStripMenuItem mnuWhiteSpace;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBienDongSoDu_LichSuBienDong;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang_DonHangDaMua;
        private System.Windows.Forms.ToolStripMenuItem mnuDonHang_DongHangDaDat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_ThongTin;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_BaoMat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_NapTien;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_NapTien_Momo;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_NapTien_NganHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_SoDu;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan_QuanTri;
        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage TabMuaAcc;
        private System.Windows.Forms.TabPage tabOrderAcc;
    }
}

