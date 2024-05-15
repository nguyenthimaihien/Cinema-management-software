using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trang_chủ_của_NVQL.cgvquan3qllc;

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3qllcxoa : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;        
        DataSet ds = new DataSet();
        public cgvquan3qllcxoa()
        {
            InitializeComponent();
        }        

        //Xử lý sự kiện cho button Xác nhận xóa
        private void btxnx_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = MessageBox.Show("Dữ liệu bị xoá sẽ không được khôi phục.\r\nBạn có chắc chắn muốn xoá lịch chiếu phim này không?", "Xóa phim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    xoa();
                    this.Close();
                    cgvquan3qllc f = (cgvquan3qllc)Application.OpenForms["cgvquan3qllc"];
                    f.hienthi();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }            
        }

        private void xoa()
        {            
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_DeleteChuoi";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 10).Value = tbmaphimllcx.Text;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar, 5).Value = tbmaraplcx.Text;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = tbngaychieulcx.Text;
            cmd.Parameters.Add("@ChuoiMaSuat", SqlDbType.NVarChar).Value = tbsuatchieux.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Xử lý sự kiện load màn hình xóa
        private void cgvquan3qllcxoa_Load(object sender, EventArgs e)
        {
            DateTime n = DateTime.Parse(data.ngaychieu);
            tbmaphimllcx.Text = data.maphim;
            tbmaraplcx.Text = data.marap;
            tbngaychieulcx.Text = n.ToString("dd/MM/yyyy");
            tbsuatchieux.Text = data.csuatchieu;
        }
    }
}
