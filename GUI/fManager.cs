using Bunifu.UI.WinForms.BunifuButton;
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace GUI
{
    public partial class fManager : Form
    {
        private TaiKhoanDTO taiKhoanLogin;
        private NhanVienBUS nhanVienBUS = new NhanVienBUS();
        private NguyenLieuBUS nguyenLieuBUS = new NguyenLieuBUS();
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private MonAnBUS monAnBUS = new MonAnBUS();
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();
        private LoaiMonBUS loaiMonBUS = new LoaiMonBUS();
        private LoaiNguyenLieuBUS loaiNguyenLieuBUS = new LoaiNguyenLieuBUS();
        private DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
        private BanAnBUS banAnBUS = new BanAnBUS();
        private ChiTietDatMonBUS chiTietDatMonBUS = new ChiTietDatMonBUS();
        private ChiTietPhieuNhapBUS chiTietPhieuNhapBUS = new ChiTietPhieuNhapBUS();
        private NhaCungCapBUS nhaCungCapBUS = new NhaCungCapBUS();
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        string curID = "";
        string curBanAnID = "";
        BindingSource listNhanVien = new BindingSource();
        BindingSource listTK = new BindingSource();
        BindingSource listMA = new BindingSource();
        BindingSource listNL = new BindingSource();
        BindingSource listCTHD = new BindingSource();
        BindingSource listCTPN = new BindingSource();
        DataGridView dt = new DataGridView();
        public fManager(TaiKhoanDTO taiKhoan)
        {
            InitializeComponent();
            taiKhoanLogin = taiKhoan;
        }

        private void PhanQuyen(int phanQuyen)
        {
            btnMonAn.Enabled = btnMonAn.Enabled = btnNguyenLieu.Enabled = btnNhanVien.Enabled
                = btnNhapHang.Enabled = btnDoanhThu.Enabled = btnTaiKhoan.Enabled = (phanQuyen == 1);
            lbDisplayHello.Text += " " + taiKhoanLogin.DisplayName;
        }
        private void fManager_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = listNhanVien;
            dgvTaiKhoan.DataSource = listTK;
            dgvMonAn.DataSource = listMA;
            dgvNguyenLieu.DataSource = listNL;
            dgvCTPN.DataSource = listCTPN;
            dt.DataSource = listCTHD;
            cbMALMA.ValueMember = "MaLM";
            cbMALMA.DisplayMember = "TenLM";
            cbMALMA.DataSource = loaiMonBUS.GetListLoaiMon();
            cbNLLoaiNL.ValueMember = "MaLNL";
            cbNLLoaiNL.DisplayMember = "TenLNL";
            cbNLLoaiNL.DataSource = loaiNguyenLieuBUS.GetListLoaiNguyenLieu();
            cbLoaiDoanhThu.Items.Add("Ngày");
            cbLoaiDoanhThu.Items.Add("Tháng");
            cbLoaiDoanhThu.Items.Add("Năm");

            LoadChiTietPN("");
            LoadCBNCC();
            LoadCBPN();
            LoadCBNL();
            LoadListTK();
            LoadListNhanVien();
            LoadListMA();
            LoadListNL();
            LoadBanAn();
            LoadCBLMA();
            AddTKBinding();
            AddNhanVienBinding();
            AddMABinding();
            AddNLBinding();
            PhanQuyen(taiKhoanLogin.PhanQuyen);
            timer1.Start();
        }
        private bool isNotValidatedForm(List<TextBox> ltb)
        {
            foreach (TextBox item in ltb)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Không được phép để trống thông tin");
                    item.Focus();
                    return true;
                }
            }
            return false;
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            BunifuButton B = (BunifuButton)sender;
            indicator.Top = B.Top + 10;
            bunifuPages1.SetPage(B.TabIndex - 7);
        }


        /*Code trang chủ*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTrangChuPhutGio.Text = DateTime.Now.ToString("HH:mm");
            lblTrangChuGiay.Text = DateTime.Now.ToString("ss");
            lblTrangChuDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTrangChuThu.Text = DateTime.Now.ToString("dddd");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                fLogin f = new fLogin();
                f.Show();
            }
        }
        /*Kết thúc code trang chủ*/


        /*Mở đầu code trang nhân viên*/
        private void LoadListNhanVien()
        {
            listNhanVien.DataSource = nhanVienBUS.GetListNhanVien();
        }

        private void AddNhanVienBinding()
        {
            txtNVMaNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
            txtNVTenNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
            txtNVDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtNVGioiTinh.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txtNVSDT.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txtNVChucVu.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
        }
        private bool isNotValidatedFormNV()
        {
            List<TextBox> ltb = new List<TextBox>()
            {
                txtNVMaNV, txtNVTenNV, txtNVDiaChi, txtNVGioiTinh, txtNVSDT, txtNVChucVu
            };
            if (isNotValidatedForm(ltb))
            {
                return true;
            }
            return false;
        }
        private void btnNVThem_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormNV())
            {
                return;
            }
            if (!nhanVienBUS.InsertNhanVien(txtNVMaNV.Text, txtNVTenNV.Text, txtNVDiaChi.Text, txtNVGioiTinh.Text, txtNVSDT.Text, txtNVChucVu.Text))
            {
                MessageBox.Show("Nhân viên có mã này đã tồn tại trên hệ thống !");
                return;
            }
            MessageBox.Show("Thêm mới thành công !");
            listNhanVien.DataSource = nhanVienBUS.GetListNhanVien();
        }

        private void btnNVSua_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormNV())
            {
                return;
            }
            if (!nhanVienBUS.UpdateNhanVien(txtNVMaNV.Text, txtNVTenNV.Text, txtNVDiaChi.Text, txtNVGioiTinh.Text, txtNVSDT.Text, txtNVChucVu.Text))
            {
                MessageBox.Show("Không có Nhân viên có mã này trên hệ thống !");
                return;
            }
            MessageBox.Show("Cập nhật thành công !");
            listNhanVien.DataSource = nhanVienBUS.GetListNhanVien();
        }

        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            if (txtNVMaNV.Text == "")
            {
                MessageBox.Show("Chưa chọn phần tử để xóa");
                return;
            }
            if (!nhanVienBUS.DeleteNhanVien(txtNVMaNV.Text))
            {
                MessageBox.Show("Không có Nhân viên có mã này trên hệ thống !");
                return;
            }
            MessageBox.Show("Xóa thành công !");
            listNhanVien.DataSource = nhanVienBUS.GetListNhanVien();
        }

        private void btnNVTimKiem_Click(object sender, EventArgs e)
        {
            listNhanVien.DataSource = nhanVienBUS.GetListNhanVien(txtNVTimKiem.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            List<TextBox> ltb = new List<TextBox>()
            {
                txtNVMaNV, txtNVTenNV, txtNVDiaChi, txtNVGioiTinh, txtNVSDT, txtNVChucVu
            };
            foreach (var item in ltb)
            {
                item.Text = "";
            }
            txtNVTimKiem.Text = "";
        }

        private void btnNVTaoMaNV_Click(object sender, EventArgs e)
        {
            txtNVMaNV.Text = nhanVienBUS.GetDistinctID();
        }

        /*Kết thúc Code trang nhân viên*/

        /*Mở đầu Code trang tài khoản*/
        private void LoadListTK()
        {
            listTK.DataSource = taiKhoanBUS.GetListTK();
        }

        private void AddTKBinding()
        {
            txtTKTenTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtTKTenHT.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            txtTKMK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "PassWord", true, DataSourceUpdateMode.Never));
            nmPhanQuyen.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "PhanQuyen", true, DataSourceUpdateMode.Never));
        }
        private bool isNotValidatedFormTK()
        {
            List<TextBox> ltb = new List<TextBox>()
            {
                txtTKTenTK, txtTKTenHT, txtTKMK
            };
            if (isNotValidatedForm(ltb))
            {
                return true;
            }
            return false;
        }

        private void btnTKThem_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormTK())
            {
                return;
            }
            if (!taiKhoanBUS.InsertTK(txtTKTenTK.Text, txtTKMK.Text, txtTKTenHT.Text, (int)nmPhanQuyen.Value))
            {
                MessageBox.Show("Đã tồn tại tên tài khoản này trên hệ thống !");
                return;
            }
            MessageBox.Show("Thêm mới tài khoản thành công !");
            LoadListTK();
        }

        private void btnTKSua_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormTK())
            {
                return;
            }
            if (txtTKTenTK.Text == taiKhoanLogin.UserName)
            {
                taiKhoanBUS.UpdateTK(txtTKTenTK.Text, txtTKMK.Text, txtTKTenHT.Text, (int)nmPhanQuyen.Value);
                MessageBox.Show("Cập nhật thông tin thành công! Vui lòng đăng nhập lại!");
                this.Close();
                fLogin f = new fLogin();
                f.Show();
                return;
            }
            if (!taiKhoanBUS.UpdateTK(txtTKTenTK.Text, txtTKMK.Text, txtTKTenHT.Text, (int)nmPhanQuyen.Value))
            {
                MessageBox.Show("Không có tài khoản này trên hệ thống");
                return;
            }
            MessageBox.Show("Cập nhật tài khoản thành công !");
            LoadListTK();
        }

        private void btnTKXoa_Click(object sender, EventArgs e)
        {
            if (txtTKTenTK.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản để xóa");
                return;
            }
            if (txtTKTenTK.Text == taiKhoanLogin.UserName)
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                return;
            }
            if (!taiKhoanBUS.DeleteTK(txtTKTenTK.Text))
            {
                MessageBox.Show("Không thể xóa tài khoản này vì có thông tin liên quan đến các hóa đơn!");
                return;
            }
            MessageBox.Show("Xóa thành công !");
            LoadListTK();
        }
        private void btnTKHuy_Click(object sender, EventArgs e)
        {
            txtTKTenTK.Text = txtTKTenHT.Text = txtTKMK.Text = "";
            nmPhanQuyen.Value = 0;
            txtTKTenTK.Focus();
        }
        /*Kết thúc Code trang tài khoản*/

        /*Mở đầu trang Món ăn*/
        private void LoadListMA()
        {
            listMA.DataSource = monAnBUS.GetListMonAn();
        }

        private void AddMABinding()
        {
            txtMAMaMon.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "MaMA", true, DataSourceUpdateMode.Never));
            txtMATenMon.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "TenMonAn", true, DataSourceUpdateMode.Never));
            nmMAGia.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }
        private bool isNotValidatedFormMA()
        {
            List<TextBox> ltb = new List<TextBox>()
            {
                txtMAMaMon, txtMATenMon
            };
            if (isNotValidatedForm(ltb))
            {
                return true;
            }
            if (cbMALMA.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn loại món ăn");
                return true;
            }
            if (nmMAGia.Text == "")
            {
                MessageBox.Show("Đơn giá không được để trống");
                return true;
            }
            if (nmMAGia.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0");
                return true;
            }
            return false;
        }

        private void btnMASua_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormMA())
            {
                return;
            }
            if (!monAnBUS.UpdateMonAn(txtMAMaMon.Text, txtMATenMon.Text, (decimal)nmMAGia.Value, (string)cbMALMA.SelectedValue))
            {
                MessageBox.Show("Món ăn có mã này không tồn tại trên hệ thống !");
                return;
            }
            MessageBox.Show("Cập nhật thành công !");
            LoadListMA();
        }

        private void btnMAXoa_Click(object sender, EventArgs e)
        {
            if (txtMAMaMon.Text == "")
            {
                MessageBox.Show("Phải chọn phần tử để xóa !");
                return;
            }
            if (!monAnBUS.DeleteMonAn(txtMAMaMon.Text))
            {
                MessageBox.Show("Không có thể xóa món ăn có mã này !");
                return;
            }
            MessageBox.Show("Xóa thành công !");
            LoadListMA();
        }

        private void btnMATaoMa_Click(object sender, EventArgs e)
        {
            txtMAMaMon.Text = monAnBUS.GetDistinctID();
        }

        private void btnMAHuy_Click(object sender, EventArgs e)
        {
            txtMAMaMon.Text = txtMAMaMon.Text = "";
            nmMAGia.Value = 0;
            cbMALMA.SelectedIndex = -1;
        }

        private void btnMAThem_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormMA())
            {
                return;
            }
            if (!monAnBUS.InsertMonAn(txtMAMaMon.Text, txtMATenMon.Text, (decimal)nmMAGia.Value, (string)cbMALMA.SelectedValue))
            {
                MessageBox.Show("Món ăn có mã này đã tồn tại trên hệ thống !");
                return;
            }
            MessageBox.Show("Thêm mới thành công !");
            LoadListMA();
        }

        private void txtMAMaMon_TextChanged(object sender, EventArgs e)
        {
            if (dgvMonAn.SelectedCells.Count <= 0 || txtMAMaMon.Text == "")
            {
                return;
            }
            string temp = (string)dgvMonAn.SelectedCells[0].OwningRow.Cells["MaLM"].Value;
            cbMALMA.SelectedValue = temp;
        }

        private void btnMATimKiem_Click(object sender, EventArgs e)
        {
            listMA.DataSource = monAnBUS.GetListMonAn(txtMATimKiem.Text);
        }
        /*Kết thúc Code trang món ăn*/

        /*Mở đầu Code trang nguyên liệu*/
        private void LoadListNL()
        {
            listNL.DataSource = nguyenLieuBUS.GetListNguyenLieu();
        }

        private void AddNLBinding()
        {
            txtNLMaNL.DataBindings.Add(new Binding("Text", dgvNguyenLieu.DataSource, "MaNL", true, DataSourceUpdateMode.Never));
            txtNLTenNL.DataBindings.Add(new Binding("Text", dgvNguyenLieu.DataSource, "TenNL", true, DataSourceUpdateMode.Never));
            txtNLDonVi.DataBindings.Add(new Binding("Text", dgvNguyenLieu.DataSource, "DVT", true, DataSourceUpdateMode.Never));
            txtNLSoLuong.DataBindings.Add(new Binding("Text", dgvNguyenLieu.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
        }
        private bool isNotValidatedFormNL()
        {
            List<TextBox> ltb = new List<TextBox>()
            {
                txtNLMaNL, txtNLTenNL, txtNLDonVi, txtNLSoLuong
            };
            if (isNotValidatedForm(ltb))
            {
                return true;
            }
            if (cbNLLoaiNL.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn loại nguyên liệu");
                return true;
            }
            return false;
        }
        private void btnNLTimKiem_Click(object sender, EventArgs e)
        {
            listNL.DataSource = nguyenLieuBUS.GetListNguyenLieu(txtNLTimKiem.Text);
        }

        private void btnNLThem_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormNL())
            {
                return;
            }
            if (!nguyenLieuBUS.InsertNguyenLieu(txtNLMaNL.Text, txtNLTenNL.Text, txtNLDonVi.Text, int.Parse(txtNLSoLuong.Text), (string)cbNLLoaiNL.SelectedValue))
            {
                MessageBox.Show("Nguyên liệu có mã này đã tồn tại trên hệ thống !");
                return;
            }
            MessageBox.Show("Thêm mới thành công !");
            LoadListNL();
        }

        private void btnNLSua_Click(object sender, EventArgs e)
        {
            if (isNotValidatedFormNL())
            {
                return;
            }
            if (!nguyenLieuBUS.UpdateNguyenLieu(txtNLMaNL.Text, txtNLTenNL.Text, txtNLDonVi.Text, int.Parse(txtNLSoLuong.Text), (string)cbNLLoaiNL.SelectedValue))
            {
                MessageBox.Show("Nguyên liệu có mã này không tồn tại trên hệ thống !");
                return;
            }
            MessageBox.Show("Cập nhật thành công !");
            LoadListNL();
        }

        private void btnNLXoa_Click(object sender, EventArgs e)
        {
            if (txtNLMaNL.Text == "")
            {
                MessageBox.Show("Phải chọn phần tử để xóa !");
                return;
            }
            if (!nguyenLieuBUS.DeleteNguyenLieu(txtNLMaNL.Text))
            {
                MessageBox.Show("Không có thể xóa món ăn có mã này !");
                return;
            }
            MessageBox.Show("Xóa thành công !");
            LoadListNL();
        }

        private void btnNLTaoMa_Click(object sender, EventArgs e)
        {
            txtNLMaNL.Text = nguyenLieuBUS.GetDistinctID();
        }

        private void btnNLHuy_Click(object sender, EventArgs e)
        {
            txtNLMaNL.Text = txtNLTenNL.Text = txtNLDonVi.Text = txtNLSoLuong.Text = "";
            cbNLLoaiNL.SelectedIndex = -1;
        }

        private void txtNLMaNL_TextChanged(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedCells.Count <= 0 || txtNLMaNL.Text == "")
            {
                return;
            }
            string temp = (string)dgvNguyenLieu.SelectedCells[0].OwningRow.Cells["MaLNL"].Value;
            cbNLLoaiNL.SelectedValue = temp;
        }
        /*Kết thúc Code trang nguyên liệu*/

        /*Mở đầu code trang doanh thu*/
        private void LoadListDoanhThu()
        {
            dgvDoanhThu.DataSource = doanhThuBUS.GetDoanhThu(dtpNgayBD.Value.ToString("yyyy-MM-dd"), dtpNgayKetThuc.Value.ToString("yyyy-MM-dd"), cbLoaiDoanhThu.SelectedIndex);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cbLoaiDoanhThu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hình thức thống kê của doanh thu !");
                return;
            }
            LoadListDoanhThu();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvDoanhThu.Rows.Count <= 0)
            {
                MessageBox.Show("Không đủ dữ liệu để xuất báo cáo");
                return;
            }
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1]; 
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "NHÀ HÀNG TCT";

            Excel.Range DiaChi = (Excel.Range)exSheet.Cells[2, 1];
            DiaChi.Font.Size = 13;
            DiaChi.Font.Color = Color.Blue;
            DiaChi.Value = "36 Phố phường Hà Nội";

            exSheet.Range["C3"].Font.Size = 15;
            exSheet.Range["C3"].Font.Bold = true;
            exSheet.Range["C3"].Font.Color = Color.Red;
            exSheet.Range["C3"].Value = "BÁO CÁO DOANH THU";

            exSheet.Range["A5:A8"].Font.Size = 12;
            exSheet.Range["A5"].Value = "Báo cáo doanh thu theo: " + cbLoaiDoanhThu.Items[cbLoaiDoanhThu.SelectedIndex];
            exSheet.Range["A6"].Value = "Từ ngày: " + dtpNgayBD.Value.ToString("dd/MM/yyyy");
            exSheet.Range["A7"].Value = "Đến ngày: " + dtpNgayKetThuc.Value.ToString("dd/MM/yyyy");
            exSheet.Range["A8"].Value = "Ngày lập: " + DateTime.Now.ToShortDateString();

            exSheet.Range["A10:G10"].Font.Size = 12;
            exSheet.Range["A10:G10"].Font.Bold = true;
            exSheet.Range["A10:G10"].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Thời gian";
            exSheet.Range["B10"].ColumnWidth = 18;
            exSheet.Range["C10"].ColumnWidth = 18;
            exSheet.Range["D10"].ColumnWidth = 18;
            exSheet.Range["F10"].ColumnWidth = 20;
            exSheet.Range["E10"].ColumnWidth = 15;
            exSheet.Range["C10"].Value = "Tổng tiền bán";
            exSheet.Range["D10"].Value = "Tổng tiền nhập";
            exSheet.Range["E10"].Value = "Đánh giá";
            exSheet.Range["F10"].Value = "Tổng cộng";

            int row = 11;
            decimal TongTien = 0;
            for (int i = 0; i < dgvDoanhThu.RowCount-1; ++i)
            {
                exSheet.Range["A" + (row + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (row + i).ToString()].Value = "'" + dgvDoanhThu.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (row + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (row + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (row + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (row + i).ToString()].Value = dgvDoanhThu.Rows[i].Cells[4].Value.ToString() + " đồng";
                exSheet.Range["F" + (row + i).ToString()].Cells.HorizontalAlignment =
                exSheet.Range["B" + (row + i).ToString()].Cells.HorizontalAlignment =
                exSheet.Range["E" + (row + i).ToString()].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                TongTien += (dgvDoanhThu.Rows[i].Cells[3].Value.ToString() == "Lãi") ? ((decimal)dgvDoanhThu.Rows[i].Cells[4].Value) : (-(decimal)dgvDoanhThu.Rows[i].Cells[4].Value);

            }
            row += dgvDoanhThu.RowCount;
            string t = "Lỗ: ";
            if (TongTien >= 0) t = "Lãi: ";
            exSheet.Range["E" + row.ToString()].Value = t + Math.Abs(TongTien).ToString() + " đồng";
            exSheet.Range["E" + (row + 1).ToString()].Value = "User: " + taiKhoanLogin.UserName;
            exSheet.Name = "BCDoanhThu";
            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002|*.xls|Excel Workbook|*xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();
            MessageBox.Show("Đã xuất ra file excel thành công !");
        }
        /*Kết thúc code trang doanh thu*/

        /*Code Gọi món*/
        private void LoadBanAn()
        {
            flpBanAn.Controls.Clear();
            List<BanAnDTO> ListBanAn = banAnBUS.GetListBanAn();
            foreach (var item in ListBanAn)
            {
                Button btn = new Button() { Width = BanAnBUS.banAnWidth, Height = BanAnBUS.banAnHeight };
                btn.Text = item.TenBan + Environment.NewLine + item.TinhTrang;
                btn.Click += btnBanAn_Click;
                btn.Tag = item;
                btn.BackColor = Color.AliceBlue;    
                if (item.TinhTrang != "Trống")
                {
                    btn.BackColor = Color.PowderBlue;
                }
                flpBanAn.Controls.Add(btn);
            }
        }
        private void btnBanAn_Click(object sender, EventArgs e)
        {
            string maBan = ((sender as Button).Tag as BanAnDTO).MaBan;
            ShowChiTietDat(maBan);
            curBanAnID = maBan;
        }
        private void ShowChiTietDat(string maBan)
        {
            lsvGoiMon.Items.Clear();
            txtGoiMonTongTien.Text = "0";
            curID = hoaDonBUS.GetMaHoaDonByBanAn(maBan);
            if (curID == "")
            {
                lsvGoiMon.Tag = null;
                return;
            }
            List<ChiTietDatMonDTO> listChiTietDatMonDTO = chiTietDatMonBUS.GetListChiTietDatMon(curID);
            lsvGoiMon.Tag = listChiTietDatMonDTO;
            listCTHD.DataSource = listChiTietDatMonDTO;
            foreach (var item in listChiTietDatMonDTO)
            {
                ListViewItem lsvItem = new ListViewItem(monAnBUS.GetMonAnByMa(item.MaMA));
                lsvItem.SubItems.Add(item.DonGia.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.ThanhTien.ToString());
                lsvGoiMon.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtGoiMonTongTien.Text = hoaDonBUS.GetTongTienByMa(curID).ToString("c", culture);
        }
        private void LoadCBLMA()
        {
            cbGoiMonLM.ValueMember = "MaLM";
            cbGoiMonLM.DisplayMember = "TenLM";
            cbGoiMonLM.DataSource = loaiMonBUS.GetListLoaiMon();
        }
        private void LoadCBMonAnByLoai(string maLM)
        {
            cbGoiMonMA.DisplayMember = "TenMonAn";
            cbGoiMonMA.ValueMember = "MaMA";
            cbGoiMonMA.DataSource = monAnBUS.GetListMonAnCoCongThuc(maLM); ;
        }
        private void btnGoiMonThemMon_Click(object sender, EventArgs e)
        {

            if (nmGoiMonSLM.Text == "")
            {
                MessageBox.Show("Vui lòng chọn số lượng !");
                return;
            }
            if (curID == "")
            {
                curID = hoaDonBUS.GetDistinctID();
                if (!hoaDonBUS.InsertHoaDon(curID, DateTime.Now, null, 0, 0, taiKhoanLogin.UserName, curBanAnID))
                {
                    MessageBox.Show("Insert hóa đơn thất bại!");
                    return;
                }
            }
            if (!chiTietDatMonBUS.InsertChiTietDatMon(curID, cbGoiMonMA.SelectedValue.ToString(), 0, (int)nmGoiMonSLM.Value, 0))
            {
                MessageBox.Show("Không còn đủ nguyên liệu cho lần thêm món này");
                return;
            }
            listNL.DataSource = nguyenLieuBUS.GetListNguyenLieu();
            LoadBanAn();
            ShowChiTietDat(curBanAnID);
        }

        private void cbGoiMonLM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maLM = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            LoaiMonDTO selected = cb.SelectedItem as LoaiMonDTO;
            maLM = selected.MaLM;
            LoadCBMonAnByLoai(maLM);
        }

        private void btnGoiMonHuyDon_Click(object sender, EventArgs e)
        {
            if (curID == "")
            {
                MessageBox.Show("Chưa có đơn để hủy !");
                return;
            }
            if (!hoaDonBUS.DeleteHoaDon(curID))
            {
                MessageBox.Show("Đã xảy ra lỗi");
                return;
            };
            curID = "";
            MessageBox.Show("Hủy đơn thành công !");
            banAnBUS.UpdateTinhTrangBan(curBanAnID, "Trống");
            LoadBanAn();
            ShowChiTietDat(curID);
            listNL.DataSource = nguyenLieuBUS.GetListNguyenLieu();
        }

        private void btnGoiMonThanhToan_Click(object sender, EventArgs e)
        {
            if (curID == "")
            {
                MessageBox.Show("Chưa có dữ liệu để thanh toán");
                return;
            }

            string temp = curID;
            hoaDonBUS.CheckOut(curID);
            HoaDonDTO hd = hoaDonBUS.GetHoaDonByMa(curID);


            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "NHÀ HÀNG TCT";

            Excel.Range DiaChi = (Excel.Range)exSheet.Cells[2, 1];
            DiaChi.Font.Size = 13;
            DiaChi.Font.Color = Color.Blue;
            DiaChi.Value = "36 Phố phường Hà Nội";

            exSheet.Range["C4"].Font.Size = 15;
            exSheet.Range["C4"].Font.Bold = true;
            exSheet.Range["C4"].Font.Color = Color.Red;
            exSheet.Range["C4"].Value = "Hóa đơn thanh toán";


            exSheet.Range["A5:A8"].Font.Size = 12;
            exSheet.Range["A5"].Value = "Ngày lập: " + DateTime.Now.ToShortDateString();
            exSheet.Range["A6"].Value = "Thời gian đến: " + hd.DateCheckIn.ToString();
            exSheet.Range["A7"].Value = "Thời gian đi: " + DateTime.Now.ToString();
            exSheet.Range["A8"].Value = "Khách hàng: Khách lẻ";

            exSheet.Range["A10:G10"].Font.Size = 12;
            exSheet.Range["A10:G10"].Font.Bold = true;
            exSheet.Range["A10:G10"].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Tên món ăn";
            exSheet.Range["B10"].ColumnWidth = 25;
            exSheet.Range["C10"].ColumnWidth = 20;
            exSheet.Range["D10"].ColumnWidth = 20;
            exSheet.Range["E10"].ColumnWidth = 20;
            exSheet.Range["C10"].Value = "Đơn giá";
            exSheet.Range["D10"].Value = "Số lượng";
            exSheet.Range["E10"].Value = "Thành tiền";

            int row = 10;
            List<ChiTietDatMonDTO> listChiTietDatMonDTO = chiTietDatMonBUS.GetListChiTietDatMon(temp);
            foreach (var item in listChiTietDatMonDTO)
            {
                ++row;
                exSheet.Range["A" + (row).ToString()].Value = (row - 10).ToString();
                exSheet.Range["B" + (row).ToString()].Value = monAnBUS.GetMonAnByMa(item.MaMA).ToString();
                exSheet.Range["C" + (row).ToString()].Value = item.DonGia.ToString();
                exSheet.Range["D" + (row).ToString()].Value = item.SoLuong.ToString();
                exSheet.Range["E" + (row).ToString()].Value = item.ThanhTien.ToString() + " đồng";
                exSheet.Range["B" + (row).ToString()].Cells.HorizontalAlignment =
                exSheet.Range["E" + (row).ToString()].Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            }
            row += 2;
            exSheet.Range["E" + row.ToString()].Value = "Tổng: " + txtGoiMonTongTien.Text;
            exSheet.Range["E" + (row + 1).ToString()].Value = "User: " + taiKhoanLogin.UserName;
            exSheet.Name = "HDB";
            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002|*.xls|Excel Workbook|*xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }

            exApp.Quit();

            curID = "";
            LoadBanAn();
            curBanAnID = "";
            ShowChiTietDat(curBanAnID);

            MessageBox.Show("Thanh Toán thành công !");
        }
        /*Xong Code gọi món*/

        void LoadCBNL()
        {
            cbNHMaNL.Items.Clear();
            List<string> list = nguyenLieuBUS.GetListMa();
            foreach (var item in list)
            {
                cbNHMaNL.Items.Add(item);
            }
        }
        void LoadCBPN()
        {
            cbNHMaPN.Items.Clear();
            List<string> list = phieuNhapBUS.GetListMa();
            foreach (var item in list)
            {
                cbNHMaPN.Items.Add(item);
            }
        }

        void LoadCBNCC()
        {
            cbNHMaNCC.Items.Clear();
            List<string> list = nhaCungCapBUS.GetListMa();
            foreach (var item in list)
            {
                cbNHMaNCC.Items.Add(item);
            }
        }
        private void btnNHThem_Click(object sender, EventArgs e)
        {
            if (cbNHMaPN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã phiếu nhập");
                return;
            }
            if (cbNHMaNL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nguyên liệu");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            if (txtNHDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }
            if (!chiTietPhieuNhapBUS.InsertChiTietPhieuNhap(cbNHMaPN.SelectedItem.ToString(), cbNLLoaiNL.SelectedItem.ToString(), Convert.ToDecimal(txtNHDG.Text), Convert.ToInt32(txtNHDG.Text), 0))
            {
                MessageBox.Show("Không thể thêm nguyên liệu này");
                return;
            }
            LoadChiTietPN(cbNHMaPN.SelectedItem.ToString());
            txtNHDG.Text = txtSoLuong.Text = "";
        }

        private void cbNHMaPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNHMaPN.SelectedItem == null)
            {
                return;
            }
            PhieuNhapDTO a = phieuNhapBUS.GetPhieuNhapByMa(cbNHMaPN.SelectedItem.ToString());
            if (a == null) return;
            txtNHTongTien.Text = a.TongTien.ToString();
            txtUser.Text = a.UserName;
            dtpNgayLap.Value = a.NgayLap;
            LoadCBPN();
            listCTPN.DataSource = chiTietPhieuNhapBUS.GetListChiTietPhieuNhap(cbNHMaPN.SelectedItem.ToString()); 
        }

        private void cbNHMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCungCapDTO a = nhaCungCapBUS.GetNhaCungCapByMa(cbNHMaNCC.SelectedItem.ToString());
            if (a == null) return;
            txtDiaChi.Text = a.DiaChi;
            txtTenNCC.Text = a.TenNCC;
            txtSDT.Text = a.SDT;
        }

        private void cbNHMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            NguyenLieuDTO a = nguyenLieuBUS.GetNguyenLieuByMa(cbNHMaNL.SelectedItem.ToString());
            if (a == null) return;
            txtTenNL.Text = a.TenNL;
            txtNHDVT.Text = a.DVT;
        }
        void LoadChiTietPN(string maPN="")
        {
            listCTPN.DataSource = chiTietPhieuNhapBUS.GetListChiTietPhieuNhap(maPN);
        }

        void resetNhapHang()
        {
            txtSoLuong.Text = txtNHDG.Text = "";
            listCTPN = null;
        }
        private void btnNHHuyPN_Click(object sender, EventArgs e)
        {
            if (cbNHMaPN.SelectedIndex == -1) 
            {
                MessageBox.Show("Chưa chọn phiếu nhập !");
                return;
            }
            resetNhapHang();
            if (!phieuNhapBUS.DeletePhieuNhap(cbNHMaPN.SelectedItem.ToString()))
            {
                MessageBox.Show("Xóa không thành công");
                return;
            }
            MessageBox.Show("Xóa thành công !");
            txtUser.Text = "";
            dtpNgayLap.Value = DateTime.Now;
            cbNHMaPN.SelectedIndex = -1;

        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            string t = phieuNhapBUS.GetDistinctID();
            if (cbNHMaNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nhà cung cấp");
                return;
            }
            if (!phieuNhapBUS.InsertPhieuNhap(t, DateTime.Now, 0, cbNHMaNCC.SelectedItem.ToString(), taiKhoanLogin.UserName))
            {
                MessageBox.Show("Không thể sinh phiếu");
                return;
            }
            cbNHMaPN.Items.Add(t);
            cbNHMaPN.SelectedText = t;
            LoadChiTietPN(t);
        }

        private void btnNHXoa_Click(object sender, EventArgs e)
        {
            if (cbNHMaPN.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã phiếu nhập");
                return;
            }
            if (cbNHMaNL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã nguyên liệu");
                return;
            }
            if (!chiTietPhieuNhapBUS.DeleteChiTietPhieuNhap(cbNHMaPN.SelectedItem.ToString(), cbNHMaNL.SelectedItem.ToString()))
            {
                MessageBox.Show("Không thể xóa sản phẩm!");
                return;
            }
            MessageBox.Show("Xóa sản phẩm thành công!");
            LoadChiTietPN(cbNHMaPN.SelectedItem.ToString());
        }
    }
}
