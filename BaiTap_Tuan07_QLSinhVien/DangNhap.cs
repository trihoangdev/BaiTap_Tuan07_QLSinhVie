using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_Tuan07_QLSinhVien
{
    public class DangNhap
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Quyen { get; set; }
        public DangNhap() { }
        public DangNhap(string taikhoan, string matKhau, string hoTen, string quyen)
        {
            TaiKhoan = taikhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            Quyen = quyen;
        }
        public DangNhap(string taikhoan, string matKhau) {
            TaiKhoan = taikhoan;
            MatKhau = matKhau;
        }

    }
}
