namespace QuanLyAccount3Layer.GUI
{
    partial class frmAdmin_Thongke
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
            this.mnuAdmin = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_Lichsugiaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_ThongTinThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_MaUuDai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_HeThong_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_QuanLy_ThemLoaiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_QuanLy_QuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin_QuanLy_QuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.grBoxTongKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTongKhachHang = new System.Windows.Forms.Label();
            this.grBoxTongTaiKhoanDaBan = new System.Windows.Forms.GroupBox();
            this.lblTongTaiKhoanDaBan = new System.Windows.Forms.Label();
            this.grBoxTongDoanhThu = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblXinChaoUser = new System.Windows.Forms.Label();
            this.grBoxTongTienConLaiCuaKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTongTienConLaiCuaKhachHang = new System.Windows.Forms.Label();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvGiaoDichGanDay = new System.Windows.Forms.DataGridView();
            this.grboxGiaoDichGanDay = new System.Windows.Forms.GroupBox();
            this.txtTimUser = new System.Windows.Forms.TextBox();
            this.btnTimUser = new System.Windows.Forms.Button();
            this.mnuAdmin.SuspendLayout();
            this.grBoxTongKhachHang.SuspendLayout();
            this.grBoxTongTaiKhoanDaBan.SuspendLayout();
            this.grBoxTongDoanhThu.SuspendLayout();
            this.grBoxTongTienConLaiCuaKhachHang.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichGanDay)).BeginInit();
            this.grboxGiaoDichGanDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_HeThong,
            this.mnuAdmin_QuanLy});
            this.mnuAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuAdmin.Size = new System.Drawing.Size(879, 24);
            this.mnuAdmin.TabIndex = 0;
            this.mnuAdmin.Text = "menuStrip1";
            this.mnuAdmin.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAdmin_ItemClicked);
            // 
            // mnuAdmin_HeThong
            // 
            this.mnuAdmin_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_HeThong_ThongKe,
            this.mnuAdmin_HeThong_Lichsugiaodich,
            this.mnuAdmin_HeThong_ThongTinThanhToan,
            this.mnuAdmin_HeThong_MaUuDai,
            this.mnuAdmin_HeThong_Thoat});
            this.mnuAdmin_HeThong.Name = "mnuAdmin_HeThong";
            this.mnuAdmin_HeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuAdmin_HeThong.Text = "Hệ thống";
            // 
            // mnuAdmin_HeThong_ThongKe
            // 
            this.mnuAdmin_HeThong_ThongKe.Name = "mnuAdmin_HeThong_ThongKe";
            this.mnuAdmin_HeThong_ThongKe.Size = new System.Drawing.Size(186, 22);
            this.mnuAdmin_HeThong_ThongKe.Text = "Thống kê";
            // 
            // mnuAdmin_HeThong_Lichsugiaodich
            // 
            this.mnuAdmin_HeThong_Lichsugiaodich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang,
            this.mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien,
            this.mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien});
            this.mnuAdmin_HeThong_Lichsugiaodich.Name = "mnuAdmin_HeThong_Lichsugiaodich";
            this.mnuAdmin_HeThong_Lichsugiaodich.Size = new System.Drawing.Size(186, 22);
            this.mnuAdmin_HeThong_Lichsugiaodich.Text = "Lịch sử giao dịch";
            // 
            // mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang
            // 
            this.mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang.Name = "mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang";
            this.mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang.Size = new System.Drawing.Size(182, 22);
            this.mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang.Text = "Lịch sử bán hàng";
            // 
            // mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien
            // 
            this.mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien.Name = "mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien";
            this.mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien.Size = new System.Drawing.Size(182, 22);
            this.mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien.Text = "Biến động dòng tiền";
            // 
            // mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien
            // 
            this.mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien.Name = "mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien";
            this.mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien.Size = new System.Drawing.Size(182, 22);
            this.mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien.Text = "Lịch sử nạp tiền";
            // 
            // mnuAdmin_HeThong_ThongTinThanhToan
            // 
            this.mnuAdmin_HeThong_ThongTinThanhToan.Name = "mnuAdmin_HeThong_ThongTinThanhToan";
            this.mnuAdmin_HeThong_ThongTinThanhToan.Size = new System.Drawing.Size(186, 22);
            this.mnuAdmin_HeThong_ThongTinThanhToan.Text = "Thông tin thanh toán";
            this.mnuAdmin_HeThong_ThongTinThanhToan.Click += new System.EventHandler(this.mnuAdmin_HeThong_ThongTinThanhToan_Click);
            // 
            // mnuAdmin_HeThong_MaUuDai
            // 
            this.mnuAdmin_HeThong_MaUuDai.Name = "mnuAdmin_HeThong_MaUuDai";
            this.mnuAdmin_HeThong_MaUuDai.Size = new System.Drawing.Size(186, 22);
            this.mnuAdmin_HeThong_MaUuDai.Text = "Mã ưu đãi";
            // 
            // mnuAdmin_HeThong_Thoat
            // 
            this.mnuAdmin_HeThong_Thoat.Name = "mnuAdmin_HeThong_Thoat";
            this.mnuAdmin_HeThong_Thoat.Size = new System.Drawing.Size(186, 22);
            this.mnuAdmin_HeThong_Thoat.Text = "Thoát";
            // 
            // mnuAdmin_QuanLy
            // 
            this.mnuAdmin_QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin_QuanLy_ThemLoaiTaiKhoan,
            this.mnuAdmin_QuanLy_QuanLyTaiKhoan,
            this.mnuAdmin_QuanLy_QuanLyKhachHang});
            this.mnuAdmin_QuanLy.Name = "mnuAdmin_QuanLy";
            this.mnuAdmin_QuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuAdmin_QuanLy.Text = "Quản lý";
            // 
            // mnuAdmin_QuanLy_ThemLoaiTaiKhoan
            // 
            this.mnuAdmin_QuanLy_ThemLoaiTaiKhoan.Name = "mnuAdmin_QuanLy_ThemLoaiTaiKhoan";
            this.mnuAdmin_QuanLy_ThemLoaiTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_QuanLy_ThemLoaiTaiKhoan.Text = "Thêm loại tài khoản";
            // 
            // mnuAdmin_QuanLy_QuanLyTaiKhoan
            // 
            this.mnuAdmin_QuanLy_QuanLyTaiKhoan.Name = "mnuAdmin_QuanLy_QuanLyTaiKhoan";
            this.mnuAdmin_QuanLy_QuanLyTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_QuanLy_QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mnuAdmin_QuanLy_QuanLyKhachHang
            // 
            this.mnuAdmin_QuanLy_QuanLyKhachHang.Name = "mnuAdmin_QuanLy_QuanLyKhachHang";
            this.mnuAdmin_QuanLy_QuanLyKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuAdmin_QuanLy_QuanLyKhachHang.Text = "Quản lý khách hàng";
            this.mnuAdmin_QuanLy_QuanLyKhachHang.Click += new System.EventHandler(this.mnuAdmin_QuanLy_QuanLyKhachHang_Click);
            // 
            // grBoxTongKhachHang
            // 
            this.grBoxTongKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(114)))), ((int)(((byte)(108)))));
            this.grBoxTongKhachHang.Controls.Add(this.lblTongKhachHang);
            this.grBoxTongKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTongKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.grBoxTongKhachHang.Location = new System.Drawing.Point(220, 93);
            this.grBoxTongKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.grBoxTongKhachHang.Name = "grBoxTongKhachHang";
            this.grBoxTongKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.grBoxTongKhachHang.Size = new System.Drawing.Size(176, 116);
            this.grBoxTongKhachHang.TabIndex = 1;
            this.grBoxTongKhachHang.TabStop = false;
            this.grBoxTongKhachHang.Text = "Tổng khách hàng ";
            // 
            // lblTongKhachHang
            // 
            this.lblTongKhachHang.AutoSize = true;
            this.lblTongKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblTongKhachHang.Location = new System.Drawing.Point(132, 71);
            this.lblTongKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongKhachHang.Name = "lblTongKhachHang";
            this.lblTongKhachHang.Size = new System.Drawing.Size(26, 29);
            this.lblTongKhachHang.TabIndex = 0;
            this.lblTongKhachHang.Text = "0";
            // 
            // grBoxTongTaiKhoanDaBan
            // 
            this.grBoxTongTaiKhoanDaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(239)))), ((int)(((byte)(78)))));
            this.grBoxTongTaiKhoanDaBan.Controls.Add(this.lblTongTaiKhoanDaBan);
            this.grBoxTongTaiKhoanDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTongTaiKhoanDaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.grBoxTongTaiKhoanDaBan.Location = new System.Drawing.Point(641, 93);
            this.grBoxTongTaiKhoanDaBan.Margin = new System.Windows.Forms.Padding(2);
            this.grBoxTongTaiKhoanDaBan.Name = "grBoxTongTaiKhoanDaBan";
            this.grBoxTongTaiKhoanDaBan.Padding = new System.Windows.Forms.Padding(2);
            this.grBoxTongTaiKhoanDaBan.Size = new System.Drawing.Size(176, 116);
            this.grBoxTongTaiKhoanDaBan.TabIndex = 1;
            this.grBoxTongTaiKhoanDaBan.TabStop = false;
            this.grBoxTongTaiKhoanDaBan.Text = "Tổng tài khoản đã bán";
            // 
            // lblTongTaiKhoanDaBan
            // 
            this.lblTongTaiKhoanDaBan.AutoSize = true;
            this.lblTongTaiKhoanDaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTaiKhoanDaBan.ForeColor = System.Drawing.Color.Black;
            this.lblTongTaiKhoanDaBan.Location = new System.Drawing.Point(136, 71);
            this.lblTongTaiKhoanDaBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTaiKhoanDaBan.Name = "lblTongTaiKhoanDaBan";
            this.lblTongTaiKhoanDaBan.Size = new System.Drawing.Size(26, 29);
            this.lblTongTaiKhoanDaBan.TabIndex = 0;
            this.lblTongTaiKhoanDaBan.Text = "0";
            // 
            // grBoxTongDoanhThu
            // 
            this.grBoxTongDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(186)))), ((int)(((byte)(46)))));
            this.grBoxTongDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.grBoxTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.grBoxTongDoanhThu.Location = new System.Drawing.Point(437, 230);
            this.grBoxTongDoanhThu.Margin = new System.Windows.Forms.Padding(2);
            this.grBoxTongDoanhThu.Name = "grBoxTongDoanhThu";
            this.grBoxTongDoanhThu.Padding = new System.Windows.Forms.Padding(2);
            this.grBoxTongDoanhThu.Size = new System.Drawing.Size(380, 116);
            this.grBoxTongDoanhThu.TabIndex = 1;
            this.grBoxTongDoanhThu.TabStop = false;
            this.grBoxTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Black;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(4, 71);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(26, 29);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "0";
            // 
            // lblXinChaoUser
            // 
            this.lblXinChaoUser.AutoSize = true;
            this.lblXinChaoUser.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChaoUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblXinChaoUser.Location = new System.Drawing.Point(10, 37);
            this.lblXinChaoUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXinChaoUser.Name = "lblXinChaoUser";
            this.lblXinChaoUser.Size = new System.Drawing.Size(190, 31);
            this.lblXinChaoUser.TabIndex = 2;
            this.lblXinChaoUser.Text = "Xin chào, User!";
            // 
            // grBoxTongTienConLaiCuaKhachHang
            // 
            this.grBoxTongTienConLaiCuaKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.grBoxTongTienConLaiCuaKhachHang.Controls.Add(this.lblTongTienConLaiCuaKhachHang);
            this.grBoxTongTienConLaiCuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxTongTienConLaiCuaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
            this.grBoxTongTienConLaiCuaKhachHang.Location = new System.Drawing.Point(16, 230);
            this.grBoxTongTienConLaiCuaKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.grBoxTongTienConLaiCuaKhachHang.Name = "grBoxTongTienConLaiCuaKhachHang";
            this.grBoxTongTienConLaiCuaKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.grBoxTongTienConLaiCuaKhachHang.Size = new System.Drawing.Size(380, 116);
            this.grBoxTongTienConLaiCuaKhachHang.TabIndex = 1;
            this.grBoxTongTienConLaiCuaKhachHang.TabStop = false;
            this.grBoxTongTienConLaiCuaKhachHang.Text = "Tổng tiền còn lại của khách hàng";
            // 
            // lblTongTienConLaiCuaKhachHang
            // 
            this.lblTongTienConLaiCuaKhachHang.AutoSize = true;
            this.lblTongTienConLaiCuaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTienConLaiCuaKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblTongTienConLaiCuaKhachHang.Location = new System.Drawing.Point(4, 71);
            this.lblTongTienConLaiCuaKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTienConLaiCuaKhachHang.Name = "lblTongTienConLaiCuaKhachHang";
            this.lblTongTienConLaiCuaKhachHang.Size = new System.Drawing.Size(26, 29);
            this.lblTongTienConLaiCuaKhachHang.TabIndex = 0;
            this.lblTongTienConLaiCuaKhachHang.Text = "0";
            // 
            // timerLoad
            // 
            this.timerLoad.Enabled = true;
            this.timerLoad.Interval = 11000;
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLoad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLoad
            // 
            this.statusLoad.Name = "statusLoad";
            this.statusLoad.Size = new System.Drawing.Size(104, 17);
            this.statusLoad.Text = "Tải lại sau : 10 giây";
            // 
            // dgvGiaoDichGanDay
            // 
            this.dgvGiaoDichGanDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDichGanDay.Location = new System.Drawing.Point(15, 78);
            this.dgvGiaoDichGanDay.Name = "dgvGiaoDichGanDay";
            this.dgvGiaoDichGanDay.RowHeadersVisible = false;
            this.dgvGiaoDichGanDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoDichGanDay.Size = new System.Drawing.Size(817, 271);
            this.dgvGiaoDichGanDay.TabIndex = 4;
            // 
            // grboxGiaoDichGanDay
            // 
            this.grboxGiaoDichGanDay.Controls.Add(this.btnTimUser);
            this.grboxGiaoDichGanDay.Controls.Add(this.dgvGiaoDichGanDay);
            this.grboxGiaoDichGanDay.Controls.Add(this.txtTimUser);
            this.grboxGiaoDichGanDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grboxGiaoDichGanDay.Location = new System.Drawing.Point(19, 365);
            this.grboxGiaoDichGanDay.Name = "grboxGiaoDichGanDay";
            this.grboxGiaoDichGanDay.Size = new System.Drawing.Size(847, 355);
            this.grboxGiaoDichGanDay.TabIndex = 5;
            this.grboxGiaoDichGanDay.TabStop = false;
            this.grboxGiaoDichGanDay.Text = "Giao dịch gần đây";
            // 
            // txtTimUser
            // 
            this.txtTimUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimUser.Location = new System.Drawing.Point(588, 32);
            this.txtTimUser.Name = "txtTimUser";
            this.txtTimUser.Size = new System.Drawing.Size(196, 29);
            this.txtTimUser.TabIndex = 17;
            this.txtTimUser.Text = "Nhập tên cần tìm..";
            this.txtTimUser.TextChanged += new System.EventHandler(this.txtTimUser_TextChanged);
            // 
            // btnTimUser
            // 
            this.btnTimUser.Image = global::QuanLyAccount3Layer.Properties.Resources.find;
            this.btnTimUser.Location = new System.Drawing.Point(790, 23);
            this.btnTimUser.Name = "btnTimUser";
            this.btnTimUser.Size = new System.Drawing.Size(48, 44);
            this.btnTimUser.TabIndex = 18;
            this.btnTimUser.UseVisualStyleBackColor = true;
            this.btnTimUser.Click += new System.EventHandler(this.btnTimUser_Click);
            // 
            // frmAdmin_Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 753);
            this.Controls.Add(this.grboxGiaoDichGanDay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblXinChaoUser);
            this.Controls.Add(this.grBoxTongTienConLaiCuaKhachHang);
            this.Controls.Add(this.grBoxTongDoanhThu);
            this.Controls.Add(this.grBoxTongTaiKhoanDaBan);
            this.Controls.Add(this.grBoxTongKhachHang);
            this.Controls.Add(this.mnuAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuAdmin;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAdmin_Thongke";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmAdmin_Thongke_Load);
            this.mnuAdmin.ResumeLayout(false);
            this.mnuAdmin.PerformLayout();
            this.grBoxTongKhachHang.ResumeLayout(false);
            this.grBoxTongKhachHang.PerformLayout();
            this.grBoxTongTaiKhoanDaBan.ResumeLayout(false);
            this.grBoxTongTaiKhoanDaBan.PerformLayout();
            this.grBoxTongDoanhThu.ResumeLayout(false);
            this.grBoxTongDoanhThu.PerformLayout();
            this.grBoxTongTienConLaiCuaKhachHang.ResumeLayout(false);
            this.grBoxTongTienConLaiCuaKhachHang.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDichGanDay)).EndInit();
            this.grboxGiaoDichGanDay.ResumeLayout(false);
            this.grboxGiaoDichGanDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_ThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_Lichsugiaodich;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_Lichsugiaodich_Lichsubanhang;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_Lichsugiaodich_BienDongDongTien;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_Lichsugiaodich_LichSuNapTien;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_ThongTinThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_MaUuDai;
        private System.Windows.Forms.GroupBox grBoxTongKhachHang;
        private System.Windows.Forms.GroupBox grBoxTongTaiKhoanDaBan;
        private System.Windows.Forms.GroupBox grBoxTongDoanhThu;
        private System.Windows.Forms.Label lblXinChaoUser;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_QuanLy_ThemLoaiTaiKhoan;
        private System.Windows.Forms.Label lblTongKhachHang;
        private System.Windows.Forms.Label lblTongTaiKhoanDaBan;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_HeThong_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_QuanLy_QuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin_QuanLy_QuanLyKhachHang;
        private System.Windows.Forms.GroupBox grBoxTongTienConLaiCuaKhachHang;
        private System.Windows.Forms.Label lblTongTienConLaiCuaKhachHang;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLoad;
        private System.Windows.Forms.DataGridView dgvGiaoDichGanDay;
        private System.Windows.Forms.GroupBox grboxGiaoDichGanDay;
        private System.Windows.Forms.Button btnTimUser;
        private System.Windows.Forms.TextBox txtTimUser;
    }
}