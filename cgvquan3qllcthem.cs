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
    public partial class cgvquan3qllcthem : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        DataTable dt;
        public cgvquan3qllcthem()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho button Xác nhận
        private void nxlct_Click(object sender, EventArgs e)
        {
           try
           {        
                DialogResult dg = MessageBox.Show("Đồng ý thêm lịch chiếu ?", "Xác nhận thêm lịch chiếu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                   update();
                   this.Close();
                   cgvquan3qllc f = (cgvquan3qllc)Application.OpenForms["cgvquan3qllc"]; 
                   f.hienthi();
                }

           } 
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message,"Thông báo");
           }
        }

        private void update ()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "sp_checksuatchieu";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaPhim", SqlDbType.VarChar, 10).Value = cbtenphimlct.Text;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar, 5).Value = cbraplct.Text;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = dtpngaychieu.Value.ToString("dd/MM/yyyy");
            cmd.Parameters.Add("@MaSuat", SqlDbType.VarChar, 3).Value = cbsuatchieulct.Text;                     
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Xử lý sựu kiện cho dtp  Ngày chiếu
        private void dtpngaychieu_ValueChanged(object sender, EventArgs e)
        {
            int ii = check();
            if ( ii > 7)
            {
                cbsuatchieu();
            }
            else
            {
                MessageBox.Show("Phải lên lịch chiếu phim trước 1 tuần!!", "Thông báo");
            }
        }

        private int check()
        {
            DateTime dt, a, c, d;
            dt = DateTime.Parse("01/01/1900");
            a = dtpngaychieu.Value;
            d = DateTime.Today;

            TimeSpan ts = a - dt;
            int i = ts.Days;

            int b = i % 7;
            c = a.AddDays(-b);

            TimeSpan tss = c - d;
            int ii = tss.Days;
             
            return ii;
        }

        //Xử lý sự kiện cho combox Rạp chiếu
        private void cbraplct_SelectedValueChanged(object sender, EventArgs e)
        {
            cbsuatchieu();
        }

        //Xử lý sự kiện lòa của màn hình qllc thêm
        private void cgvquan3qllcthem_Load(object sender, EventArgs e)
        {
            cbtenphim();   
            cbrapchieu();            
        }

        public void cbtenphim()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.KeHoach where MaCum = 'CGVQ3'", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            cbtenphimlct.DataSource = dt;
            cbtenphimlct.DisplayMember = "MaPhim";
            cbtenphimlct.ValueMember = "MaPhim";            
        }
        
        private void cbrapchieu()
        {
            conn = new SqlConnection(strc);

            conn.Open();
            cmd = new SqlCommand("select * from dbo.Rap where MaCum = 'CGVQ3'", conn);
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            adapter.Fill(dt);
            conn.Close();

            cbraplct.DataSource = dt;
            cbraplct.DisplayMember = "MaRap";
            cbraplct.ValueMember = "MaRap";
        }        

        private void cbsuatchieu()
        {
            conn = new SqlConnection(strc);
            string t = dtpngaychieu.Value.ToString("dd/MM/yyyy");
            string i = cbraplct.SelectedValue.ToString();

            conn.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "[dbo].[sp_LayMaSuat]";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaRap", SqlDbType.VarChar).Value = i;
            cmd.Parameters.Add("@NgayChieu", SqlDbType.Date).Value = t;

            
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dt);
            conn.Close();

            cbsuatchieulct.DataSource = dt;
            cbsuatchieulct.DisplayMember = "MaSuat";
            cbsuatchieulct.ValueMember = "MaSuat";
        }
    }
}
