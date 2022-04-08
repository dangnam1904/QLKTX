using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class fr_login : Form
    {
        List<TaiKhoan> listtaikhoan = Danhsachtaikhoan.Instance.ListTaiKhoan;
        public fr_login()
        {
            InitializeComponent();
        }
        void xoatrang()
        {
            txtTK.Text = "";
            txtMK.Text = "";
        }

        bool kiemtradangnhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listtaikhoan.Count; i++)
            {
                if (tentaikhoan == listtaikhoan[i].TenTaiKhoan && matkhau == listtaikhoan[i].MatKhau)
                    return true;
            }
            return false;
        }
        private void btnDN_Click_1(object sender, EventArgs e)
        {
            if (kiemtradangnhap(txtTK.Text, txtMK.Text))
            {
                Fr_Main add = new Fr_Main();
                add.Show();
                xoatrang();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "Lỗi");
                txtTK.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }


    }
}   

