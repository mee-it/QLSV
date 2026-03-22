using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frm_Quanlylophoc : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        public frm_Quanlylophoc()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_malop_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tenlop_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_siso_Click(object sender, EventArgs e)
        {

        }

        private void frm_Quanlylophoc_Load(object sender, EventArgs e)
        {
            LoadLopHoc();
            LoadComboBoxKhoa();
            ClearForm();
        }

        private void LoadLopHoc()
        {
            var lopHocs = (from lh in db.tbl_LopHocs
                           join k in db.tbl_Khoas on lh.MaKhoa equals k.MaKhoa into tmp
                           from k in tmp.DefaultIfEmpty()

                           let siSoThuc = db.tbl_SinhViens.Count(sv => sv.MaLop == lh.MaLop && (sv.IsDeleted == false || sv.IsDeleted == null))

                           select new
                           {
                               lh.MaLop,
                               lh.TenLop,
                               Khoa = k != null ? k.TenKhoa : "",
                               SiSo = siSoThuc, 
                               lh.MaKhoa
                           }).ToList();

            dataGridView1.DataSource = lopHocs;

            if (dataGridView1.Columns["MaKhoa"] != null)
                dataGridView1.Columns["MaKhoa"].Visible = false;

            FormatGrid();
        }
        private void LoadComboBoxKhoa()
        {
            var ds = (from k in db.tbl_Khoas
                      select new
                      {
                          k.MaKhoa,
                          k.TenKhoa
                      }).ToList();

            cb_khoa.DataSource = ds;
            cb_khoa.DisplayMember = "TenKhoa"; 
            cb_khoa.ValueMember = "MaKhoa";    
            
        }
        private void ClearForm()
        {
            txt_malop.Text = "";
            txt_tenlop.Text = "";
            txt_siso.Text = "";
            cb_khoa.SelectedIndex = -1;
        }
        private void FormatGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["MaLop"].HeaderText = "Mã lớp";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên lớp";
            dataGridView1.Columns["Khoa"].HeaderText = "Khoa";
            dataGridView1.Columns["SiSo"].HeaderText = "Sĩ số";

            dataGridView1.Columns["MaLop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["SiSo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            txt_malop.Text = row.Cells["MaLop"].Value?.ToString() ?? "";
            txt_tenlop.Text = row.Cells["TenLop"].Value?.ToString() ?? "";
            txt_siso.Text = row.Cells["SiSo"].Value?.ToString() ?? "";

            if (dataGridView1.Columns.Contains("MaKhoa") && row.Cells["MaKhoa"].Value != null)
            {
                cb_khoa.SelectedValue = row.Cells["MaKhoa"].Value.ToString();
            }
            else
            {
                cb_khoa.SelectedIndex = -1;
            }

            txt_malop.Enabled = false;
            txt_siso.Enabled = false;
        }

        private void btn_qlsv_Click(object sender, EventArgs e)
        {
            frm_Quanlysinhvien qlsv = new frm_Quanlysinhvien();
            qlsv.Show();
            this.Hide();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txt_malop.Text) ||
                string.IsNullOrWhiteSpace(txt_tenlop.Text) ||
                cb_khoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string maLop = txt_malop.Text.Trim();

            var lopTonTai = db.tbl_LopHocs.FirstOrDefault(l => l.MaLop == maLop);
            if (lopTonTai != null)
            {
                MessageBox.Show("Mã lớp đã tồn tại!");
                return;
            }

            try
            {
                var lop = new tbl_LopHoc
                {
                    MaLop = maLop,
                    TenLop = txt_tenlop.Text.Trim(),
                    MaKhoa = cb_khoa.SelectedValue.ToString(),

                    KhoaHoc = null,
                    GhiChu = null
                };

                db.tbl_LopHocs.InsertOnSubmit(lop);
                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học thành công!");

                LoadLopHoc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_malop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                return;
            }

            string maLop = txt_malop.Text.Trim();

            var lop = db.tbl_LopHocs.FirstOrDefault(l => l.MaLop == maLop);
            if (lop == null)
            {
                MessageBox.Show("Không tìm thấy lớp!");
                return;
            }

            bool coSinhVien = db.tbl_SinhViens
                .Any(sv => sv.MaLop == maLop && (sv.IsDeleted == false || sv.IsDeleted == null));

            if (coSinhVien)
            {
                MessageBox.Show("Không thể xóa lớp vì vẫn còn sinh viên!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa lớp này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes) return;

            try
            {
                db.tbl_LopHocs.DeleteOnSubmit(lop);
                db.SubmitChanges();

                MessageBox.Show("Xóa lớp học thành công!");

                LoadLopHoc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_malop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_tenlop.Text) || cb_khoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string maLop = txt_malop.Text.Trim();

            var lop = db.tbl_LopHocs.FirstOrDefault(l => l.MaLop == maLop);

            if (lop == null)
            {
                MessageBox.Show("Không tìm thấy lớp!");
                return;
            }

            try
            {
                lop.TenLop = txt_tenlop.Text.Trim();
                lop.MaKhoa = cb_khoa.SelectedValue.ToString();


                db.SubmitChanges();

                MessageBox.Show("Cập nhật lớp học thành công!");

                LoadLopHoc();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_dsachsinhvien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_malop.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                return;
            }

            string maLop = txt_malop.Text.Trim();

            frm_SinhVien1Lop frm = new frm_SinhVien1Lop(maLop);
            frm.Show();
            this.Hide();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_timkiem.Text))
                LoadLopHoc(); 
            else
                LoadLopHocTheoTu(txt_timkiem.Text);
        }
        private void LoadLopHocTheoTu(string tukhoa)
        {
            string tk = tukhoa.Trim();

            var ds = (from lh in db.tbl_LopHocs
                      join k in db.tbl_Khoas on lh.MaKhoa equals k.MaKhoa into tmp
                      from k in tmp.DefaultIfEmpty()

                      let siSoThuc = db.tbl_SinhViens.Count(sv => sv.MaLop == lh.MaLop
                              && (sv.IsDeleted == false || sv.IsDeleted == null))

                      where lh.MaLop.Contains(tk)
                            || lh.TenLop.Contains(tk)
                            || (k != null && k.TenKhoa.Contains(tk))

                      orderby lh.MaLop

                      select new
                      {
                          lh.MaLop,
                          lh.TenLop,
                          Khoa = k != null ? k.TenKhoa : "",
                          SiSo = siSoThuc,
                          lh.MaKhoa
                      }).ToList();

            dataGridView1.DataSource = ds;

            if (dataGridView1.Columns["MaKhoa"] != null)
                dataGridView1.Columns["MaKhoa"].Visible = false;

            FormatGrid();
        }
        private void txt_timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                btn_timkiem.PerformClick(); 
            }
        }
    }
}
