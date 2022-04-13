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
        Database dt = new Database();
       
        public fr_login()
        {
            InitializeComponent();
        }
        void xoatrang()
        {
            txtTK.Text = "";
            txtMK.Text = "";
        }

       
        private void btnDN_Click_1(object sender, EventArgs e)
        {
             string pass= FunctionMD5.Create_md5(txtTK.Text);
             DataTable data= dt.DataReader("select * from TaiKhoan where username=N'" + txtTK.Text.Trim() + "' and password=N'" + pass + "'");
            if(data.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                Fr_Main add = new Fr_Main();
                add.Show();
                xoatrang();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản chưa chính xác");
                txtTK.Focus();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMK.UseSystemPasswordChar = true;

            dt.OpenConnect();
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
                dt.CloseConnect();
                Application.Exit();
        }


    }
}   

