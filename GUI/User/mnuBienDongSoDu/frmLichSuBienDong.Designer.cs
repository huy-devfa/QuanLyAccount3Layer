namespace QuanLyAccount3Layer.GUI.User.mnuBienDongSoDu
{
    partial class frmLichSuBienDong
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
            this.grBoxLichSuDongTien = new System.Windows.Forms.GroupBox();
            this.dgvLichSuDongTien_User = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusLoadLaiSau = new System.Windows.Forms.StatusStrip();
            this.StatusLoadLaiTrang = new System.Windows.Forms.ToolStripStatusLabel();
            this.grBoxLichSuDongTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDongTien_User)).BeginInit();
            this.statusLoadLaiSau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxLichSuDongTien
            // 
            this.grBoxLichSuDongTien.Controls.Add(this.dgvLichSuDongTien_User);
            this.grBoxLichSuDongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxLichSuDongTien.Location = new System.Drawing.Point(47, 38);
            this.grBoxLichSuDongTien.Name = "grBoxLichSuDongTien";
            this.grBoxLichSuDongTien.Size = new System.Drawing.Size(1064, 450);
            this.grBoxLichSuDongTien.TabIndex = 0;
            this.grBoxLichSuDongTien.TabStop = false;
            this.grBoxLichSuDongTien.Text = "Lịch sử dòng tiền";
            // 
            // dgvLichSuDongTien_User
            // 
            this.dgvLichSuDongTien_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuDongTien_User.Location = new System.Drawing.Point(19, 67);
            this.dgvLichSuDongTien_User.Name = "dgvLichSuDongTien_User";
            this.dgvLichSuDongTien_User.RowHeadersWidth = 51;
            this.dgvLichSuDongTien_User.RowTemplate.Height = 24;
            this.dgvLichSuDongTien_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuDongTien_User.Size = new System.Drawing.Size(1025, 360);
            this.dgvLichSuDongTien_User.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 11000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusLoadLaiSau
            // 
            this.statusLoadLaiSau.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusLoadLaiSau.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLoadLaiTrang});
            this.statusLoadLaiSau.Location = new System.Drawing.Point(0, 499);
            this.statusLoadLaiSau.Name = "statusLoadLaiSau";
            this.statusLoadLaiSau.Size = new System.Drawing.Size(1166, 26);
            this.statusLoadLaiSau.TabIndex = 1;
            // 
            // StatusLoadLaiTrang
            // 
            this.StatusLoadLaiTrang.Name = "StatusLoadLaiTrang";
            this.StatusLoadLaiTrang.Size = new System.Drawing.Size(139, 20);
            this.StatusLoadLaiTrang.Text = "Load lại sau : 0 giây";
            // 
            // frmLichSuBienDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 525);
            this.Controls.Add(this.statusLoadLaiSau);
            this.Controls.Add(this.grBoxLichSuDongTien);
            this.Name = "frmLichSuBienDong";
            this.Text = "LichSuBienDong";
            this.Load += new System.EventHandler(this.LichSuBienDong_Load);
            this.grBoxLichSuDongTien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuDongTien_User)).EndInit();
            this.statusLoadLaiSau.ResumeLayout(false);
            this.statusLoadLaiSau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxLichSuDongTien;
        private System.Windows.Forms.DataGridView dgvLichSuDongTien_User;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusLoadLaiSau;
        private System.Windows.Forms.ToolStripStatusLabel StatusLoadLaiTrang;
    }
}