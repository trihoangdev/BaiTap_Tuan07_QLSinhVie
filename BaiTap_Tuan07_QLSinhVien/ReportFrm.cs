using Microsoft.Reporting.WinForms;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace BaiTap_Tuan07_QLSinhVien
{
    public partial class ReportFrm : Form
    {
        private string _option;
        private string _value;
        public ReportFrm(string option)
        {
            InitializeComponent();
            _option = option;
        }
        public ReportFrm(string option, string value)
        {
            InitializeComponent();
            _option = option;
            _value = value;
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            if (_option == "DSSV")
            {
                try
                {
                    reportViewer.LocalReport.ReportEmbeddedResource = "BaiTap_Tuan07_QLSinhVien.ReportDSSV.rdlc";
                    var reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSetDSSV";
                    string query = @"SELECT Maso, HoTen, 
                      FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
                      CASE WHEN GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS GioiTinh,
                      DiaChi, DienThoai, maKhoa
                      FROM SinhVien";
                    reportDataSource.Value = DataProvider.LoadCSDL(query);
                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "DSSVTheoKhoa")
            {
                try
                {
                    reportViewer.LocalReport.ReportEmbeddedResource = "BaiTap_Tuan07_QLSinhVien.ReportSVTheoKhoa.rdlc";
                    string query1 = $"SELECT sv.MaSo, sv.HoTen, " +
                        $"FORMAT(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh, " +
                        $"CASE WHEN sv.GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS Gioitinh," +
                        $"sv.DiaChi,sv.DienThoai,k.TenKhoa FROM SinhVien sv " +
                        $"INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa " +
                        $"WHERE k.TenKhoa = N'{_value}';";
                    string query2 = $"SELECT k.TenKhoa FROM SinhVien sv INNER JOIN Khoa k ON sv.MaKhoa = k.MaKhoa WHERE k.TenKhoa = N'{_value}';";
                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetSV",
                        Value = DataProvider.LoadCSDL(query1)
                    };
                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetKhoa",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "XemDiem")
            {
                try
                {
                    reportViewer.LocalReport.ReportEmbeddedResource = "BaiTap_Tuan07_QLSinhVien.ReportDiem.rdlc";
                    var reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataSetDiem";
                    string query = @"select * from ketqua";
                    reportDataSource.Value = DataProvider.LoadCSDL(query);
                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "XemDiemTheoMon")
            {
                try
                {
                    reportViewer.LocalReport.ReportEmbeddedResource = "BaiTap_Tuan07_QLSinhVien.ReportDiemTheoMon.rdlc";
                    string query1 = @"select m.MaMH , m.TenMH 
                                     from ketqua k join MonHoc m on k.mamh = m.MaMH
                                     where m.tenMH = N'" + _value + "'";
                    string query2 = @"select k.Diem 
                             from ketqua k join MonHoc m on k.mamh = m.MaMH
                             where m.tenMH = N'" + _value + "'";
                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetMH",
                        Value = DataProvider.LoadCSDL(query1)
                    };
                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetKQ",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer.LocalReport.DataSources.Add(reportDataSource2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.reportViewer.RefreshReport();

        }
    }
}
