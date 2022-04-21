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
    public partial class GiaoDienChinh : Form
    {
        private String TaiKhoan;
        private String MatKhau;
        public void Tn() { }
        public void Tn(String tk, String Mk)
        {
            this.TaiKhoan = tk;
            this.MatKhau = Mk;
        }
        public int NhanVien()
        {
            int c = 0;
            for (int i = 0; i <= 1; i++)
            {
                String query = " SELECT [MaNV],[PhanQuyen]FROM dbo.[BNHANVIEN] WHERE [MaNV]='" + TaiKhoan + "' AND PhanQuyen ='" + i + "'";
                DataTable a = Dataprovide.Instance.TruyVan(query);
                if (i == 0)
                {
                    c = a.Rows.Count;
                }
                else if (i == 1)
                {
                    c = a.Rows.Count;
                }
                else c = -1;

            }
            return c;
        }


        public GiaoDienChinh()
        {
            InitializeComponent();

        }

        private void QlThucUong_Click(object sender, EventArgs e)
        {
            if (NhanVien() > 0)
            {
                QLTHUCUONG qlthucuong = new QLTHUCUONG();
                qlthucuong.ShowDialog();
                this.Hide();
            }
            this.Show();
        }

        private void QLNv_Click(object sender, EventArgs e)
        {
            if (NhanVien() > 0)
            {
                QlNhanVien QlNb = new QlNhanVien();
                QlNb.ShowDialog();
                this.Hide();
            }
            this.Show();
        }

        private void BanHang_Click(object sender, EventArgs e)
        {

            if (NhanVien() == 0 || NhanVien() > 0)
            {
                BanHang banhang = new BanHang();
                banhang.ShowDialog();
                this.Hide();
            }
            this.Show();
        }

        private void DatBan_Click(object sender, EventArgs e)
        {
            if (NhanVien() == 0 || NhanVien() > 0)
            {
                DatBan banhang = new DatBan();
                banhang.ShowDialog();
                this.Hide();
            }
            this.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("BAN CO MUON DANG XUAT KHONG?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                formLogin flogin = new formLogin();
                flogin.ShowDialog();
                this.Close();
            }

        }


    }

}

