namespace Trang_chủ_của_NVQL
{
    partial class cgvquan3qlkh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cgvquan3qlkh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttimkiem = new System.Windows.Forms.PictureBox();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvq3qlkh = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btdk = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttimkiem)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvq3qlkh)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 490);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttimkiem);
            this.panel2.Controls.Add(this.tbtimkiem);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 48);
            this.panel2.TabIndex = 1;
            // 
            // buttimkiem
            // 
            this.buttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttimkiem.BackgroundImage")));
            this.buttimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttimkiem.Location = new System.Drawing.Point(843, 9);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(30, 30);
            this.buttimkiem.TabIndex = 3;
            this.buttimkiem.TabStop = false;
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbtimkiem.Location = new System.Drawing.Point(612, 9);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(261, 30);
            this.tbtimkiem.TabIndex = 1;
            this.tbtimkiem.Tag = "";
            this.tbtimkiem.TextChanged += new System.EventHandler(this.tbtimkiem_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvq3qlkh);
            this.panel4.Location = new System.Drawing.Point(3, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 371);
            this.panel4.TabIndex = 3;
            // 
            // dgvq3qlkh
            // 
            this.dgvq3qlkh.AllowUserToAddRows = false;
            this.dgvq3qlkh.AllowUserToDeleteRows = false;
            this.dgvq3qlkh.AllowUserToOrderColumns = true;
            this.dgvq3qlkh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvq3qlkh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvq3qlkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvq3qlkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvq3qlkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.MaCum,
            this.NgayKhoiChieu,
            this.NgayKetThuc,
            this.GhiChu});
            this.dgvq3qlkh.Location = new System.Drawing.Point(9, 4);
            this.dgvq3qlkh.Name = "dgvq3qlkh";
            this.dgvq3qlkh.ReadOnly = true;
            this.dgvq3qlkh.RowHeadersWidth = 51;
            this.dgvq3qlkh.RowTemplate.Height = 24;
            this.dgvq3qlkh.Size = new System.Drawing.Size(864, 363);
            this.dgvq3qlkh.TabIndex = 0;
            this.dgvq3qlkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvq3qlkh_CellClick);
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã Phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // MaCum
            // 
            this.MaCum.DataPropertyName = "MaCum";
            this.MaCum.HeaderText = "Mã Cụm";
            this.MaCum.MinimumWidth = 6;
            this.MaCum.Name = "MaCum";
            this.MaCum.ReadOnly = true;
            this.MaCum.Width = 125;
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKhoiChieu.DataPropertyName = "NgayKhoiChieu";
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.MinimumWidth = 6;
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            this.NgayKhoiChieu.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.AllowDrop = true;
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.btdk);
            this.panel6.Controls.Add(this.btxoa);
            this.panel6.Location = new System.Drawing.Point(620, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 59);
            this.panel6.TabIndex = 2;
            // 
            // btdk
            // 
            this.btdk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btdk.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btdk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btdk.Location = new System.Drawing.Point(140, 9);
            this.btdk.Name = "btdk";
            this.btdk.Size = new System.Drawing.Size(116, 38);
            this.btdk.TabIndex = 4;
            this.btdk.Text = "Đăng ký";
            this.btdk.UseVisualStyleBackColor = false;
            this.btdk.Click += new System.EventHandler(this.btdk_Click);
            // 
            // btxoa
            // 
            this.btxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(28, 9);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(77, 38);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 59);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phim chiếu tại rạp CGV Quận 3";
            // 
            // cgvquan3qlkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(888, 490);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cgvquan3qlkh";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV Quận 3 - Quản lý kế hoạch";
            this.Load += new System.EventHandler(this.cgvquan3qlkh_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttimkiem)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvq3qlkh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvq3qlkh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btdk;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.PictureBox buttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCum;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}