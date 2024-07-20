using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaiTap_Tuan07_QLSinhVien
{
    public class DataProvider
    {
        const string connString = "Data Source=HOANGMINHTRI\\SQLEXPRESS;Initial Catalog=BT_Tuan7_QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<DangNhap> DangNhaps = new List<DangNhap>();
        public static void OpenConnection()
        {
            connection = new SqlConnection(connString); //khởi tạo db 
            connection.Open();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }
        public static void GetAllDangNhap()
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM DangNhap", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.TaiKhoan = reader["TenDangNhap"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    dangNhap.HoTen = reader["HoTen"].ToString();
                    dangNhap.Quyen = reader["Quyen"].ToString();
                    DangNhaps.Add(dangNhap);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e + "");
            }
            finally
            {
                CloseConnection();
            }
        }

        public static DataTable LoadCSDL(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();//mở kết nối
                SqlCommand cmd = new SqlCommand(sql, connection); //Tạo các lệnh
                SqlDataAdapter da = new SqlDataAdapter(cmd);//thực thi những lệnh
                da.Fill(dt); //đổ dữ liệu vào datatable
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
        public static int ThaoTacCSDL(string sql)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, connection);
                kq = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }
    }
}
