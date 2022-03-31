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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        //chỉ cho phép nhập số nguyên
        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn chỉ được nhập số nguyên");
                e.Handled = true;
            } 
        }
    }
}
