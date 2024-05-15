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
    public partial class cgvquan3doimk : Form
    {
        protected String strc = System.Configuration.ConfigurationManager.ConnectionStrings["my connection string"].ConnectionString;
        protected SqlConnection conn;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public cgvquan3doimk()
        {
            InitializeComponent();
        }
                
        //xử lý sự kiện cho button Xác nhận
        private void btdmkxn_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    conn = new SqlConnection(strc);

                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.CommandText = "sp_updatematkhau";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenTaiKhoan", SqlDbType.NVarChar, 50).Value = tbtentk.Text;
                    cmd.Parameters.Add("@MatKhauCu", SqlDbType.NVarChar, 50).Value = tbmkht.Text;
                    cmd.Parameters.Add("@MatKhauMoi", SqlDbType.NVarChar, 50).Value = tbmkm.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }            
        }

        //kiểm tra xem người dùng đã nhập đầy đủ thông tin hay chưa
        public bool KiemTra()
        {
            if (tbtentk.Text == "")
            {
                lblthongbao.ForeColor = System.Drawing.Color.Red;
                lblthongbao.Text = "Vui lòng nhập tên tài khoản !!";
                tbtentk.Focus();
                return false;
            }
            else if (tbmkht.Text == "")
            {
                lblthongbao.ForeColor = System.Drawing.Color.Red;
                lblthongbao.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                tbmkht.Focus();
                return false;
            }
            else if (tbmkm.Text == "")
            {
                lblthongbao.ForeColor = System.Drawing.Color.Red;
                lblthongbao.Text = "Vui lòng nhập mật khẩu mới !!";
                tbmkm.Focus();
                return false;
            }
            else if (tbxnmk.Text == "")
            {
                lblthongbao.ForeColor = System.Drawing.Color.Red;
                lblthongbao.Text = "Vui lòng xác nhận mật khẩu !!";
                tbxnmk.Focus();
                return false;
            }
            else if (tbmkm.Text != tbxnmk.Text)
            {
                lblthongbao.ForeColor = System.Drawing.Color.Red;
                lblthongbao.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                tbxnmk.Focus();
                tbxnmk.SelectAll();
                return false;
            }
            return true;
        }


        //xử lý sự kiện cho button Hiện mật khẩu hiện tại
        private void bthmkht_Click(object sender, EventArgs e)
        {
            if (tbmkht.PasswordChar == '\0')
            {
                btamkht.BringToFront();
                tbmkht.PasswordChar = '*' ;
            }
        }

        //xử lý sự kiện cho button Hiện mật khẩu mới
        private void bthmkm_Click(object sender, EventArgs e)
        {
            if (tbmkm.PasswordChar == '\0')
            {
                btamkm.BringToFront();
                tbmkm.PasswordChar = '*';
            }
        }

        //xử lý sự kiện cho button Hiện xác nhận mật khẩu
        private void bthxnmk_Click(object sender, EventArgs e)
        {
            if (tbxnmk.PasswordChar == '\0')
            {
                btaxnmk.BringToFront();
                tbxnmk.PasswordChar = '*';
            }
        }

        //xử lý sự kiện cho button Ẩn mật khẩu hiện tại
        private void btamkht_Click(object sender, EventArgs e)
        {
            if (tbmkht.PasswordChar == '*')
            {
                bthmkht.BringToFront();
                tbmkht.PasswordChar = '\0';
            }
        }

        //xử lý sự kiện cho button Ẩn mật khẩu mới
        private void btamkm_Click(object sender, EventArgs e)
        {
            if (tbmkm.PasswordChar == '*')
            {
                bthmkm.BringToFront();
                tbmkm.PasswordChar = '\0';
            }
        }

        //xử lý sự kiện cho button Ẩn xác nhận mật khẩu
        private void btaxnmk_Click(object sender, EventArgs e)
        {
            if (tbxnmk.PasswordChar == '*')
            {
                bthxnmk.BringToFront();
                tbxnmk.PasswordChar = '\0';
            }
        }

        //Xử lý sự kiện gán giá trị cho textbox Mật khẩu mới
        private void tbmkm_Validated(object sender, EventArgs e)
        {
            if (tbmkht.Text == tbmkm.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác với mật khẩu hiện tại!!");
            }
            
        }
    }
}
