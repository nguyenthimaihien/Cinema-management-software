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
using static Trang_chủ_của_NVQL.cgvquan3qlkh;

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3qllc : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;        

        public cgvquan3qllc()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho textbox Thanh tìm kiếm
        private void tbtimkiem_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "MaPhim", "*" + tbtimkiem.Text + "*");
            (dgvq3qllc.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        //Xử lý sự kiện cho button Xóa
        private int check()
        {
            DateTime dt, a, c, d;
            dt = DateTime.Parse("01/01/1900");
            a = DateTime.Parse(data.ngaychieu);
            d = DateTime.Today;
            /*d = DateTime.Parse("01/05/2023");*/

            TimeSpan ts = a - dt;
            int i = ts.Days;

            int b = i % 7;
            c = a.AddDays(-b);

            TimeSpan tss = c - d;
            int ii = tss.Days;

            return ii;
        }
        private void btxlcp_Click(object sender, EventArgs e)
        {
            int ii = check();
            if (ii > 7)
            {
                cgvquan3qllcxoa cgvq3qllcx = new cgvquan3qllcxoa();
                cgvq3qllcx.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phải xóa lịch chiếu trước ngày chiếu 1 tuần!", "Thông báo");
            }
        }

        //Xử lý sự kiện cho combox Thêm
        private void btthemlcp_Click(object sender, EventArgs e)
        {
            cgvquan3qllcthem cgvq3qllct = new cgvquan3qllcthem();
            cgvq3qllct.ShowDialog();
        }

        //xử lý sự kiện load màn hình cgvq3qllc
        private void cgvquan3qllc_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.Rap where MaCum = 'CGVQ3'", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            cbq3qllc.DataSource = dt;
            cbq3qllc.DisplayMember = "MaRap";
            cbq3qllc.ValueMember = "MaRap";

        }

        //Xử lý dự kiện Combobox
        public void hienthi()
        {
            string t = string.Format("select * from dbo.LichChieucms where MaRap = '{0}'", cbq3qllc.SelectedValue);
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand(t, conn);

            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            conn.Dispose();

            dgvq3qllc.DataSource = dt;
            dgvq3qllc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cbq3qllc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            hienthi();
        }

        //Xử lý sự kiện Cellclick của dgvq3qllc
        public class data
        {
            public static string maphim;
            public static string marap;
            public static string ngaychieu;
            public static string csuatchieu;
        }

        int q3qllc;
        private void dgvq3qllc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            q3qllc = e.RowIndex;
            if (q3qllc == -1) return;
            DataRow row = dt.Rows[q3qllc];
            data.maphim = row["MaPhim"].ToString();
            data.marap = row["MaRap"].ToString();
            data.ngaychieu = row["NgayChieu"].ToString();
            data.csuatchieu = row["ChuoiMaSuat"].ToString();            
        }
    }
}
