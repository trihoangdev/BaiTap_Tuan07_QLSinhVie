using System;
using System.Data;
using System.Windows.Forms;

namespace BaiTap_Tuan07_QLSinhVien
{
    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadTableMonHoc();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            this.monHocTableAdapter.Fill(this.bT_Tuan7_QuanLySinhVienDataSet.MonHoc);
        }

        private void LoadTableMonHoc()
        {
            string queryLoadMonHoc = @"select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queryLoadMonHoc);
            dtgv.DataSource = dt;
            dtgv.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            EnableTextbox();
            ClearTextbox();
            //Nút lưu sáng lên
            btnLuu.Enabled = true;
        }

        private void ClearTextbox()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtTinChi.Clear();
        }

        private void EnableTextbox()
        {
            //Hiển thị các ô textbox
            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
            txtTinChi.Enabled = true;
            txtMaMH.Focus();
        }

        private void UnenableTextbox()
        {
            ClearTextbox();
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtTinChi.Enabled = false;
        }
        public void LoadComboMaMH()
        {
            string sqlLoadComboMaMH = @"select * from MonHoc";
            comboMaMH.DataSource = DataProvider.LoadCSDL(sqlLoadComboMaMH);
            comboMaMH.DisplayMember = "TenMH";//Hiển thị tên lên combo
            comboMaMH.ValueMember = "MaMH";//Giá trị thực chất của combo
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTinChi = txtTinChi.Text;
            string sqlLuuMonHoc = $"insert into MonHoc (MaMH, TenMH, SoTiet) values ('{maMH}', N'{tenMH}', {soTinChi})";
            int kq = DataProvider.ThaoTacCSDL(sqlLuuMonHoc);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadTableMonHoc();
                UnenableTextbox();
                btnLuu.Enabled = false;
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dòng được chọn
            if (dtgv.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgv.SelectedRows[0];

                //Truyền các giá trị lên textbox
                txtMaMH.Text = dongDuocChon.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dongDuocChon.Cells["TenMH"].Value.ToString();
                txtTinChi.Text = dongDuocChon.Cells["SoTiet"].Value.ToString();

                //Hiển thị các textbox
                EnableTextbox();
                txtMaMH.Enabled = false;

                //sáng ô xóa và sửa lên
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTinChi = txtTinChi.Text;
            string sqlUpdateMH = $"UPDATE MonHoc SET TenMH = N'{tenMH}',  SoTiet = {soTinChi} WHERE MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(sqlUpdateMH);
            if (kq > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadTableMonHoc();
                UnenableTextbox();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string sqlUpdateMH = $"DELETE MonHoc WHERE MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(sqlUpdateMH);
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!");
                LoadTableMonHoc();
                UnenableTextbox();
                btnLuu.Enabled = false;
            }
        }

        private void comboMaMH_Click(object sender, EventArgs e)
        {
            LoadComboMaMH();
            btnTKTheoMaMH.Enabled = true;
        }

        private void comboMaMH2_Click(object sender, EventArgs e)
        {
            //LoadComboMaMH(comboMaMH2);
        }

        private void btnTKTheoMaMH_Click(object sender, EventArgs e)
        {
            string maMH = (string)comboMaMH.SelectedValue;
            string queryLoadMonHoc = $"select * from MonHoc where maMH = '{maMH}'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queryLoadMonHoc);
            dtgv.DataSource = dt;
        }

        private void btnTKTheoTuKhoa_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoaTimKiem.Text;
            string queyLoadSV = $"select * from MonHoc where tenMH LIKE N'%{tuKhoa}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queyLoadSV);
            dtgv.DataSource = dt;
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            /* string queyLoadSV = @"select * from SinhVien";
             dt.Clear();
             dt = DataProvider.LoadCSDL(queyLoadSV);
             dtgv.DataSource = dt;*/
            ReportFrm reportFrm = new ReportFrm("DSSV");
            reportFrm.ShowDialog();
        }

        private void btnXemDSSVTheoKhoa_Click(object sender, EventArgs e)
        {
            /*string queyLoadSV = @"SELECT
                                    sv.MaSo,
                                    sv.HoTen,
                                    sv.NgaySinh,
                                    sv.Gioitinh,
                                    sv.DiaChi,
                                    sv.DienThoai,
                                    k.TenKhoa
                                FROM
                                    SinhVien sv
                                INNER JOIN
                                    Khoa k ON sv.MaKhoa = k.MaKhoa
                                ORDER BY
                                    k.TenKhoa;";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queyLoadSV);
            dtgv.DataSource = dt;*/
            ReportFrm reportFrm = new ReportFrm("DSSVTheoKhoa");
            reportFrm.ShowDialog();
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            /*string queryLoadDiem = @"select * from ketqua";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queryLoadDiem);
            dtgv.DataSource = dt;*/
            ReportFrm reportFrm = new ReportFrm("XemDiem");
            reportFrm.ShowDialog();
        }

        private void btnXemDiemTheoMon_Click(object sender, EventArgs e)
        {
            /*string queryLoadDiem = @"
                            select k.MaMH as N'Mã MH', m.TenMH as N'Tên MH', k.Diem as N'Điểm'
                            from ketqua k join MonHoc m on k.mamh = m.MaMH
                            order by m.TenMH";
            dt.Clear();
            dt = DataProvider.LoadCSDL(queryLoadDiem);
            dtgv.DataSource = dt;*/
            ReportFrm reportFrm = new ReportFrm("XemDiemTheoMon");
            reportFrm.ShowDialog();
        }
    }
}
