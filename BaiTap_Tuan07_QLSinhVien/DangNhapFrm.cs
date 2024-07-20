using System;
using System.Data;
using System.Windows.Forms;

namespace BaiTap_Tuan07_QLSinhVien
{
    public partial class DangNhapFrm : Form
    {
        public DangNhapFrm()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            DataProvider.GetAllDangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string mk = txtMatKhau.Text;

            foreach (DangNhap dn in DataProvider.DangNhaps)
            {
                if (dn.TaiKhoan == tk && dn.MatKhau == mk)
                {
                    MainFrm frm = new MainFrm();
                    frm.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Thông tin đăng nhập không đúng vui lòng đăng nhập lại!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
