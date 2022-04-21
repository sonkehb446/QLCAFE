using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace CAFE
{
    public partial class QlNhanVien : Form
    {
        public QlNhanVien()
        {
            InitializeComponent();
            loadlistNhanvien();
        }
        public void loadlistNhanvien()
        {
            DataTable shownhanvien = Dataprovide.Instance.TruyVan("EXEC hienThiDSNV");
            dataGridViewnhanvien.DataSource = shownhanvien;
        }
        public void BiddingDulieu()
        {
            textMaNV.DataBindings.Clear();
            textTenNV.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            cbChucVu.DataBindings.Clear();
            cbGioiTinh.DataBindings.Clear();
            cbQuyen.DataBindings.Clear();
            dateVao.DataBindings.Clear();


            textMaNV.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("MANV"));
            textTenNV.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("TenNV"));
            txtDiaChi.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("DiaChi"));
            txtSDT.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("SDT"));
            cbChucVu.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("ChucVu"));
            cbGioiTinh.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("GioiTinh"));
            cbQuyen.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("PhanQuyen"));
            dateVao.DataBindings.Add("Text", dataGridViewnhanvien.DataSource, ("NgayVaoLam"));
        }
        private void dataGridViewnhanvien_Click(object sender, EventArgs e)
        {
            BiddingDulieu();
        }
        public bool ThemNV(String MaNV, String TenNV, String DiaChi, String SDT, String ChucVu, String NgayVao, String GioiTinh, String Quyen)
        {

            String a = string.Format("INSERT INTO	dbo.BNHANVIEN (MaNV,TenNV,DiaChi,SDT,ChucVu,NgayVaoLam,GioiTinh,PhanQuyen ) VALUES ( N'{0}',N'{1}',N'{2}', {3},N'{4}','{5}', {6}, {7})", MaNV, TenNV, DiaChi, SDT, ChucVu, NgayVao, KTgioitinh(GioiTinh), KTQuyen(Quyen));
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool SuaNV(String MaNV, String TenNV, String DiaChi, String SDT, String ChucVu, String NgayVao, String GioiTinh, String Quyen)
        {
            String a = string.Format("update BNHANVIEN set  MaNV =N'{0}',TenNV=N'{1}',DiaChi=N'{2}',SDT='{3}',ChucVu='{4}',NgayVaoLam='{5}',GioiTinh='{6}',PhanQuyen='{7}' where MaNV = '{8}'", MaNV, TenNV, DiaChi, SDT, ChucVu, NgayVao, KTgioitinh(GioiTinh), KTQuyen(Quyen), MaNV);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool XoaNV(String MaNV)
        {

            String a = string.Format("delete from BNHANVIEN  where MaNV = N'{0}'", MaNV);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }

        public int KTgioitinh(String GioiTinh)
        {
            if (GioiTinh == "Male")
            {
                return 1;
            }
            else return 0;

        }
        public int KTQuyen(String Quyen)
        {
            if (Quyen == "Mức Quản lý")
            {
                return 1;
            }
            else return 0;
        }
        public bool KiemTraMaNV(String MaNV) // kiem tra xem ma lh co toi tai chua
        {
            String query = string.Format("SELECT * FROM BNHANVIEN where MaNV = '{0}'", MaNV);
            DataTable a = Dataprovide.Instance.TruyVan(query);
            return a.Rows.Count > 0;
        }

        private void buttonthem_Click_1(object sender, EventArgs e)
        {
            String MaNV = textMaNV.Text;
            String TenNV = textTenNV.Text;
            String DiaChi = txtDiaChi.Text;
            String SDT = txtSDT.Text;
            String NgayVao = dateVao.Value.ToString();
            String ChucVu = cbChucVu.Text;
            String Quyen = cbQuyen.Text;
            String GioiTinh = cbGioiTinh.Text;
            DialogResult dialogResult = MessageBox.Show("Đồng Ý Thay Đổi?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (MaNV == "" || NgayVao == "" || KiemTraMaNV(MaNV) == true)
            {
                MessageBox.Show("Thông tin Trống Hoặc Mã Nhân Viên đã tồn tại");
            }
            else if (dialogResult == DialogResult.Yes)
            {
                if (ThemNV(MaNV, TenNV, DiaChi, SDT, ChucVu, NgayVao, GioiTinh, Quyen))
                {
                    MessageBox.Show("Thêm Nhân viên Thành Công");
                    loadlistNhanvien();
                }
                else MessageBox.Show("Thêm Nhân viên không Thành Công");
            }
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {
            String MaNV = textMaNV.Text;
            String TenNV = textTenNV.Text;
            String DiaChi = txtDiaChi.Text;
            String SDT = txtSDT.Text;
            String NgayVao = dateVao.Value.ToString();
            String ChucVu = cbChucVu.Text;
            String Quyen = cbQuyen.Text;
            String GioiTinh = cbGioiTinh.Text;
            DialogResult dialogResult = MessageBox.Show("Đồng Ý Thay Đổi?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (MaNV == "" || NgayVao == "")
            {
                MessageBox.Show("Thông tin Trống Hoặc Mã Nhân Viên đã tồn tại");
            }
            else if (dialogResult == DialogResult.Yes)
            {
                if (SuaNV(MaNV, TenNV, DiaChi, SDT, ChucVu, NgayVao, GioiTinh, Quyen))
                {
                    MessageBox.Show("Sửa Nhân viên Thành Công");
                    loadlistNhanvien();
                }
                else MessageBox.Show("Sửa Nhân viên không Thành Công");
            }

        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Đồng Ý Thay Đổi?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            String MaNV = textMaNV.Text;
            if (dialogResult == DialogResult.Yes)
            {
                if (XoaNV(MaNV))
                {
                    MessageBox.Show("Xóa Nhân viên Thành Công");
                    loadlistNhanvien();
                }
                else MessageBox.Show("Xóa Nhân viên không Thành Công");
            }
            
        }



        private void BTTIMKIEM_Click(object sender, EventArgs e)
        {
            String timkiem = Timkiem.Text;
            if (timkiem == "")
            {
                loadlistNhanvien();
            }
            DataTable shownhanvien = Dataprovide.Instance.TruyVan("SELECT [MaNV] ,[TenNV] ,[DiaChi] ,[SDT] ,ChucVu, (CASE GioiTinh WHEN 1 THEN 'Male' WHEN 0 THEN 'Female' ELSE 'Unknown' END) as GioiTinh, (CASE PhanQuyen WHEN 1 THEN N'Mức Quản lý' WHEN 0 THEN N'Mức Nhân Viên' ELSE 'Unknown' END) as PhanQuyen ,[NgayVaoLam] FROM [dbo].[BNHANVIEN] where [TenNV] like  N'%" + timkiem + "%' or [DiaChi] like  N'%" + timkiem + "%' or [ChucVu] like N'%" + timkiem + "%'");
            dataGridViewnhanvien.DataSource = shownhanvien;
        }

        private void Reload1_Click(object sender, EventArgs e)
        {
            loadlistNhanvien();
        }

        private void txtXuatEXCEL_Click(object sender, EventArgs e)
        {
           if(dataGridViewnhanvien.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelapp = new Microsoft.Office.Interop.Excel.Application();
                xcelapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i< dataGridViewnhanvien.Columns.Count +1; i++)
                {
                    xcelapp.Cells[1, i] = dataGridViewnhanvien.Columns[i - 1].HeaderText;
                }

                for (int i =0; i < dataGridViewnhanvien.Rows.Count; i++)
                {
                    for (int j = 0; j< dataGridViewnhanvien.Columns.Count; j++)
                    {
                        if(dataGridViewnhanvien.Rows[i].Cells[j].Value != null)
                        {
                            xcelapp.Cells[i + 2, j + 1] = dataGridViewnhanvien.Rows[i].Cells[j].Value.ToString();
                        }
                        
                    }
                }
                xcelapp.Columns.AutoFit();
                xcelapp.Visible = true;
            }
        }
    }
}
