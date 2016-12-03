using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Thêm thư viện này vào để sử dụng CoffeeCSDLEntities
using TinhTien.Data;

namespace TinhTien
{
    public partial class frmTinhTien : Form
    {
        public frmTinhTien()
        {
            InitializeComponent();
        }

        private void frmTinhTien_Load(object sender, EventArgs e)
        {
            Load_Data_NhanVien();
            Load_Data_KhachHang();
            Load_Data_SanPham();
        }

        /// <summary>
        /// Truyền dữ liệu table NHANVIEN vào cbx
        /// </summary>
        private void Load_Data_NhanVien()
        {
            using (CoffeeCSDLEntities _contextNhanVien = new CoffeeCSDLEntities())
            {
                List<NHANVIEN> _list_nhanvien = _contextNhanVien.NHANVIEN.ToList();
                _list_nhanvien.Insert(0, new NHANVIEN() { MaNV = -1, TenNV = "--- Chọn Tên Nhân Viên ---" });
                cbxNhanVien.DataSource = _list_nhanvien;
                cbxNhanVien.ValueMember = "MaNV";
                cbxNhanVien.DisplayMember = "TenNV";
            }

        }

        /// <summary>
        /// Truyền dữ liệu table KHACHHANG vào cbx
        /// </summary>
        private void Load_Data_KhachHang()
        {
            using (CoffeeCSDLEntities _contetxKhachHang = new CoffeeCSDLEntities())
            {
                List<KHACHHANG> _list_khachhang = _contetxKhachHang.KHACHHANG.ToList();
                _list_khachhang.Insert(0, new KHACHHANG() { MaKH = -1, TenKH = "--- Chọn Tên Khách Hàng ---" });
                cbxTenKH.DataSource = _list_khachhang;
                cbxTenKH.DisplayMember = "TenKH";

            }

        }
        //lấy dữ liệu cho MaKH
        private void cbxTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenKH.SelectedIndex != 0)
            {
                KHACHHANG _value = (KHACHHANG)cbxTenKH.SelectedItem;
                if (_value != null)
                {
                    txtMaKH.Text = _value.MaKH.ToString();
                }
            }
        }

        /// <summary>
        /// Truyền dữ liệu table SANPHAM vào cbx
        /// </summary>
        private void Load_Data_SanPham()
        {
            using (CoffeeCSDLEntities _contextSanPham = new CoffeeCSDLEntities())
            {
                List<SANPHAM> _list_sanpham = _contextSanPham.SANPHAM.ToList();
                _list_sanpham.Insert(0, new SANPHAM() { MaSP = -1, TenSP = "--- Chọn Tên Sản Phẩm ---" });
                cbxTenSP.DataSource = _list_sanpham;
                cbxTenSP.DisplayMember = "TenSP";
            }
        }
        //lấy dữ liệu cho MaSP
        private void cbxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTenSP.SelectedIndex != 0)
            {
                SANPHAM _value = (SANPHAM)cbxTenSP.SelectedItem;
                if (_value != null)
                {
                    txtMaSP.Text = _value.MaSP.ToString();
                }
            }
        }

        //STT tăng tự động
        private int _stt_grid = 0;

        //Thêm dữ liệu vào DataGridView
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string _ten_sp = cbxTenSP.SelectedText;
            int _so_luong = Convert.ToInt32(nmrSL.Value);
            SANPHAM _value_sp = null;
            if (cbxTenSP.SelectedIndex != 0)
            {
                _value_sp = (SANPHAM)cbxTenSP.SelectedItem;
            }
            _stt_grid++;
            string[] _row = new string[] { _stt_grid.ToString(), txtMaSP.Text, (_value_sp != null ? _value_sp.TenSP : string.Empty), _so_luong.ToString(), _value_sp.DonGia.ToString()};
            dgvTinhTien.Rows.Add(_row);
            TinhTien();
        }


        //Sửa dữ liệu (số lượng) trong Datagridview
        private void btnSua_Click(object sender, EventArgs e)
        {
            string _ma_sp = txtMaSP.Text;
            foreach(DataGridViewRow row in dgvTinhTien.Rows)
            {
                if(row.Cells[1].Value != null)
                {
                    string _ma_sp_dgv = row.Cells[1].Value.ToString(); //lấy mã sản phẩms
                    if(_ma_sp==_ma_sp_dgv)
                    {
                        row.Cells[3].Value = nmrSL.Value;
                    }
                }
            }
            TinhTien();
        }

        //Xóa trong Datagridview
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTinhTien.CurrentCell.RowIndex;
            try
            {
                dgvTinhTien.Rows.RemoveAt(rowIndex);
            }
            catch
            {
                MessageBox.Show("Không còn gì để xóa");
            }
            TinhTien();
        }


        //Tự động tính tiền mỗi khi thêm hoặc sửa sản phẩm
        private void TinhTien()
        {
            double _tong_tien = 0;
            foreach(DataGridViewRow row in dgvTinhTien.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    int _so_luong = Convert.ToInt32(row.Cells[3].Value.ToString());
                    double _tien = 0;
                    string _ma_sp_dgv = row.Cells[1].Value.ToString(); //lấy mã sản phẩm
                    //lấy tiền từ CSDL
                    using (CoffeeCSDLEntities _contextSanPham = new CoffeeCSDLEntities())
                    {
                        SANPHAM _value_sp = _contextSanPham.SANPHAM.Where(x => x.MaSP.ToString() == _ma_sp_dgv).FirstOrDefault();
                        if(_value_sp !=null)
                        {
                            _tien = _so_luong * _value_sp.DonGia.Value;
                        }
                        _tong_tien += _tien;
                    }
                }
                txtTongTien.Text = Convert.ToString(_tong_tien);
            }
        }

        //Click vào datagridview cbx và nmr tự động cập nhật
        private void dgvTinhTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int _row = e.RowIndex;
            string _ten_sp = dgvTinhTien.Rows[_row].Cells[2].Value.ToString();
            //chọn lại cbx và nmr
            cbxTenSP.Text = _ten_sp;
            nmrSL.Value = Convert.ToDecimal(dgvTinhTien.Rows[_row].Cells[3].Value.ToString());

        }
    }
}
