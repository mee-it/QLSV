namespace QLSV
{
    partial class frm_Quanlylophoc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.btn_dsachsinhvien = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_khoa = new System.Windows.Forms.Label();
            this.lbl_siso = new System.Windows.Forms.Label();
            this.lbl_tenlop = new System.Windows.Forms.Label();
            this.txt_siso = new System.Windows.Forms.TextBox();
            this.txt_tenlop = new System.Windows.Forms.TextBox();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.lbl_malop = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_qlsv = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1684, 1042);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.cb_khoa);
            this.groupBox1.Controls.Add(this.btn_dsachsinhvien);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.lbl_khoa);
            this.groupBox1.Controls.Add(this.lbl_siso);
            this.groupBox1.Controls.Add(this.lbl_tenlop);
            this.groupBox1.Controls.Add(this.txt_siso);
            this.groupBox1.Controls.Add(this.txt_tenlop);
            this.groupBox1.Controls.Add(this.txt_malop);
            this.groupBox1.Controls.Add(this.lbl_malop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 1034);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cb_khoa
            // 
            this.cb_khoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_khoa.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(33, 476);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(479, 39);
            this.cb_khoa.TabIndex = 6;
            // 
            // btn_dsachsinhvien
            // 
            this.btn_dsachsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dsachsinhvien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dsachsinhvien.Location = new System.Drawing.Point(32, 868);
            this.btn_dsachsinhvien.Name = "btn_dsachsinhvien";
            this.btn_dsachsinhvien.Size = new System.Drawing.Size(491, 78);
            this.btn_dsachsinhvien.TabIndex = 5;
            this.btn_dsachsinhvien.Text = "Xem danh sách sinh viên";
            this.btn_dsachsinhvien.UseVisualStyleBackColor = false;
            this.btn_dsachsinhvien.Click += new System.EventHandler(this.btn_dsachsinhvien_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_lammoi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_sua, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_xoa, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 691);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 154);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(241, 71);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_lammoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lammoi.Location = new System.Drawing.Point(250, 80);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(241, 71);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = false;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Location = new System.Drawing.Point(3, 80);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(241, 71);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Red;
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_xoa.Location = new System.Drawing.Point(250, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(241, 71);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lbl_khoa
            // 
            this.lbl_khoa.AutoSize = true;
            this.lbl_khoa.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_khoa.Location = new System.Drawing.Point(18, 425);
            this.lbl_khoa.Name = "lbl_khoa";
            this.lbl_khoa.Size = new System.Drawing.Size(116, 31);
            this.lbl_khoa.TabIndex = 2;
            this.lbl_khoa.Text = "Tên khoa";
            // 
            // lbl_siso
            // 
            this.lbl_siso.AutoSize = true;
            this.lbl_siso.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_siso.Location = new System.Drawing.Point(18, 309);
            this.lbl_siso.Name = "lbl_siso";
            this.lbl_siso.Size = new System.Drawing.Size(67, 31);
            this.lbl_siso.TabIndex = 2;
            this.lbl_siso.Text = "Sĩ số";
            this.lbl_siso.Click += new System.EventHandler(this.lbl_siso_Click);
            // 
            // lbl_tenlop
            // 
            this.lbl_tenlop.AutoSize = true;
            this.lbl_tenlop.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenlop.Location = new System.Drawing.Point(18, 198);
            this.lbl_tenlop.Name = "lbl_tenlop";
            this.lbl_tenlop.Size = new System.Drawing.Size(99, 31);
            this.lbl_tenlop.TabIndex = 2;
            this.lbl_tenlop.Text = "Tên lớp";
            this.lbl_tenlop.Click += new System.EventHandler(this.lbl_tenlop_Click);
            // 
            // txt_siso
            // 
            this.txt_siso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_siso.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_siso.Location = new System.Drawing.Point(29, 344);
            this.txt_siso.Name = "txt_siso";
            this.txt_siso.Size = new System.Drawing.Size(483, 35);
            this.txt_siso.TabIndex = 1;
            // 
            // txt_tenlop
            // 
            this.txt_tenlop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenlop.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenlop.Location = new System.Drawing.Point(29, 233);
            this.txt_tenlop.Name = "txt_tenlop";
            this.txt_tenlop.Size = new System.Drawing.Size(483, 35);
            this.txt_tenlop.TabIndex = 1;
            // 
            // txt_malop
            // 
            this.txt_malop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_malop.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_malop.Location = new System.Drawing.Point(29, 120);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(483, 35);
            this.txt_malop.TabIndex = 1;
            // 
            // lbl_malop
            // 
            this.lbl_malop.AutoSize = true;
            this.lbl_malop.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_malop.Location = new System.Drawing.Point(18, 70);
            this.lbl_malop.Name = "lbl_malop";
            this.lbl_malop.Size = new System.Drawing.Size(93, 31);
            this.lbl_malop.TabIndex = 0;
            this.lbl_malop.Text = "Mã lớp";
            this.lbl_malop.Click += new System.EventHandler(this.lbl_malop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_qlsv);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 1042);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm kiếm ( dựa vào mã lớp, tên lớp,...)";
            // 
            // btn_qlsv
            // 
            this.btn_qlsv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_qlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlsv.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qlsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlsv.Location = new System.Drawing.Point(10, 34);
            this.btn_qlsv.Name = "btn_qlsv";
            this.btn_qlsv.Size = new System.Drawing.Size(192, 57);
            this.btn_qlsv.TabIndex = 3;
            this.btn_qlsv.Text = "Quản lý sinh viên";
            this.btn_qlsv.UseVisualStyleBackColor = false;
            this.btn_qlsv.Click += new System.EventHandler(this.btn_qlsv_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_timkiem.Location = new System.Drawing.Point(924, 34);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(148, 57);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(230, 46);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(674, 35);
            this.txt_timkiem.TabIndex = 2;
            this.txt_timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_timkiem_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 845);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frm_Quanlylophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1684, 1042);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_Quanlylophoc";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.frm_Quanlylophoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_malop;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_khoa;
        private System.Windows.Forms.Label lbl_siso;
        private System.Windows.Forms.Label lbl_tenlop;
        private System.Windows.Forms.TextBox txt_siso;
        private System.Windows.Forms.TextBox txt_tenlop;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_qlsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dsachsinhvien;
        private System.Windows.Forms.ComboBox cb_khoa;
    }
}