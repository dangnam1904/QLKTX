﻿using System;
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
    public partial class Form1 : Form
    {
        List<TaiKhoan> listtaikhoan = Danhsachtaikhoan.Instance.ListTaiKhoan;
        public Form1()
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
                Form2 add = new Form2();
                add.Show();
                xoatrang();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tên tài khoản không đúng", "Lỗi");
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
