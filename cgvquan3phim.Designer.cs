namespace Trang_chủ_của_NVQL
{
    partial class cgvquan3phim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cgvquan3phim));
            this.label1 = new System.Windows.Forms.Label();
            this.tbtimkiemphim = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvrap = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttimkiem = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvphim = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoaiChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoaiPhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttimkiem)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phim chiếu tại CGV Quận 3";
            // 
            // tbtimkiemphim
            // 
            this.tbtimkiemphim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtimkiemphim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbtimkiemphim.Location = new System.Drawing.Point(804, 9);
            this.tbtimkiemphim.Multiline = true;
            this.tbtimkiemphim.Name = "tbtimkiemphim";
            this.tbtimkiemphim.Size = new System.Drawing.Size(234, 30);
            this.tbtimkiemphim.TabIndex = 1;
            this.tbtimkiemphim.TextChanged += new System.EventHandler(this.tbtimkiemphim_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 538);
            this.panel1.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(3, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(518, 47);
            this.panel7.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(116, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rạp CGV Quận 3";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.dgvrap);
            this.panel5.Location = new System.Drawing.Point(3, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 434);
            this.panel5.TabIndex = 13;
            // 
            // dgvrap
            // 
            this.dgvrap.AllowUserToAddRows = false;
            this.dgvrap.AllowUserToDeleteRows = false;
            this.dgvrap.AllowUserToOrderColumns = true;
            this.dgvrap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvrap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaRap,
            this.TongGhe});
            this.dgvrap.Location = new System.Drawing.Point(3, 3);
            this.dgvrap.Name = "dgvrap";
            this.dgvrap.ReadOnly = true;
            this.dgvrap.RowHeadersWidth = 51;
            this.dgvrap.RowTemplate.Height = 24;
            this.dgvrap.Size = new System.Drawing.Size(512, 428);
            this.dgvrap.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(524, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(544, 47);
            this.panel3.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.bttimkiem);
            this.panel2.Controls.Add(this.tbtimkiemphim);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 47);
            this.panel2.TabIndex = 10;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttimkiem.BackgroundImage")));
            this.bttimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttimkiem.Location = new System.Drawing.Point(1010, 10);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(28, 28);
            this.bttimkiem.TabIndex = 2;
            this.bttimkiem.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1065, 47);
            this.panel6.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvphim);
            this.panel4.Location = new System.Drawing.Point(524, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(544, 434);
            this.panel4.TabIndex = 12;
            // 
            // dgvphim
            // 
            this.dgvphim.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvphim.AllowUserToAddRows = false;
            this.dgvphim.AllowUserToDeleteRows = false;
            this.dgvphim.AllowUserToOrderColumns = true;
            this.dgvphim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvphim.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvphim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvphim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.TenPhim,
            this.MaTheLoaiChinh,
            this.MaTheLoaiPhu,
            this.ThoiLuong});
            this.dgvphim.Location = new System.Drawing.Point(3, 3);
            this.dgvphim.Name = "dgvphim";
            this.dgvphim.ReadOnly = true;
            this.dgvphim.RowHeadersWidth = 51;
            this.dgvphim.RowTemplate.Height = 24;
            this.dgvphim.Size = new System.Drawing.Size(538, 428);
            this.dgvphim.TabIndex = 0;
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            this.TenPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhim.DataPropertyName = "TenPhim";
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.ReadOnly = true;
            // 
            // MaTheLoaiChinh
            // 
            this.MaTheLoaiChinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTheLoaiChinh.DataPropertyName = "MaTheLoaiChinh";
            this.MaTheLoaiChinh.HeaderText = "Thể loại chính";
            this.MaTheLoaiChinh.MinimumWidth = 6;
            this.MaTheLoaiChinh.Name = "MaTheLoaiChinh";
            this.MaTheLoaiChinh.ReadOnly = true;
            // 
            // MaTheLoaiPhu
            // 
            this.MaTheLoaiPhu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaTheLoaiPhu.DataPropertyName = "MaTheLoaiPhu";
            this.MaTheLoaiPhu.HeaderText = "Thể loại phụ";
            this.MaTheLoaiPhu.MinimumWidth = 6;
            this.MaTheLoaiPhu.Name = "MaTheLoaiPhu";
            this.MaTheLoaiPhu.ReadOnly = true;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiLuong.DataPropertyName = "ThoiLuong";
            this.ThoiLuong.HeaderText = "Thời lượng";
            this.ThoiLuong.MinimumWidth = 6;
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.ReadOnly = true;
            // 
            // MaRap
            // 
            this.MaRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã rạp";
            this.MaRap.MinimumWidth = 6;
            this.MaRap.Name = "MaRap";
            this.MaRap.ReadOnly = true;
            // 
            // TongGhe
            // 
            this.TongGhe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongGhe.DataPropertyName = "TongGhe";
            this.TongGhe.HeaderText = "Tổng ghế";
            this.TongGhe.MinimumWidth = 6;
            this.TongGhe.Name = "TongGhe";
            this.TongGhe.ReadOnly = true;
            // 
            // cgvquan3phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 538);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cgvquan3phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CGV Quận 3 - Phim";
            this.Load += new System.EventHandler(this.cgvquan3phim_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttimkiem)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtimkiemphim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvphim;
        private System.Windows.Forms.PictureBox bttimkiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvrap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoaiChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoaiPhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGhe;
    }
}