using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3phim : Form
    {
        //Tạo 2 biến cục bộ
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        private SqlCommand cmd;
        SqlDataAdapter adapter;
        public DataTable dt;

        public cgvquan3phim()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho textbox Thanh tìm kiếm
        private void tbtimkiemphim_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenPhim", "*" + tbtimkiemphim.Text + "*");
            (dgvphim.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
                                
        private void cgvquan3phim_Load(object sender, EventArgs e)
        {
            dgvphiml();
            dgvrapl();
        }

        private void dgvphiml()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select KeHoach.MaPhim, TenPhim, MaTheLoaiChinh, PhimTheLoaiPhu.MaTheLoai as MaTheLoaiPhu, Phim.ThoiLuong, CoLa3D, CoLongTieng from dbo.KeHoach inner join dbo.Phim on KeHoach.MaPhim = Phim.MaPhim inner join dbo.PhimTheLoaiPhu on KeHoach.MaPhim = PhimTheLoaiPhu.MaPhim where MaCum = 'CGVQ3'", conn);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();            

            dgvphim.DataSource = dt;
            dgvphim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgvrapl()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select MaRap, TongGhe from dbo.Rap where MaCum = 'CGVQ3'", conn);
            adapter = new SqlDataAdapter(cmd);          
            dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();

            dgvrap.DataSource = dt;          
            dgvrap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
