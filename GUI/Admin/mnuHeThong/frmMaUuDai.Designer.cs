namespace QuanLyAccount3Layer.GUI.Admin.mnuHeThong
{
    partial class frmMaUuDai
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
            this.dgvMaUuDai = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGiftCode = new System.Windows.Forms.TextBox();
            this.txtPhanTramUuDai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberUpDown_SoLuotSuDung = new System.Windows.Forms.NumericUpDown();
            this.numberUpDown_HanSuDung = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtLoaiUuDai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerCheckDateGiftCode = new System.Windows.Forms.Timer(this.components);
            this.StatusMain = new System.Windows.Forms.StatusStrip();
            this.StatusAutoCheckDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerCheckLuotSuDung = new System.Windows.Forms.Timer(this.components);
            this.btnReLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaUuDai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown_SoLuotSuDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_HanSuDung)).BeginInit();
            this.StatusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaUuDai
            // 
            this.dgvMaUuDai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaUuDai.Location = new System.Drawing.Point(50, 203);
            this.dgvMaUuDai.Name = "dgvMaUuDai";
            this.dgvMaUuDai.RowHeadersVisible = false;
            this.dgvMaUuDai.RowHeadersWidth = 51;
            this.dgvMaUuDai.RowTemplate.Height = 24;
            this.dgvMaUuDai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaUuDai.Size = new System.Drawing.Size(424, 240);
            this.dgvMaUuDai.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(528, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 76);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiftCode
            // 
            this.txtGiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiftCode.Location = new System.Drawing.Point(53, 45);
            this.txtGiftCode.Name = "txtGiftCode";
            this.txtGiftCode.Size = new System.Drawing.Size(180, 30);
            this.txtGiftCode.TabIndex = 2;
            // 
            // txtPhanTramUuDai
            // 
            this.txtPhanTramUuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramUuDai.Location = new System.Drawing.Point(50, 126);
            this.txtPhanTramUuDai.Name = "txtPhanTramUuDai";
            this.txtPhanTramUuDai.Size = new System.Drawing.Size(77, 30);
            this.txtPhanTramUuDai.TabIndex = 2;
            this.txtPhanTramUuDai.TextChanged += new System.EventHandler(this.txtPhanTramUuDai_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "GiftCode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phần trăm ưu đãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hạn sử dụng ( ngày ) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại ưu đãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượt sử dụng:";
            // 
            // NumberUpDown_SoLuotSuDung
            // 
            this.NumberUpDown_SoLuotSuDung.Location = new System.Drawing.Point(482, 90);
            this.NumberUpDown_SoLuotSuDung.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumberUpDown_SoLuotSuDung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberUpDown_SoLuotSuDung.Name = "NumberUpDown_SoLuotSuDung";
            this.NumberUpDown_SoLuotSuDung.Size = new System.Drawing.Size(120, 22);
            this.NumberUpDown_SoLuotSuDung.TabIndex = 5;
            this.NumberUpDown_SoLuotSuDung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberUpDown_HanSuDung
            // 
            this.numberUpDown_HanSuDung.Location = new System.Drawing.Point(283, 52);
            this.numberUpDown_HanSuDung.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberUpDown_HanSuDung.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberUpDown_HanSuDung.Name = "numberUpDown_HanSuDung";
            this.numberUpDown_HanSuDung.Size = new System.Drawing.Size(120, 22);
            this.numberUpDown_HanSuDung.TabIndex = 6;
            this.numberUpDown_HanSuDung.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(528, 334);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 76);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtLoaiUuDai
            // 
            this.txtLoaiUuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiUuDai.Location = new System.Drawing.Point(283, 126);
            this.txtLoaiUuDai.Name = "txtLoaiUuDai";
            this.txtLoaiUuDai.ReadOnly = true;
            this.txtLoaiUuDai.Size = new System.Drawing.Size(135, 30);
            this.txtLoaiUuDai.TabIndex = 2;
            this.txtLoaiUuDai.TextChanged += new System.EventHandler(this.txtPhanTramUuDai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "%";
            // 
            // timerCheckDateGiftCode
            // 
            this.timerCheckDateGiftCode.Enabled = true;
            this.timerCheckDateGiftCode.Interval = 61000;
            this.timerCheckDateGiftCode.Tick += new System.EventHandler(this.timerCheckDateGiftCode_Tick);
            // 
            // StatusMain
            // 
            this.StatusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusAutoCheckDate});
            this.StatusMain.Location = new System.Drawing.Point(0, 461);
            this.StatusMain.Name = "StatusMain";
            this.StatusMain.Size = new System.Drawing.Size(683, 26);
            this.StatusMain.TabIndex = 8;
            // 
            // StatusAutoCheckDate
            // 
            this.StatusAutoCheckDate.Name = "StatusAutoCheckDate";
            this.StatusAutoCheckDate.Size = new System.Drawing.Size(215, 20);
            this.StatusAutoCheckDate.Text = "Check Date Giftcode : 0 second";
            // 
            // TimerCheckLuotSuDung
            // 
            this.TimerCheckLuotSuDung.Enabled = true;
            this.TimerCheckLuotSuDung.Interval = 1000;
            this.TimerCheckLuotSuDung.Tick += new System.EventHandler(this.TimerCheckLuotSuDung_Tick);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Image = global::QuanLyAccount3Layer.Properties.Resources.redo;
            this.btnReLoad.Location = new System.Drawing.Point(621, 12);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(40, 39);
            this.btnReLoad.TabIndex = 9;
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // frmMaUuDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 487);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.StatusMain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberUpDown_HanSuDung);
            this.Controls.Add(this.NumberUpDown_SoLuotSuDung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoaiUuDai);
            this.Controls.Add(this.txtPhanTramUuDai);
            this.Controls.Add(this.txtGiftCode);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvMaUuDai);
            this.Name = "frmMaUuDai";
            this.Text = "frmMaUuDai";
            this.Load += new System.EventHandler(this.frmMaUuDai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaUuDai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberUpDown_SoLuotSuDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown_HanSuDung)).EndInit();
            this.StatusMain.ResumeLayout(false);
            this.StatusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaUuDai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGiftCode;
        private System.Windows.Forms.TextBox txtPhanTramUuDai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumberUpDown_SoLuotSuDung;
        private System.Windows.Forms.NumericUpDown numberUpDown_HanSuDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtLoaiUuDai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerCheckDateGiftCode;
        private System.Windows.Forms.StatusStrip StatusMain;
        private System.Windows.Forms.ToolStripStatusLabel StatusAutoCheckDate;
        private System.Windows.Forms.Timer TimerCheckLuotSuDung;
        private System.Windows.Forms.Button btnReLoad;
    }
}