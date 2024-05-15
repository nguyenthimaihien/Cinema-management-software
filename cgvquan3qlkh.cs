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

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3qlkh : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;

        public cgvquan3qlkh()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho button Xóa
        public static int check()
        {
            DateTime dt, a;
            dt = DateTime.Parse("08/05/2023");
            a = DateTime.Parse(datatr.ngaykhoichieu);
            if (a.ToString("dd") != "01")
            {
                string n = "01/" + a.ToString("M/") + a.ToString("yyyy");
                a = DateTime.Parse(n);
            }
            TimeSpan ts = a - dt;
            int i = ts.Days;
            return i;
        }
        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Dữ liệu bị xoá sẽ không được khôi phục.\r\nBạn có chắc chắn muốn xoá phim không?", "Xóa phim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                xoadulieu();
            }
        }
        private void xoadulieu()
        {
            if(q3qlkh == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo");
                return;
            }
            DataRow row = dt.Rows[q3qlkh];
            int i = check();
            if (i > 14)
            {
                row.Delete();
                int kp = adapter.Update(dt);
                if (kp > 0)
                {
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                }
            }    
            else
            {
                MessageBox.Show("Phim đang trong thời gian chiếu. Không được phép xóa!", "Thông báo");
            }
        }
        

        //Xử lý sự kiện cho button Đăng ký
        private void btdk_Click(object sender, EventArgs e)
        {
            cgvquan3qlkhdkp cgvq3qlkhdkp = new cgvquan3qlkhdkp();
           
            cgvq3qlkhdkp.ShowDialog();
        }

        //Xử lý sự kiện cho Textbox Tìm kiếm
        private void tbtimkiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaPhim", "*" + tbtimkiem.Text + "*");
            dt.DefaultView.RowFilter = rowFilter;            
        }        

        //Xử lý sự kiện cho load gia diện quản lý kế hoạch
        private void cgvquan3qlkh_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void hienthi()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.KeHoach where MaCum = 'CGVQ3'", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                       
            adapter.Fill(dt);
            conn.Close();

            dgvq3qlkh.DataSource = dt;
            dgvq3qlkh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Xử lý sự kiện Cellclick cho màn hình hiển thị qlkh
        public class datatr
        {
            public static string maphim;
            public static string tenphim;
            public static string ngaykhoichieu;
            public static string ngayketthuc;
            
        }

        int q3qlkh = -1;
        public void dgvq3qlkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {               
            q3qlkh =e.RowIndex;
            if (q3qlkh == -1) return;
            DataRow row = dt.Rows[q3qlkh];
            datatr.maphim = row["MaPhim"].ToString();          
            datatr.ngaykhoichieu = row["NgayKhoiChieu"].ToString();
            datatr.ngayketthuc = row["NgayKetThuc"].ToString();
        }
    }
}
