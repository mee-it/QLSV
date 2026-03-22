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
    public partial class frm_SinhVien1Lop : Form
    {
        DataBaseDataContext db = new DataBaseDataContext();
        string maLop = "";
        public frm_SinhVien1Lop(string maLop)
        {
            InitializeComponent();
            this.maLop = maLop;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_SinhVien1Lop_Load(object sender, EventArgs e)
        {
            LoadSinhVienTheoLop();
         
            ClearForm();
        }
        private void LoadSinhVienTheoLop()
        {
            var ds = (from sv in db.tbl_SinhViens
                      join l in db.tbl_LopHocs on sv.MaLop equals l.MaLop 
                      where sv.MaLop == maLop && sv.IsDeleted != true
                      orderby sv.MaSV
                      select new
                      {
                          sv.MaSV,
                          sv.HoTen,
                          sv.NgaySinh,
                          sv.GioiTinh,
                          Lop = l.TenLop
                      }).ToList();

            var lopObj = db.tbl_LopHocs.FirstOrDefault(l => l.MaLop == maLop); 
            lbl_tenlop.Text = lopObj != null ? lopObj.TenLop : "Danh sách sinh viên";
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
        
        private void ClearForm()
        {
            txt_masv.Text = "";
            txt_hoten.Text = "";

            dtp_ngaysinh.Value = DateTime.Today;

            cb_gioitinh.SelectedIndex = -1;


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
            if (DateTime.TryParse(ngs?.ToString(), out var d))
                dtp_ngaysinh.Value = d;
            cb_gioitinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
            
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            frm_Quanlylophoc main = new frm_Quanlylophoc();
            main.Show();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            tbl_SinhVien sv = GetSinhVienFromForm();
            if (sv == null) return; 
         
            sv.MaLop = maLop; 

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
                        // Cập nhật thông tin sinh viên
                        svCu.HoTen = sv.HoTen;
                        svCu.NgaySinh = sv.NgaySinh;
                        svCu.GioiTinh = sv.GioiTinh;
                        svCu.MaLop = maLop;
                        svCu.IsDeleted = false;

                        db.SubmitChanges();

                        MessageBox.Show("Khôi phục và update sinh viên thành công!");
                        LoadSinhVienTheoLop(); // load lại danh sách sinh viên theo lớp hiện tại
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

            // Nếu sinh viên chưa tồn tại, thêm mới
            sv.IsDeleted = false;
            db.tbl_SinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();

            MessageBox.Show("Thêm sinh viên thành công!");
            LoadSinhVienTheoLop(); // load lại danh sách sinh viên theo lớp hiện tại
            ClearForm();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private tbl_SinhVien GetSinhVienFromForm()
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(txt_masv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên.");
                txt_masv.Focus();
                return null;
            }
            if (string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên.");
                txt_hoten.Focus();
                return null;
            }
            if (cb_gioitinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                cb_gioitinh.Focus();
                return null;
            }

            return new tbl_SinhVien
            {
                MaSV = txt_masv.Text.Trim(),
                HoTen = txt_hoten.Text.Trim(),
                NgaySinh = dtp_ngaysinh.Value,
                GioiTinh = cb_gioitinh.Text.Trim()
                // MaLop will be set in btn_them_Click
            };
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn sửa!");
                return;
            }

            string maSV = dataGridView1.SelectedRows[0].Cells["MaSV"].Value.ToString();

            // Lấy sinh viên từ database
            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.MaSV == maSV && x.IsDeleted != true);
            if (sv == null)
            {
                MessageBox.Show("Sinh viên không tồn tại hoặc đã bị xóa!");
                return;
            }

            // Cập nhật thông tin từ form
            string hoTen = txt_hoten.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!");
                txt_hoten.Focus();
                return;
            }

            if (cb_gioitinh.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                cb_gioitinh.Focus();
                return;
            }

            sv.HoTen = hoTen;
            sv.NgaySinh = dtp_ngaysinh.Value;
            sv.GioiTinh = cb_gioitinh.SelectedItem.ToString();

            db.SubmitChanges();

            MessageBox.Show("Cập nhật sinh viên thành công!");
            LoadSinhVienTheoLop(); // load lại danh sách theo lớp
            ClearForm();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên muốn xóa!");
                return;
            }

            string maSV = dataGridView1.SelectedRows[0].Cells["MaSV"].Value.ToString();

            var sv = db.tbl_SinhViens.FirstOrDefault(x => x.MaSV == maSV && x.IsDeleted != true);
            if (sv == null)
            {
                MessageBox.Show("Sinh viên không tồn tại hoặc đã bị xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên {sv.HoTen} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                // Xóa mềm
                sv.IsDeleted = true;
                db.SubmitChanges();

                MessageBox.Show("Xóa sinh viên thành công!");
                LoadSinhVienTheoLop(); // load lại danh sách theo lớp
                ClearForm();
            }
        }

        private void btn_truoc_Click(object sender, EventArgs e)
        {

        }
    }
}
