namespace BaiTap_Tuan07_QLSinhVien
{
    partial class MainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.comboMaMH = new System.Windows.Forms.ComboBox();
            this.comboMaMH2 = new System.Windows.Forms.ComboBox();
            this.txtTuKhoaTimKiem = new System.Windows.Forms.TextBox();
            this.btnTKTheoMaMH = new System.Windows.Forms.Button();
            this.btnTKTheoTuKhoa = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.btnXemDSSVTheoKhoa = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnXemDiemTheoMon = new System.Windows.Forms.Button();
            this.bT_Tuan7_QuanLySinhVienDataSet = new BaiTap_Tuan07_QLSinhVien.BT_Tuan7_QuanLySinhVienDataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new BaiTap_Tuan07_QLSinhVien.BT_Tuan7_QuanLySinhVienDataSetTableAdapters.MonHocTableAdapter();
            this.bTTuan7QuanLySinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboKhoa = new System.Windows.Forms.ComboBox();
            this.comboTenMH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT_Tuan7_QuanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTTuan7QuanLySinhVienDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiết:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn mã môn học cần tìm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(787, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập từ khóa:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(172, 68);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(187, 26);
            this.txtMaMH.TabIndex = 6;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(172, 143);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(187, 26);
            this.txtTenMH.TabIndex = 7;
            // 
            // txtTinChi
            // 
            this.txtTinChi.Enabled = false;
            this.txtTinChi.Location = new System.Drawing.Point(172, 228);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(187, 26);
            this.txtTinChi.TabIndex = 8;
            // 
            // comboMaMH
            // 
            this.comboMaMH.FormattingEnabled = true;
            this.comboMaMH.Location = new System.Drawing.Point(430, 119);
            this.comboMaMH.Name = "comboMaMH";
            this.comboMaMH.Size = new System.Drawing.Size(189, 28);
            this.comboMaMH.TabIndex = 9;
            this.comboMaMH.Click += new System.EventHandler(this.comboMaMH_Click);
            // 
            // comboMaMH2
            // 
            this.comboMaMH2.FormattingEnabled = true;
            this.comboMaMH2.Location = new System.Drawing.Point(430, 261);
            this.comboMaMH2.Name = "comboMaMH2";
            this.comboMaMH2.Size = new System.Drawing.Size(189, 28);
            this.comboMaMH2.TabIndex = 10;
            this.comboMaMH2.Click += new System.EventHandler(this.comboMaMH2_Click);
            // 
            // txtTuKhoaTimKiem
            // 
            this.txtTuKhoaTimKiem.Location = new System.Drawing.Point(829, 143);
            this.txtTuKhoaTimKiem.Name = "txtTuKhoaTimKiem";
            this.txtTuKhoaTimKiem.Size = new System.Drawing.Size(196, 26);
            this.txtTuKhoaTimKiem.TabIndex = 11;
            // 
            // btnTKTheoMaMH
            // 
            this.btnTKTheoMaMH.Enabled = false;
            this.btnTKTheoMaMH.Location = new System.Drawing.Point(430, 181);
            this.btnTKTheoMaMH.Name = "btnTKTheoMaMH";
            this.btnTKTheoMaMH.Size = new System.Drawing.Size(126, 34);
            this.btnTKTheoMaMH.TabIndex = 12;
            this.btnTKTheoMaMH.Text = "Tìm kiếm";
            this.btnTKTheoMaMH.UseVisualStyleBackColor = true;
            this.btnTKTheoMaMH.Click += new System.EventHandler(this.btnTKTheoMaMH_Click);
            // 
            // btnTKTheoTuKhoa
            // 
            this.btnTKTheoTuKhoa.Location = new System.Drawing.Point(844, 205);
            this.btnTKTheoTuKhoa.Name = "btnTKTheoTuKhoa";
            this.btnTKTheoTuKhoa.Size = new System.Drawing.Size(126, 34);
            this.btnTKTheoTuKhoa.TabIndex = 13;
            this.btnTKTheoTuKhoa.Text = "Tìm kiếm";
            this.btnTKTheoTuKhoa.UseVisualStyleBackColor = true;
            this.btnTKTheoTuKhoa.Click += new System.EventHandler(this.btnTKTheoTuKhoa_Click);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(46, 322);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(126, 34);
            this.btnHienThiTatCa.TabIndex = 14;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(46, 362);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(1080, 245);
            this.dtgv.TabIndex = 15;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(44, 627);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(113, 34);
            this.btnThemMoi.TabIndex = 16;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(268, 627);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 34);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(365, 627);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 34);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(171, 627);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 34);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Location = new System.Drawing.Point(462, 627);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(126, 34);
            this.btnXemDSSV.TabIndex = 20;
            this.btnXemDSSV.Text = "Xem DSSV";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            this.btnXemDSSV.Click += new System.EventHandler(this.btnXemDSSV_Click);
            // 
            // btnXemDSSVTheoKhoa
            // 
            this.btnXemDSSVTheoKhoa.Location = new System.Drawing.Point(602, 627);
            this.btnXemDSSVTheoKhoa.Name = "btnXemDSSVTheoKhoa";
            this.btnXemDSSVTheoKhoa.Size = new System.Drawing.Size(195, 34);
            this.btnXemDSSVTheoKhoa.TabIndex = 21;
            this.btnXemDSSVTheoKhoa.Text = "Xem DSSV theo khoa";
            this.btnXemDSSVTheoKhoa.UseVisualStyleBackColor = true;
            this.btnXemDSSVTheoKhoa.Click += new System.EventHandler(this.btnXemDSSVTheoKhoa_Click);
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(811, 627);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(133, 34);
            this.btnXemDiem.TabIndex = 22;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            this.btnXemDiem.Click += new System.EventHandler(this.btnXemDiem_Click);
            // 
            // btnXemDiemTheoMon
            // 
            this.btnXemDiemTheoMon.Location = new System.Drawing.Point(958, 627);
            this.btnXemDiemTheoMon.Name = "btnXemDiemTheoMon";
            this.btnXemDiemTheoMon.Size = new System.Drawing.Size(168, 34);
            this.btnXemDiemTheoMon.TabIndex = 23;
            this.btnXemDiemTheoMon.Text = "Xem điểm theo môn";
            this.btnXemDiemTheoMon.UseVisualStyleBackColor = true;
            this.btnXemDiemTheoMon.Click += new System.EventHandler(this.btnXemDiemTheoMon_Click);
            // 
            // bT_Tuan7_QuanLySinhVienDataSet
            // 
            this.bT_Tuan7_QuanLySinhVienDataSet.DataSetName = "BT_Tuan7_QuanLySinhVienDataSet";
            this.bT_Tuan7_QuanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.bT_Tuan7_QuanLySinhVienDataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // bTTuan7QuanLySinhVienDataSetBindingSource
            // 
            this.bTTuan7QuanLySinhVienDataSetBindingSource.DataSource = this.bT_Tuan7_QuanLySinhVienDataSet;
            this.bTTuan7QuanLySinhVienDataSetBindingSource.Position = 0;
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.bTTuan7QuanLySinhVienDataSetBindingSource;
            // 
            // comboKhoa
            // 
            this.comboKhoa.FormattingEnabled = true;
            this.comboKhoa.Location = new System.Drawing.Point(602, 685);
            this.comboKhoa.Name = "comboKhoa";
            this.comboKhoa.Size = new System.Drawing.Size(195, 28);
            this.comboKhoa.TabIndex = 24;
            this.comboKhoa.Click += new System.EventHandler(this.comboKhoa_Click);
            // 
            // comboTenMH
            // 
            this.comboTenMH.FormattingEnabled = true;
            this.comboTenMH.Location = new System.Drawing.Point(958, 685);
            this.comboTenMH.Name = "comboTenMH";
            this.comboTenMH.Size = new System.Drawing.Size(168, 28);
            this.comboTenMH.TabIndex = 25;
            this.comboTenMH.Click += new System.EventHandler(this.comboTenMH_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 743);
            this.Controls.Add(this.comboTenMH);
            this.Controls.Add(this.comboKhoa);
            this.Controls.Add(this.btnXemDiemTheoMon);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnXemDSSVTheoKhoa);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTKTheoTuKhoa);
            this.Controls.Add(this.btnTKTheoMaMH);
            this.Controls.Add(this.txtTuKhoaTimKiem);
            this.Controls.Add(this.comboMaMH2);
            this.Controls.Add(this.comboMaMH);
            this.Controls.Add(this.txtTinChi);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT_Tuan7_QuanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTTuan7QuanLySinhVienDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.ComboBox comboMaMH;
        private System.Windows.Forms.ComboBox comboMaMH2;
        private System.Windows.Forms.TextBox txtTuKhoaTimKiem;
        private System.Windows.Forms.Button btnTKTheoMaMH;
        private System.Windows.Forms.Button btnTKTheoTuKhoa;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemDSSVTheoKhoa;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnXemDiemTheoMon;
        private BT_Tuan7_QuanLySinhVienDataSet bT_Tuan7_QuanLySinhVienDataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private BT_Tuan7_QuanLySinhVienDataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.BindingSource bTTuan7QuanLySinhVienDataSetBindingSource;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private System.Windows.Forms.ComboBox comboKhoa;
        private System.Windows.Forms.ComboBox comboTenMH;
    }
}