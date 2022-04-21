using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE
{
    public partial class QLTHUCUONG : Form
    {
        public QLTHUCUONG()
        {
            InitializeComponent();
            loadlistfood();
            loadlistLoaiHang();
        }
        void loadlistfood()
        {
            String a = "  select [MAHH] , [TENHH] , BHangHoa.MALH , [GIASP] ,  BLoaiHang.TENLH FROM [BHangHoa] ,BLoaiHang WHERE [BHangHoa].MALH=BLoaiHang.MALH";
            DataTable shownfood = Dataprovide.Instance.TruyVan(a);
            dataGridThucUong.DataSource = shownfood;
        }

        void loadlistLoaiHang()
        {
            String a = "SELECT [MALH] ,[TENLH]from BLoaiHang";
            DataTable shownLoaiHang = Dataprovide.Instance.TruyVan(a);
            dataGridViewLOAIHANG.DataSource = shownLoaiHang;
        }
        // tim kiem
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            String timkiem = txtTimKiem.Text;
            if (e.KeyChar == (char)13)
            {
                if (timkiem == "")
                {
                    loadlistLoaiHang();
                }
                DataTable shownLoaiHang = Dataprovide.Instance.TruyVan("SELECT [MALH] ,[TENLH] from BLoaiHang where [MALH] like '%" + timkiem + "%' or [TENLH] like '%" + timkiem + "%'");
                dataGridViewLOAIHANG.DataSource = shownLoaiHang;
            }
        }
        private void txtTimKiemFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            String timkiem = txtTimKiemFood.Text;
            if (timkiem == "")
            {
                loadlistfood();
            }
            else
            if (e.KeyChar == (char)13)
            {

                DataTable shownfood = Dataprovide.Instance.TruyVan("  select [MAHH] , [TENHH] , BHangHoa.MALH , [GIASP] ,  BLoaiHang.TENLH FROM [BHangHoa] , BLoaiHang where [TENHH] like '%" + timkiem + "%' and BLoaiHang.MALH =BHangHoa.MALH or [MAHH] like '%" + timkiem + "%'and BLoaiHang.MALH =BHangHoa.MALH");
                dataGridThucUong.DataSource = shownfood;
            }
        }
        #region them sua xoa


        // Ham Xu ly khi Bam click
        private void buttonthem_Click(object sender, EventArgs e)
        {
            String MaHH = textBoxMaHH.Text;
            String TENHH = textBox2.Text;
            String MALH = textBox3.Text;
            int GIASP = (int)GiaSpNM.Value;
            if (MALH == "" || MaHH == "" || TENHH == "" || GIASP == 0)
            {
                MessageBox.Show("Thông tin Trống");
            }
            else if (KiemTraLH(MALH) == false)
            {
                MessageBox.Show("MALH Chưa tồn tại vui lòng thêm phần loại hàng");
            }
            else if (KiemTraMH(MaHH) == false)
            {
                if (ThemFood(MaHH, TENHH, MALH, GIASP))
                {
                    MessageBox.Show("Thêm món Thành Công");
                    loadlistfood();
                }
                else MessageBox.Show("Thêm món Không Thành Công");
            }
            else MessageBox.Show("Mã HH này Đã Tồn Tại");
            loadlistLoaiHang();
        }
        private void ThemLoaiHang_Click(object sender, EventArgs e)
        {

            String MALH = textBoxLoaiHang.Text;
            String TENLH=textBoxMaLoaiHang.Text;
 
            if (KiemTraLH(MALH) == true || MALH == "" || TENLH == "")
            {
                MessageBox.Show("MALH  tồn tại hoặc\n Thông tin Trống");
            }
            else if (KiemTraLH(MALH) == false)
            {
                if (ThemLFood(MALH, TENLH))
                {
                    MessageBox.Show("Thêm Thành Công");
                    loadlistLoaiHang();
                }
                else
                {
                    MessageBox.Show("Thêm không Thành Công");
                    loadlistLoaiHang();
                }
            }
            else
                MessageBox.Show("Mã LH này Đã Tồn Tại");
                   loadlistLoaiHang();

        }
        private void SuaLoaiHang_Click(object sender, EventArgs e)
        {
            String MALH = textBoxMaLoaiHang.Text;
            String TENLH = textBoxLoaiHang.Text;
            String DieuKien = textDKLOAIHANG.Text;
            if (TENLH == "" || MALH == "" || DieuKien == "")
            {
                MessageBox.Show("Thông tin Trống");
            }
            else
            if (UPDATELFood(MALH, TENLH, DieuKien))
            {
                MessageBox.Show("Sửa Thành Công");
                loadlistLoaiHang();
            }
            else MessageBox.Show("Sửa Không Thành Công");
        }
        private void buttonsua_Click_1(object sender, EventArgs e)
        {
            String MaHH = textBoxMaHH.Text;
            String TENHH = textBox2.Text;
            String MALH = textBox3.Text;
            int GIASP = (int)GiaSpNM.Value;
            String DieuKien = textDKHH.Text;
            if (MaHH == "" || TENHH == "" || GIASP == 0 || MALH == "")
            {
                MessageBox.Show("Thông tin Trống");
            }
            else
            if (UPDATEFood(TENHH, MaHH, MALH, GIASP, DieuKien))
            {
                MessageBox.Show("Sửa Thành Công");
                loadlistfood();
            }
            else MessageBox.Show("Sửa  Không Thành Công");
        }
        private void buttonxoa_Click(object sender, EventArgs e)
        {
            String DieuKien = textDKHH.Text;
            if (DieuKien == "")
            {
                MessageBox.Show("Thông tin Trống");
            }
            else
             if (deleteFood(DieuKien))
            {
                MessageBox.Show("Xóa Thành Công");
                loadlistfood();
            }
            else MessageBox.Show("Xóa Không Thành Công");
        }
        private void XoaLoaiHang_Click(object sender, EventArgs e)
        {
            String DieuKien = textDKLOAIHANG.Text;
            if (DieuKien == "")
            {
                MessageBox.Show("Thông tin Trống");
            }
            if (KiemTraRangBuoc(DieuKien) == false && deleteLFood(DieuKien))
            {
                MessageBox.Show("Xóa Thành Công");
                loadlistLoaiHang();
            }
            else MessageBox.Show("Xóa Không Thành Công");

        }
        // Kiem Tra Cac  TextBox Co Dong Khong 
        public bool KiemTraLH(String MALH) // kiem tra xem ma lh co toi tai chua
        {
            String query = string.Format("SELECT  BLoaiHang.MALH FROM BLoaiHang where BLoaiHang.MALH = '{0}'", MALH);
            DataTable a = Dataprovide.Instance.TruyVan(query);
            return a.Rows.Count > 0;
        }
        public bool KiemTraMH(String MAHH) // kiem tra xem ma lh co toi tai chua
        {
            String query = string.Format("SELECT  BHangHoa.MAHH FROM BHangHoa where BHangHoa.MAHH = '{0}'", MAHH);
            DataTable a = Dataprovide.Instance.TruyVan(query);
            return a.Rows.Count > 0;
        }
        public bool KiemTraRangBuoc(String MALH)
        {
            String query = string.Format("SELECT * FROM BHangHoa inner join BLoaiHang on BHangHoa.MALH = BLoaiHang.MALH where BHangHoa.MALH = '{0}'", MALH);
            DataTable a = Dataprovide.Instance.TruyVan(query);
            return a.Rows.Count > 0;
        }
        // Ham truy van vao sql de su ly
        public bool ThemFood(String MAHH, String TENHH, String MALH, int GIASP)
        {
            String a = string.Format("INSERT INTO dbo.BHangHoa(MAHH,TENHH,MALH,GIASP) VALUES (N'{0}',N'{1}','{2}',{3})", MAHH, TENHH, MALH, GIASP);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool ThemLFood(String MALH, String TENLH )
        {
            String a = string.Format("INSERT INTO	dbo.BLoaiHang (MALH,TENLH) VALUES (N'{0}', N'{1}')", MALH, TENLH);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool UPDATEFood(String TENLH, String MAHH, String MALH, int GIASP, String DieuKien)
        {
            String a = string.Format("update BHangHoa set  TENHH =N'{0}' ,MAHH =N'{1}' ,MALH =N'{4}',GIASP = {2} where MAHH = '{3}'", TENLH, MAHH, GIASP, DieuKien, MALH);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;

        }
        public bool UPDATELFood(String TENLH, String MALH, String DieuKien)
        {
            String a = string.Format("update BLoaiHang set MALH =N'{0}' , TENLH = N'{1}'  where MALH= '{2}'", MALH, TENLH, DieuKien);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool deleteFood(String MAHH)
        {
            String a = string.Format("delete from BHangHoa  where MAHH = N'{0}'", MAHH);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }
        public bool deleteLFood(String MALH)
        {
            String a = string.Format("delete from BLoaiHang   where MALH = N'{0}'", MALH);
            int result = Dataprovide.Instance.ExecuteNonQuery(a);
            return result > 0;
        }

        //bidding du lieu
        private void dataGridViewnhanvien_Click(object sender, EventArgs e)
        {
            GiaSpNM.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBoxMaHH.DataBindings.Clear();
            textDKHH.DataBindings.Clear();

            GiaSpNM.DataBindings.Add("Text", dataGridThucUong.DataSource, ("GIASP"));
            textBox3.DataBindings.Add("Text", dataGridThucUong.DataSource, ("MALH"));
            textBox2.DataBindings.Add("Text", dataGridThucUong.DataSource, ("TENHH"));
            textBoxMaHH.DataBindings.Add("Text", dataGridThucUong.DataSource, ("MAHH"));
            textDKHH.DataBindings.Add("Text", dataGridThucUong.DataSource, ("MAHH"));
        }
        private void dataGridViewLOAIHANG_Click(object sender, EventArgs e)
        {
            textBoxMaLoaiHang.DataBindings.Clear();
            textBoxLoaiHang.DataBindings.Clear();
            textDKLOAIHANG.DataBindings.Clear();
            textBoxMaLoaiHang.DataBindings.Add("Text", dataGridViewLOAIHANG.DataSource, ("TENLH"));
            textBoxLoaiHang.DataBindings.Add("Text", dataGridViewLOAIHANG.DataSource, ("MaLH"));
            textDKLOAIHANG.DataBindings.Add("Text", dataGridViewLOAIHANG.DataSource, ("MaLH"));

        }



        //tim kiem



        #endregion


        //private void dataGridViewnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //        if (e.RowIndex >= 0)
        //        {
        //            //Lưu lại dòng dữ liệu vừa kích chọn
        //            DataGridViewRow row = this.dataGridViewnhanvien.Rows[e.RowIndex];
        //            //Đưa dữ liệu vào textbox
        //            textBoxMaHH.Text = row.Cells[0].Value.ToString();
        //            textBox2.Text = row.Cells[3].Value.ToString();
        //            textBox3.Text = row.Cells[1].Value.ToString();
        //            //Không cho phép sửa trường STT
        //        }

    }
}


