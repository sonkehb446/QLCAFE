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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void AccSon(object sender, EventArgs e)
        {
            String a = textBoxTK.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String tk = textBoxTK.Text;
            String mk = textBoxMK.Text;
          
            if (SLogin(tk, mk))
            {   
                GiaoDienChinh giaodien = new GiaoDienChinh();
                giaodien.Tn(tk, mk);
                MessageBox.Show("Đăng Nhập Thành Công");
                this.Hide();
                giaodien.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Sai Tai Khoan Mat Khau");
           
        }
        public String TenTaiKhoan()
        {
             return textBoxTK.Text;
        }
        bool SLogin(String username, String Pass)
        {
                String query = "SELECT [MaNV], [MatKhau],[PhanQuyen] FROM dbo.[BNHANVIEN] WHERE [MaNV] ='" + username + "' AND MatKhau ='" + Pass + "'";
                DataTable a = Dataprovide.Instance.TruyVan(query);
                return a.Rows.Count > 0;
        }
        private void checkBoxhidePass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxhidePass.Checked == true)
            {
                this.textBoxMK.UseSystemPasswordChar = false;
            } else this.textBoxMK.UseSystemPasswordChar = true;

        }
    }
}
