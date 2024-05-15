namespace Trang_chủ_của_NVQL
{
    partial class cgvquan3qllc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cgvquan3qllc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bttimkiem = new System.Windows.Forms.PictureBox();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvq3qllc = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuoiMaSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btthemlcp = new System.Windows.Forms.Button();
            this.btxlcp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbq3qllc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttimkiem)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvq3qllc)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.bttimkiem);
            this.panel6.Controls.Add(this.tbtimkiem);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(871, 48);
            this.panel6.TabIndex = 5;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bttimkiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttimkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttimkiem.BackgroundImage")));
            this.bttimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttimkiem.Location = new System.Drawing.Point(826, 9);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(30, 30);
            this.bttimkiem.TabIndex = 3;
            this.bttimkiem.TabStop = false;
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbtimkiem.Location = new System.Drawing.Point(645, 9);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(211, 30);
            this.tbtimkiem.TabIndex = 1;
            this.tbtimkiem.Tag = "";
            this.tbtimkiem.TextChanged += new System.EventHandler(this.tbtimkiem_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.dgvq3qllc);
            this.panel5.Location = new System.Drawing.Point(3, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(871, 450);
            this.panel5.TabIndex = 16;
            // 
            // dgvq3qllc
            // 
            this.dgvq3qllc.AllowUserToAddRows = false;
            this.dgvq3qllc.AllowUserToDeleteRows = false;
            this.dgvq3qllc.AllowUserToOrderColumns = true;
            this.dgvq3qllc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvq3qllc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvq3qllc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvq3qllc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvq3qllc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.MaRap,
            this.NgayChieu,
            this.ChuoiMaSuat});
            this.dgvq3qllc.GridColor = System.Drawing.SystemColors.Control;
            this.dgvq3qllc.Location = new System.Drawing.Point(12, 8);
            this.dgvq3qllc.Name = "dgvq3qllc";
            this.dgvq3qllc.ReadOnly = true;
            this.dgvq3qllc.RowHeadersWidth = 51;
            this.dgvq3qllc.RowTemplate.Height = 24;
            this.dgvq3qllc.Size = new System.Drawing.Size(844, 435);
            this.dgvq3qllc.TabIndex = 0;
            this.dgvq3qllc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvq3qllc_CellClick);
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaPhim.DataPropertyName = "MaPhim";
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.MinimumWidth = 6;
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.ReadOnly = true;
            this.MaPhim.Width = 87;
            // 
            // MaRap
            // 
            this.MaRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaRap.DataPropertyName = "MaRap";
            this.MaRap.HeaderText = "Mã rạp";
            this.MaRap.MinimumWidth = 6;
            this.MaRap.Name = "MaRap";
            this.MaRap.ReadOnly = true;
            this.MaRap.Width = 78;
            // 
            // NgayChieu
            // 
            this.NgayChieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayChieu.DataPropertyName = "NgayChieu";
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.ReadOnly = true;
            // 
            // ChuoiMaSuat
            // 
            this.ChuoiMaSuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChuoiMaSuat.DataPropertyName = "ChuoiMaSuat";
            this.ChuoiMaSuat.HeaderText = "Chuỗi mã suất";
            this.ChuoiMaSuat.MinimumWidth = 6;
            this.ChuoiMaSuat.Name = "ChuoiMaSuat";
            this.ChuoiMaSuat.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btthemlcp);
            this.panel4.Controls.Add(this.btxlcp);
            this.panel4.Location = new System.Drawing.Point(607, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 51);
            this.panel4.TabIndex = 15;
            // 
            // btthemlcp
            // 
            this.btthemlcp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btthemlcp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btthemlcp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemlcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthemlcp.Location = new System.Drawing.Point(169, 6);
            this.btthemlcp.Name = "btthemlcp";
            this.btthemlcp.Size = new System.Drawing.Size(83, 33);
            this.btthemlcp.TabIndex = 4;
            this.btthemlcp.Text = "Thêm";
            this.btthemlcp.UseVisualStyleBackColor = false;
            this.btthemlcp.Click += new System.EventHandler(this.btthemlcp_Click);
            // 
            // btxlcp
            // 
            this.btxlcp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btxlcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btxlcp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btxlcp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btxlcp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxlcp.Location = new System.Drawing.Point(41, 6);
            this.btxlcp.Name = "btxlcp";
            this.btxlcp.Size = new System.Drawing.Size(83, 33);
            this.btxlcp.TabIndex = 3;
            this.btxlcp.Text = "Xóa";
            this.btxlcp.UseVisualStyleBackColor = false;
            this.btxlcp.Click += new System.EventHandler(this.btxlcp_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbq3qllc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 51);
            this.panel3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(409, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rạp:";
            // 
            // cbq3qllc
            // 
            this.cbq3qllc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbq3qllc.FormattingEnabled = true;
            this.cbq3qllc.Location = new System.Drawing.Point(468, 7);
            this.cbq3qllc.Name = "cbq3qllc";
            this.cbq3qllc.Size = new System.Drawing.Size(120, 33);
            this.cbq3qllc.TabIndex = 5;
            this.cbq3qllc.SelectionChangeCommitted += new System.EventHandler(this.cbq3qllc_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "LỊCH CHIẾU PHIM";
            // 
            // cgvquan3qllc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cgvquan3qllc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CGV Quận 3 - Quản lý lịch chiếu";
            this.Load += new System.EventHandler(this.cgvquan3qllc_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttimkiem)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvq3qllc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btthemlcp;
        private System.Windows.Forms.Button btxlcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.PictureBox bttimkiem;
        private System.Windows.Forms.ComboBox cbq3qllc;
        private System.Windows.Forms.DataGridView dgvq3qllc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuoiMaSuat;
    }
}