namespace Trang_chủ_của_NVQL
{
    partial class cgvquan3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cgvquan3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menurapphimnv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuqlkhnv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuqllcnv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menutaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.menucgvq3dmk = new System.Windows.Forms.ToolStripMenuItem();
            this.menucgvq3dx = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menurapphimnv,
            this.menuqlkhnv,
            this.menuqllcnv});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(486, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menurapphimnv
            // 
            this.menurapphimnv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menurapphimnv.Name = "menurapphimnv";
            this.menurapphimnv.Size = new System.Drawing.Size(117, 32);
            this.menurapphimnv.Text = "Rạp/ Phim";
            this.menurapphimnv.Click += new System.EventHandler(this.menurapphimnv_Click);
            // 
            // menuqlkhnv
            // 
            this.menuqlkhnv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuqlkhnv.Name = "menuqlkhnv";
            this.menuqlkhnv.Size = new System.Drawing.Size(176, 32);
            this.menuqlkhnv.Text = "Quản lý kế hoạch";
            this.menuqlkhnv.Click += new System.EventHandler(this.menuqlkhnv_Click);
            // 
            // menuqllcnv
            // 
            this.menuqllcnv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuqllcnv.Name = "menuqllcnv";
            this.menuqllcnv.Size = new System.Drawing.Size(179, 32);
            this.menuqllcnv.Text = "Quản lý lịch chiếu";
            this.menuqllcnv.Click += new System.EventHandler(this.menqllcnv_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutaikhoan});
            this.menuStrip2.Location = new System.Drawing.Point(30, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(120, 38);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menutaikhoan
            // 
            this.menutaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menucgvq3dmk,
            this.menucgvq3dx});
            this.menutaikhoan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menutaikhoan.Name = "menutaikhoan";
            this.menutaikhoan.Size = new System.Drawing.Size(95, 32);
            this.menutaikhoan.Text = "Tài khoản";
            // 
            // menucgvq3dmk
            // 
            this.menucgvq3dmk.Name = "menucgvq3dmk";
            this.menucgvq3dmk.Size = new System.Drawing.Size(224, 32);
            this.menucgvq3dmk.Text = "Đổi mật khẩu";
            this.menucgvq3dmk.Click += new System.EventHandler(this.menucgvq3dmk_Click);
            // 
            // menucgvq3dx
            // 
            this.menucgvq3dx.Name = "menucgvq3dx";
            this.menucgvq3dx.Size = new System.Drawing.Size(224, 32);
            this.menucgvq3dx.Text = "Đăng xuất";
            this.menucgvq3dx.Click += new System.EventHandler(this.menucgvq3dx_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(983, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 38);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 566);
            this.panel2.TabIndex = 8;
            // 
            // cgvquan3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1134, 603);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "cgvquan3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV Quận 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cgvquan3_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menutaikhoan;
        private System.Windows.Forms.ToolStripMenuItem menuqlkhnv;
        private System.Windows.Forms.ToolStripMenuItem menuqllcnv;
        private System.Windows.Forms.ToolStripMenuItem menucgvq3dmk;
        private System.Windows.Forms.ToolStripMenuItem menucgvq3dx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem menurapphimnv;
    }
}

