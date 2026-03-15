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
    public partial class frm_Quanlysinhvien : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        private readonly object dataGridView;

        private ComboBox cb_gioitinh;

        public frm_Quanlysinhvien()
        {
            InitializeComponent();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {//Xóa sinh viên
            if (string.IsNullOrWhiteSpace(txt_masv.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.MaSV == txt_masv.Text);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No) return;

            // XÓA MỀM
            sv.IsDeleted = true;

            db.SubmitChanges();

            MessageBox.Show("Đã xóa sinh viên!");

            LoadSinhvien();
            ClearForm();
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_masv.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!");
                return;
            }

            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.MaSV == txt_masv.Text);

            if (sv == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
                return;
            }

            try
            {
                sv.HoTen = txt_hoten.Text;
                sv.NgaySinh = dtp_ngaysinh.Value;
                sv.GioiTinh = cb_ngaysinh.Text;
                sv.MaLop = txt_malop.Text;

                db.SubmitChanges();

                MessageBox.Show("Cập nhật sinh viên thành công!");

                LoadSinhvien();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frm_Quanlysinhvien_Load(object sender, EventArgs e)
        {
            //hiển thị dữ liệu lên datagridview

            LoadSinhvien();
            ClearForm();

        }
        private void LoadSinhvien()
        {
            var ds = (from sv in db.tbl_SinhViens
                      join lop in db.tbl_LopHocs on sv.MaLop equals lop.MaLop
                      where sv.IsDeleted == false || sv.IsDeleted == null
                      orderby sv.MaSV
                      select new
                      {
                          sv.MaSV,
                          sv.HoTen,
                          sv.NgaySinh,
                          sv.GioiTinh,
                          Lop = lop.TenLop,
                          MaLop = lop.MaLop
                      }).ToList();

            dataGridView1.DataSource = ds;
            FormatGrid();
        }
        private void FormatGrid()
        {
            if (dataGridView1.Columns["MaSV"] != null)
                dataGridView1.Columns["MaSV"].HeaderText = "Mã sinh viên";

            if (dataGridView1.Columns["HoTen"] != null)
                dataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";

            if (dataGridView1.Columns["NgaySinh"] != null)
                dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";

            if (dataGridView1.Columns["GioiTinh"] != null)
                dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (dataGridView1.Columns["MaLop"] != null)
                dataGridView1.Columns["MaLop"].HeaderText = "Mã lớp";

            if (dataGridView1.Columns["Lop"] != null)
                dataGridView1.Columns["Lop"].HeaderText = "Lớp";

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Thêm sinh viên
            tbl_SinhVien sv = GetSinhVienFromForm();
            if (sv == null) return;

            // Kiểm tra mã lớp
            var maLop = txt_malop.Text.Trim();
            if (!db.tbl_LopHocs.Any(l => l.MaLop == maLop))
            {
                MessageBox.Show("Mã lớp không tồn tại. Vui lòng chọn hoặc tạo lớp trước.");
                return;
            }

            // Tìm sinh viên có cùng MaSV
            var svCu = db.tbl_SinhViens.FirstOrDefault(x => x.MaSV == sv.MaSV);

            if (svCu != null)
            {
                if (svCu.IsDeleted == true)
                {
                    DialogResult kq = MessageBox.Show(
                        "Sinh viên này đã bị xóa trước đó.\nBạn có muốn khôi phục và update không?",
                        "Khôi phục sinh viên",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (kq == DialogResult.Yes)
                    {
                        svCu.HoTen = sv.HoTen;
                        svCu.NgaySinh = sv.NgaySinh;
                        svCu.GioiTinh = sv.GioiTinh;
                        svCu.MaLop = sv.MaLop;
                        svCu.IsDeleted = false;

                        db.SubmitChanges();

                        MessageBox.Show("Khôi phục và update sinh viên thành công!");
                        LoadSinhvien();
                        ClearForm();
                    }

                    return;
                }
                else
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }
            }

            // Nếu chưa tồn tại thì thêm mới
            sv.IsDeleted = false;
            db.tbl_SinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");

            LoadSinhvien();
            ClearForm();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txt_masv.Text = "";
            txt_hoten.Text = "";
            dtp_ngaysinh.Value = DateTime.Today;
            cb_ngaysinh.SelectedIndex = -1;
            txt_lop.Text = "";
            txt_malop.Text = "";
            txt_masv.Enabled = true;

            dataGridView1.ClearSelection();

            txt_masv.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];

            txt_masv.Text = row.Cells["MaSV"].Value?.ToString() ?? "";
            txt_hoten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            var ngs = row.Cells["NgaySinh"].Value;
            if (DateTime.TryParse(ngs?.ToString(), out var d)) dtp_ngaysinh.Value = d;
            cb_ngaysinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
            txt_lop.Text = row.Cells["Lop"].Value?.ToString() ?? "";
            if (dataGridView1.Columns["MaLop"] != null)
                txt_malop.Text = row.Cells["MaLop"].Value?.ToString() ?? "";
            else
                txt_malop.Text = ""; // or derive from Lop

            txt_masv.Enabled = false;
        }

        private void dtp_ngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private tbl_SinhVien GetSinhVienFromForm()
        {
            string gender = cb_ngaysinh?.Text ?? "";
            if (string.IsNullOrWhiteSpace(txt_masv?.Text) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(txt_hoten?.Text) ||
                string.IsNullOrWhiteSpace(txt_malop?.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return null;
            }

            var sv = new tbl_SinhVien {
                MaSV = txt_masv.Text.Trim(),
                HoTen = txt_hoten.Text.Trim(),
                NgaySinh = dtp_ngaysinh.Value,
                GioiTinh = cb_ngaysinh.Text,
                MaLop = txt_malop.Text.Trim()
            };

            return sv;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_timkiem.Text))
                LoadSinhvien();
            else
                LoadSinhVienTheoTu(txt_timkiem.Text);
        }
        private void LoadSinhVienTheoTu(string tukhoa)
        {
            string tk = tukhoa.Trim();

            var ds = (from sv in db.tbl_SinhViens
                      join lop in db.tbl_LopHocs on sv.MaLop equals lop.MaLop
                      where sv.IsDeleted != true &&
                           (sv.MaSV.Contains(tk) ||
                            sv.HoTen.Contains(tk) ||
                            lop.TenLop.Contains(tk))
                      orderby sv.MaSV
                      select new
                      {
                          sv.MaSV,
                          sv.HoTen,
                          sv.NgaySinh,
                          sv.GioiTinh,
                          Lop = lop.TenLop,
                          MaLop = lop.MaLop
                      }).ToList();

            dataGridView1.DataSource = ds;
            FormatGrid();
        }

        private void txt_timkiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_timkiem.PerformClick();
        }
    }
}
