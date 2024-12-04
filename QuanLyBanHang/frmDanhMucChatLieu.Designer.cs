namespace QuanLyBanHang
{
    partial class frmDanhMucChatLieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_danhmuchanghoa = new System.Windows.Forms.Label();
            this.lb_machatlieu = new System.Windows.Forms.Label();
            this.txt_machatlieu = new System.Windows.Forms.TextBox();
            this.lb_mahang = new System.Windows.Forms.Label();
            this.txt_tenchatlieu = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_mahang);
            this.panel1.Controls.Add(this.txt_tenchatlieu);
            this.panel1.Controls.Add(this.lb_machatlieu);
            this.panel1.Controls.Add(this.txt_machatlieu);
            this.panel1.Controls.Add(this.lb_danhmuchanghoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 166);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Controls.Add(this.btn_xoa);
            this.flowLayoutPanel1.Controls.Add(this.btn_sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_luu);
            this.flowLayoutPanel1.Controls.Add(this.btn_boqua);
            this.flowLayoutPanel1.Controls.Add(this.btn_dong);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 460);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(714, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // lb_danhmuchanghoa
            // 
            this.lb_danhmuchanghoa.AutoSize = true;
            this.lb_danhmuchanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhmuchanghoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_danhmuchanghoa.Location = new System.Drawing.Point(226, 20);
            this.lb_danhmuchanghoa.Name = "lb_danhmuchanghoa";
            this.lb_danhmuchanghoa.Size = new System.Drawing.Size(246, 25);
            this.lb_danhmuchanghoa.TabIndex = 3;
            this.lb_danhmuchanghoa.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // lb_machatlieu
            // 
            this.lb_machatlieu.AutoSize = true;
            this.lb_machatlieu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_machatlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_machatlieu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_machatlieu.Location = new System.Drawing.Point(27, 64);
            this.lb_machatlieu.Name = "lb_machatlieu";
            this.lb_machatlieu.Size = new System.Drawing.Size(105, 20);
            this.lb_machatlieu.TabIndex = 7;
            this.lb_machatlieu.Text = "Mã chất liệu:";
            // 
            // txt_machatlieu
            // 
            this.txt_machatlieu.Location = new System.Drawing.Point(168, 64);
            this.txt_machatlieu.Name = "txt_machatlieu";
            this.txt_machatlieu.Size = new System.Drawing.Size(304, 22);
            this.txt_machatlieu.TabIndex = 6;
            // 
            // lb_mahang
            // 
            this.lb_mahang.AutoSize = true;
            this.lb_mahang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_mahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mahang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_mahang.Location = new System.Drawing.Point(27, 115);
            this.lb_mahang.Name = "lb_mahang";
            this.lb_mahang.Size = new System.Drawing.Size(110, 20);
            this.lb_mahang.TabIndex = 9;
            this.lb_mahang.Text = "Tên chất liệu:";
            // 
            // txt_tenchatlieu
            // 
            this.txt_tenchatlieu.Location = new System.Drawing.Point(168, 115);
            this.txt_tenchatlieu.Name = "txt_tenchatlieu";
            this.txt_tenchatlieu.Size = new System.Drawing.Size(304, 22);
            this.txt_tenchatlieu.TabIndex = 8;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_them.Location = new System.Drawing.Point(20, 3);
            this.btn_them.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(108, 36);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_xoa.Location = new System.Drawing.Point(134, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(108, 36);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_sua.Location = new System.Drawing.Point(248, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(108, 36);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Green;
            this.btn_luu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_luu.Location = new System.Drawing.Point(362, 3);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(108, 36);
            this.btn_luu.TabIndex = 5;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            // 
            // btn_boqua
            // 
            this.btn_boqua.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_boqua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_boqua.Location = new System.Drawing.Point(476, 3);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(108, 36);
            this.btn_boqua.TabIndex = 6;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = false;
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_dong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_dong.Location = new System.Drawing.Point(590, 3);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(108, 36);
            this.btn_dong.TabIndex = 8;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            // 
            // frmDanhMucChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDanhMucChatLieu";
            this.Text = "frmDanhMucChatLieu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_danhmuchanghoa;
        private System.Windows.Forms.Label lb_mahang;
        private System.Windows.Forms.TextBox txt_tenchatlieu;
        private System.Windows.Forms.Label lb_machatlieu;
        private System.Windows.Forms.TextBox txt_machatlieu;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_dong;
    }
}