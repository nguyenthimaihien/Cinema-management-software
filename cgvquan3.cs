using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_chủ_của_NVQL
{
    public partial class cgvquan3 : Form
    {
        public cgvquan3()
        {
            InitializeComponent();
        }

        //Xử lý sự kiện cho button Phim Rạp
        cgvquan3phim cgvq3phim;
        private void menurapphimnv_Click(object sender, EventArgs e)
        {
           cgvq3phim = new cgvquan3phim();
           cgvq3phim.TopLevel = false;
           cgvq3phim.Dock = DockStyle.Fill;
           panel2.Controls.Add(cgvq3phim);
           cgvq3phim.Show();
        }

        //Xử lý sự kiện cho button Quản lý kế hoạch
        cgvquan3qlkh cgvq3qlkh;
        private void menuqlkhnv_Click(object sender, EventArgs e)
        {
            if (cgvq3qlkh == null || cgvq3qlkh.IsDisposed)
            {
                cgvq3qlkh = new cgvquan3qlkh();
                cgvq3qlkh.Show();
            }
            cgvq3qlkh.Activate();
        }

        //Xử lý sự kiện cho button Quản lý lịch chiếu
        cgvquan3qllc cgvq3qllc;
        private void menqllcnv_Click(object sender, EventArgs e)
        {
            if (cgvq3qllc == null || cgvq3qllc.IsDisposed)
            {
                cgvq3qllc = new cgvquan3qllc();
                cgvq3qllc.Show();
            }
            cgvq3qllc.Activate();
        }

        //Xử lý sự kiện cho button CGV Quận 3/ Đổi mật khẩu
        cgvquan3doimk cgvq3dmk;
        private void menucgvq3dmk_Click(object sender, EventArgs e)
        {
                cgvq3dmk = new cgvquan3doimk();
                cgvq3dmk.ShowDialog();
        }

        //Xử lý sự kiện cho button CGV Quận 3/ Đăng xuất
        private void menucgvq3dx_Click(object sender, EventArgs e)
        {

            /*this.Hide();
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();*/
        }

        private void cgvquan3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
