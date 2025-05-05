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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuTienich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienich_CatChuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienich_GhepChuoi = new System.Windows.Forms.ToolStripMenuItem();
            this.abcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang_DonHangDaMua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonHang_DongHangDaDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBienDongSoDu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBienDongSoDu_LichSuBienDong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhiteSpace1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWhiteSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TabMain = new System.Windows.Forms.TabControl();
            this.TabMuaAcc = new System.Windows.Forms.TabPage();
            this.grboxBangGiaBaoHanh = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grboxChonLoaiMuonMua = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberUpDown_ThoiGianBaoHanh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.numberUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChonLoaiMuonMua = new System.Windows.Forms.ComboBox();
            this.btnMuaAcc = new System.Windows.Forms.Button();
            this.tabOrderAcc = new System.Windows.Forms.TabPage();
            this.picLogoShop = new System.Windows.Forms.PictureBox();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_BaoMat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien_Momo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_NapTien_NganHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_SoDu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan_QuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.TabMuaAcc.SuspendLayout();
            this.grboxChonLoaiMuonMua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown_ThoiGianBaoHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoShop)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTienich,
            this.abcToolStripMenuItem,
            this.mnuDonHang,
            this.mnuBienDongSoDu,
            this.mnuWhiteSpace1,
            this.mnuWhiteSpace,
            this.mnuTaiKhoan});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(811, 29);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
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
            this.mnuTienich_CatChuoi.Size = new System.Drawing.Size(135, 22);
            this.mnuTienich_CatChuoi.Text = "Cắt chuỗi";
            this.mnuTienich_CatChuoi.Click += new System.EventHandler(this.mnuTienich_CatChuoi_Click);
            // 
            // mnuTienich_GhepChuoi
            // 
            this.mnuTienich_GhepChuoi.Name = "mnuTienich_GhepChuoi";
            this.mnuTienich_GhepChuoi.Size = new System.Drawing.Size(135, 22);
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
            // mnuDonHang_DonHangDaMua
            // 
            this.mnuDonHang_DonHangDaMua.Name = "mnuDonHang_DonHangDaMua";
            this.mnuDonHang_DonHangDaMua.Size = new System.Drawing.Size(169, 22);
            this.mnuDonHang_DonHangDaMua.Text = "Đơn hàng đã mua";
            // 
            // mnuDonHang_DongHangDaDat
            // 
            this.mnuDonHang_DongHangDaDat.Name = "mnuDonHang_DongHangDaDat";
            this.mnuDonHang_DongHangDaDat.Size = new System.Drawing.Size(169, 22);
            this.mnuDonHang_DongHangDaDat.Text = "Đơn hàng đã đặt";
            // 
            // mnuBienDongSoDu
            // 
            this.mnuBienDongSoDu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBienDongSoDu_LichSuBienDong});
            this.mnuBienDongSoDu.Name = "mnuBienDongSoDu";
            this.mnuBienDongSoDu.Size = new System.Drawing.Size(105, 25);
            this.mnuBienDongSoDu.Text = "Biến động số dư";
            // 
            // mnuBienDongSoDu_LichSuBienDong
            // 
            this.mnuBienDongSoDu_LichSuBienDong.Name = "mnuBienDongSoDu_LichSuBienDong";
            this.mnuBienDongSoDu_LichSuBienDong.Size = new System.Drawing.Size(168, 22);
            this.mnuBienDongSoDu_LichSuBienDong.Text = "Lịch sử biến động";
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
            this.mnuWhiteSpace.Size = new System.Drawing.Size(340, 25);
            this.mnuWhiteSpace.Text = "                                                                                 " +
    "                          ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.TabMuaAcc);
            this.TabMain.Controls.Add(this.tabOrderAcc);
            this.TabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabMain.Location = new System.Drawing.Point(29, 53);
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(748, 371);
            this.TabMain.TabIndex = 1;
            // 
            // TabMuaAcc
            // 
            this.TabMuaAcc.Controls.Add(this.grboxBangGiaBaoHanh);
            this.TabMuaAcc.Controls.Add(this.label7);
            this.TabMuaAcc.Controls.Add(this.label8);
            this.TabMuaAcc.Controls.Add(this.grboxChonLoaiMuonMua);
            this.TabMuaAcc.Location = new System.Drawing.Point(4, 25);
            this.TabMuaAcc.Name = "TabMuaAcc";
            this.TabMuaAcc.Padding = new System.Windows.Forms.Padding(3);
            this.TabMuaAcc.Size = new System.Drawing.Size(740, 342);
            this.TabMuaAcc.TabIndex = 0;
            this.TabMuaAcc.Text = "Mua Acc Blox Fruit";
            this.TabMuaAcc.UseVisualStyleBackColor = true;
            // 
            // grboxBangGiaBaoHanh
            // 
            this.grboxBangGiaBaoHanh.BackColor = System.Drawing.SystemColors.Info;
            this.grboxBangGiaBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxBangGiaBaoHanh.ForeColor = System.Drawing.Color.Navy;
            this.grboxBangGiaBaoHanh.Location = new System.Drawing.Point(547, 50);
            this.grboxBangGiaBaoHanh.Name = "grboxBangGiaBaoHanh";
            this.grboxBangGiaBaoHanh.Size = new System.Drawing.Size(186, 262);
            this.grboxBangGiaBaoHanh.TabIndex = 11;
            this.grboxBangGiaBaoHanh.TabStop = false;
            this.grboxBangGiaBaoHanh.Text = "Thông báo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(558, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Bảng giá thời gian bảo hành!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(44, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(658, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số tiền cần thanh toán = số lượng + thời gian bảo hành * đơn giá!";
            // 
            // grboxChonLoaiMuonMua
            // 
            this.grboxChonLoaiMuonMua.Controls.Add(this.label3);
            this.grboxChonLoaiMuonMua.Controls.Add(this.label9);
            this.grboxChonLoaiMuonMua.Controls.Add(this.NumberUpDown_ThoiGianBaoHanh);
            this.grboxChonLoaiMuonMua.Controls.Add(this.label1);
            this.grboxChonLoaiMuonMua.Controls.Add(this.txtThanhTien);
            this.grboxChonLoaiMuonMua.Controls.Add(this.numberUpDown_SoLuong);
            this.grboxChonLoaiMuonMua.Controls.Add(this.label2);
            this.grboxChonLoaiMuonMua.Controls.Add(this.cmbChonLoaiMuonMua);
            this.grboxChonLoaiMuonMua.Controls.Add(this.btnMuaAcc);
            this.grboxChonLoaiMuonMua.Location = new System.Drawing.Point(18, 50);
            this.grboxChonLoaiMuonMua.Name = "grboxChonLoaiMuonMua";
            this.grboxChonLoaiMuonMua.Size = new System.Drawing.Size(523, 263);
            this.grboxChonLoaiMuonMua.TabIndex = 6;
            this.grboxChonLoaiMuonMua.TabStop = false;
            this.grboxChonLoaiMuonMua.Text = "Chọn loại muốn mua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Thời gian bảo hành :";
            // 
            // NumberUpDown_ThoiGianBaoHanh
            // 
            this.NumberUpDown_ThoiGianBaoHanh.Location = new System.Drawing.Point(136, 58);
            this.NumberUpDown_ThoiGianBaoHanh.Name = "NumberUpDown_ThoiGianBaoHanh";
            this.NumberUpDown_ThoiGianBaoHanh.Size = new System.Drawing.Size(120, 22);
            this.NumberUpDown_ThoiGianBaoHanh.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số tiền cần phải thanh toán :";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(19, 212);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(227, 31);
            this.txtThanhTien.TabIndex = 6;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numberUpDown_SoLuong
            // 
            this.numberUpDown_SoLuong.Location = new System.Drawing.Point(448, 152);
            this.numberUpDown_SoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberUpDown_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown_SoLuong.Name = "numberUpDown_SoLuong";
            this.numberUpDown_SoLuong.Size = new System.Drawing.Size(47, 22);
            this.numberUpDown_SoLuong.TabIndex = 5;
            this.numberUpDown_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng :";
            // 
            // cmbChonLoaiMuonMua
            // 
            this.cmbChonLoaiMuonMua.FormattingEnabled = true;
            this.cmbChonLoaiMuonMua.Location = new System.Drawing.Point(6, 21);
            this.cmbChonLoaiMuonMua.Name = "cmbChonLoaiMuonMua";
            this.cmbChonLoaiMuonMua.Size = new System.Drawing.Size(355, 24);
            this.cmbChonLoaiMuonMua.TabIndex = 1;
            // 
            // btnMuaAcc
            // 
            this.btnMuaAcc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMuaAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaAcc.ForeColor = System.Drawing.Color.White;
            this.btnMuaAcc.Location = new System.Drawing.Point(372, 180);
            this.btnMuaAcc.Name = "btnMuaAcc";
            this.btnMuaAcc.Size = new System.Drawing.Size(123, 63);
            this.btnMuaAcc.TabIndex = 0;
            this.btnMuaAcc.Text = "Mua ngay";
            this.btnMuaAcc.UseVisualStyleBackColor = false;
            this.btnMuaAcc.Click += new System.EventHandler(this.btnMuaAcc_Click);
            this.btnMuaAcc.MouseEnter += new System.EventHandler(this.btnMuaAcc_MouseEnter);
            this.btnMuaAcc.MouseLeave += new System.EventHandler(this.btnMuaAcc_MouseLeave);
            this.btnMuaAcc.MouseHover += new System.EventHandler(this.btnMuaAcc_MouseHover);
            // 
            // tabOrderAcc
            // 
            this.tabOrderAcc.Location = new System.Drawing.Point(4, 25);
            this.tabOrderAcc.Name = "tabOrderAcc";
            this.tabOrderAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderAcc.Size = new System.Drawing.Size(740, 342);
            this.tabOrderAcc.TabIndex = 1;
            this.tabOrderAcc.Text = "Order Acc BloxFruit";
            this.tabOrderAcc.UseVisualStyleBackColor = true;
            // 
            // picLogoShop
            // 
            this.picLogoShop.Image = global::QuanLyAccount3Layer.Properties.Resources.ShopTuDoi1;
            this.picLogoShop.Location = new System.Drawing.Point(694, 32);
            this.picLogoShop.Name = "picLogoShop";
            this.picLogoShop.Size = new System.Drawing.Size(76, 40);
            this.picLogoShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoShop.TabIndex = 2;
            this.picLogoShop.TabStop = false;
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
            this.mnuTaiKhoan_NapTien_Momo.Size = new System.Drawing.Size(159, 26);
            this.mnuTaiKhoan_NapTien_Momo.Text = "Momo";
            // 
            // mnuTaiKhoan_NapTien_NganHang
            // 
            this.mnuTaiKhoan_NapTien_NganHang.Name = "mnuTaiKhoan_NapTien_NganHang";
            this.mnuTaiKhoan_NapTien_NganHang.Size = new System.Drawing.Size(159, 26);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 443);
            this.Controls.Add(this.picLogoShop);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMainMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.TabMuaAcc.ResumeLayout(false);
            this.TabMuaAcc.PerformLayout();
            this.grboxChonLoaiMuonMua.ResumeLayout(false);
            this.grboxChonLoaiMuonMua.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown_ThoiGianBaoHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
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
        private System.Windows.Forms.Button btnMuaAcc;
        private System.Windows.Forms.ComboBox cmbChonLoaiMuonMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberUpDown_SoLuong;
        private System.Windows.Forms.GroupBox grboxChonLoaiMuonMua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumberUpDown_ThoiGianBaoHanh;
        private System.Windows.Forms.GroupBox grboxBangGiaBaoHanh;
        private System.Windows.Forms.PictureBox picLogoShop;
        private System.Windows.Forms.Label label3;
    }
}

