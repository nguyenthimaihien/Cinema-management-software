using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trang_chủ_của_NVQL.cgvquan3qlkhdkp;

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3qlkhdkp : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;

        public cgvquan3qlkhdkp()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện button Đăng ký
        private void btdk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Đồng ý đăng ký?", "Đăng ký phim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    them();
                    cgvquan3qlkh f = (cgvquan3qlkh)Application.OpenForms["cgvquan3qlkh"]; //Lấy đối tượng của form thể loại
                    f.hienthi();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void them()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_DangKyPhim";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 10).Value = tbmaphimdk.Text;
            cmd.Parameters.Add("@MaCum", SqlDbType.VarChar, 5).Value = "CGVQ3";
            cmd.Parameters.Add("@NgayKhoiChieu", SqlDbType.Date).Value = tbnkcdk.Text;
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = tbnktdk.Text;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 100).Value = tbghichudk.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Xử lý sự kiện cho load màn hình quản lý kế hoạch/ đăng ký phim
        private void cgvquan3qlkhdkp_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select distinct MaPhim, NgayKhoiChieu, NgayKetThuc, GhiChu from KeHoach where MaPhim not in (select MaPhim from KeHoach where MaCum = 'CGVQ3')", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            dgvdkp.DataSource = dt;
            dgvdkp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Xử lý sự kiện Cellclick cho màn hình hiển thị qlkh/đăng ký
        /*public class dataqlkhdk
        {
            public static string maphim;
            public static string ghichu;
            public static string ngaykhoichieu;
            public static string ngayketthuc;

        }*/

        int q3qlkhdk = -1;
        private void dgvdkp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            q3qlkhdk = e.RowIndex;
            if (q3qlkhdk == -1) return;
            DataRow row = dt.Rows[q3qlkhdk];
            tbmaphimdk.Text = row["MaPhim"].ToString();
            DateTime nkc = DateTime.Parse(row["NgayKhoiChieu"].ToString());
            tbnkcdk.Text = nkc.ToString("dd/MM/yyyy");
            DateTime nkt = DateTime.Parse(row["NgayKetThuc"].ToString());
            tbnktdk.Text = nkt.ToString("dd/MM/yyyy");
            tbghichudk.Text = row["GhiChu"].ToString();
        }
    }
}
