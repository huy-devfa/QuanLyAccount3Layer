namespace QuanLyAccount3Layer.GUI.User.mnuTienIch
{
    partial class frmCatChuoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCat = new System.Windows.Forms.Button();
            this.txtDenCum = new System.Windows.Forms.TextBox();
            this.txtBatDauCat = new System.Windows.Forms.TextBox();
            this.txtNganCachBoiKyTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtNhapTaiKhoan = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusSoDong = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDenCum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiCat = new System.Windows.Forms.ComboBox();
            this.contextmnu_rtxtNhapTaiKhoan = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmnu_rtxtNhapTaiKhoan_Dan = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.rtxtKetQuaCat = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Contextmnu_rtxtKetQua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Contextmnu_rtxtKetQua_SaoChep = new System.Windows.Forms.ToolStripMenuItem();
            this.Contextmnu_rtxtKetQua_Dan = new System.Windows.Forms.ToolStripMenuItem();
            this.Contextmnu_rtxtKetQua_ChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextmnu_rtxtNhapTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.Contextmnu_rtxtKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngăn cách bởi ký tự";
            // 
            // btnCat
            // 
            this.btnCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.Location = new System.Drawing.Point(361, 127);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(100, 44);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cắt";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // txtDenCum
            // 
            this.txtDenCum.Location = new System.Drawing.Point(467, 151);
            this.txtDenCum.Name = "txtDenCum";
            this.txtDenCum.Size = new System.Drawing.Size(154, 20);
            this.txtDenCum.TabIndex = 3;
            this.txtDenCum.TextChanged += new System.EventHandler(this.txtDenCum_TextChanged);
            this.txtDenCum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDenCum_KeyPress);
            // 
            // txtBatDauCat
            // 
            this.txtBatDauCat.Location = new System.Drawing.Point(467, 101);
            this.txtBatDauCat.Name = "txtBatDauCat";
            this.txtBatDauCat.Size = new System.Drawing.Size(154, 20);
            this.txtBatDauCat.TabIndex = 4;
            this.txtBatDauCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatDauCat_KeyPress);
            // 
            // txtNganCachBoiKyTu
            // 
            this.txtNganCachBoiKyTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNganCachBoiKyTu.Location = new System.Drawing.Point(470, 51);
            this.txtNganCachBoiKyTu.Name = "txtNganCachBoiKyTu";
            this.txtNganCachBoiKyTu.Size = new System.Drawing.Size(152, 20);
            this.txtNganCachBoiKyTu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập tài khoản:";
            // 
            // rtxtNhapTaiKhoan
            // 
            this.rtxtNhapTaiKhoan.AcceptsTab = true;
            this.rtxtNhapTaiKhoan.ContextMenuStrip = this.contextmnu_rtxtNhapTaiKhoan;
            this.rtxtNhapTaiKhoan.Location = new System.Drawing.Point(34, 180);
            this.rtxtNhapTaiKhoan.Name = "rtxtNhapTaiKhoan";
            this.rtxtNhapTaiKhoan.Size = new System.Drawing.Size(587, 182);
            this.rtxtNhapTaiKhoan.TabIndex = 7;
            this.rtxtNhapTaiKhoan.Text = "1 dòng 1 account...";
            this.rtxtNhapTaiKhoan.WordWrap = false;
            this.rtxtNhapTaiKhoan.TextChanged += new System.EventHandler(this.rtxtNhapTaiKhoan_TextChanged);
            this.rtxtNhapTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtNhapTaiKhoan_KeyPress);
            this.rtxtNhapTaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtNhapTaiKhoan_Validating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSoDong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(650, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusSoDong
            // 
            this.statusSoDong.Name = "statusSoDong";
            this.statusSoDong.Size = new System.Drawing.Size(49, 17);
            this.statusSoDong.Text = "Lines : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bắt đầu cắt";
            // 
            // lblDenCum
            // 
            this.lblDenCum.AutoSize = true;
            this.lblDenCum.Location = new System.Drawing.Point(467, 132);
            this.lblDenCum.Name = "lblDenCum";
            this.lblDenCum.Size = new System.Drawing.Size(50, 13);
            this.lblDenCum.TabIndex = 10;
            this.lblDenCum.Text = "Đến cụm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Loại cắt :";
            // 
            // cmbLoaiCat
            // 
            this.cmbLoaiCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiCat.FormattingEnabled = true;
            this.cmbLoaiCat.Items.AddRange(new object[] {
            "Cắt từ x đến y"});
            this.cmbLoaiCat.Location = new System.Drawing.Point(470, 12);
            this.cmbLoaiCat.Name = "cmbLoaiCat";
            this.cmbLoaiCat.Size = new System.Drawing.Size(151, 26);
            this.cmbLoaiCat.TabIndex = 12;
            // 
            // contextmnu_rtxtNhapTaiKhoan
            // 
            this.contextmnu_rtxtNhapTaiKhoan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep,
            this.contextmnu_rtxtNhapTaiKhoan_Dan,
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa});
            this.contextmnu_rtxtNhapTaiKhoan.Name = "contextmnu_rtxtNhapTaiKhoan";
            this.contextmnu_rtxtNhapTaiKhoan.Size = new System.Drawing.Size(178, 70);
            // 
            // contextmnu_rtxtNhapTaiKhoan_ChonTatCa
            // 
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa.Name = "contextmnu_rtxtNhapTaiKhoan_ChonTatCa";
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa.Size = new System.Drawing.Size(177, 22);
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa.Text = "Chọn tất cả";
            this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa.Click += new System.EventHandler(this.contextmnu_rtxtNhapTaiKhoan_ChonTatCa_Click);
            // 
            // contextmnu_rtxtNhapTaiKhoan_SaoChep
            // 
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.Image = global::QuanLyAccount3Layer.Properties.Resources.copy;
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.Name = "contextmnu_rtxtNhapTaiKhoan_SaoChep";
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.Size = new System.Drawing.Size(177, 22);
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.Text = "Sao Chép";
            this.contextmnu_rtxtNhapTaiKhoan_SaoChep.Click += new System.EventHandler(this.contextmnu_rtxtNhapTaiKhoan_SaoChep_Click);
            // 
            // contextmnu_rtxtNhapTaiKhoan_Dan
            // 
            this.contextmnu_rtxtNhapTaiKhoan_Dan.Image = global::QuanLyAccount3Layer.Properties.Resources.paste;
            this.contextmnu_rtxtNhapTaiKhoan_Dan.Name = "contextmnu_rtxtNhapTaiKhoan_Dan";
            this.contextmnu_rtxtNhapTaiKhoan_Dan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.contextmnu_rtxtNhapTaiKhoan_Dan.Size = new System.Drawing.Size(177, 22);
            this.contextmnu_rtxtNhapTaiKhoan_Dan.Text = "Dán";
            this.contextmnu_rtxtNhapTaiKhoan_Dan.Click += new System.EventHandler(this.contextmnu_rtxtNhapTaiKhoan_Dan_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::QuanLyAccount3Layer.Properties.Resources.ShopTuDoi1;
            this.picLogo.Location = new System.Drawing.Point(34, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(115, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // rtxtKetQuaCat
            // 
            this.rtxtKetQuaCat.ContextMenuStrip = this.Contextmnu_rtxtKetQua;
            this.rtxtKetQuaCat.Location = new System.Drawing.Point(34, 413);
            this.rtxtKetQuaCat.Name = "rtxtKetQuaCat";
            this.rtxtKetQuaCat.Size = new System.Drawing.Size(587, 182);
            this.rtxtKetQuaCat.TabIndex = 7;
            this.rtxtKetQuaCat.Text = "";
            this.rtxtKetQuaCat.WordWrap = false;
            this.rtxtKetQuaCat.TextChanged += new System.EventHandler(this.rtxtNhapTaiKhoan_TextChanged);
            this.rtxtKetQuaCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtxtNhapTaiKhoan_KeyPress);
            this.rtxtKetQuaCat.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtNhapTaiKhoan_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kết quả:";
            // 
            // Contextmnu_rtxtKetQua
            // 
            this.Contextmnu_rtxtKetQua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Contextmnu_rtxtKetQua_SaoChep,
            this.Contextmnu_rtxtKetQua_Dan,
            this.Contextmnu_rtxtKetQua_ChonTatCa});
            this.Contextmnu_rtxtKetQua.Name = "Contextmnu_rtxtKetQua";
            this.Contextmnu_rtxtKetQua.Size = new System.Drawing.Size(136, 70);
            // 
            // Contextmnu_rtxtKetQua_SaoChep
            // 
            this.Contextmnu_rtxtKetQua_SaoChep.Image = global::QuanLyAccount3Layer.Properties.Resources.copy;
            this.Contextmnu_rtxtKetQua_SaoChep.Name = "Contextmnu_rtxtKetQua_SaoChep";
            this.Contextmnu_rtxtKetQua_SaoChep.Size = new System.Drawing.Size(180, 22);
            this.Contextmnu_rtxtKetQua_SaoChep.Text = "Sao chép";
            this.Contextmnu_rtxtKetQua_SaoChep.Click += new System.EventHandler(this.Contextmnu_rtxtKetQua_SaoChep_Click);
            // 
            // Contextmnu_rtxtKetQua_Dan
            // 
            this.Contextmnu_rtxtKetQua_Dan.Image = global::QuanLyAccount3Layer.Properties.Resources.paste;
            this.Contextmnu_rtxtKetQua_Dan.Name = "Contextmnu_rtxtKetQua_Dan";
            this.Contextmnu_rtxtKetQua_Dan.Size = new System.Drawing.Size(180, 22);
            this.Contextmnu_rtxtKetQua_Dan.Text = "Dán";
            this.Contextmnu_rtxtKetQua_Dan.Click += new System.EventHandler(this.Contextmnu_rtxtKetQua_Dan_Click);
            // 
            // Contextmnu_rtxtKetQua_ChonTatCa
            // 
            this.Contextmnu_rtxtKetQua_ChonTatCa.Name = "Contextmnu_rtxtKetQua_ChonTatCa";
            this.Contextmnu_rtxtKetQua_ChonTatCa.Size = new System.Drawing.Size(180, 22);
            this.Contextmnu_rtxtKetQua_ChonTatCa.Text = "Chọn tất cả";
            this.Contextmnu_rtxtKetQua_ChonTatCa.Click += new System.EventHandler(this.Contextmnu_rtxtKetQua_ChonTatCa_Click);
            // 
            // frmCatChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 620);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLoaiCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDenCum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtxtKetQuaCat);
            this.Controls.Add(this.rtxtNhapTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txtNganCachBoiKyTu);
            this.Controls.Add(this.txtBatDauCat);
            this.Controls.Add(this.txtDenCum);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCatChuoi";
            this.Text = "frmCatChuoi";
            this.Load += new System.EventHandler(this.frmCatChuoi_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextmnu_rtxtNhapTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.Contextmnu_rtxtKetQua.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.TextBox txtDenCum;
        private System.Windows.Forms.TextBox txtBatDauCat;
        private System.Windows.Forms.TextBox txtNganCachBoiKyTu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtNhapTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusSoDong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDenCum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiCat;
        private System.Windows.Forms.ContextMenuStrip contextmnu_rtxtNhapTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem contextmnu_rtxtNhapTaiKhoan_SaoChep;
        private System.Windows.Forms.ToolStripMenuItem contextmnu_rtxtNhapTaiKhoan_Dan;
        private System.Windows.Forms.ToolStripMenuItem contextmnu_rtxtNhapTaiKhoan_ChonTatCa;
        private System.Windows.Forms.RichTextBox rtxtKetQuaCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip Contextmnu_rtxtKetQua;
        private System.Windows.Forms.ToolStripMenuItem Contextmnu_rtxtKetQua_SaoChep;
        private System.Windows.Forms.ToolStripMenuItem Contextmnu_rtxtKetQua_Dan;
        private System.Windows.Forms.ToolStripMenuItem Contextmnu_rtxtKetQua_ChonTatCa;
    }
}