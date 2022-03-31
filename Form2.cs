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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            fr_login add = new fr_login();
            add.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 add = new Form4();
            add.Show();
        }

        private void tsmnLienhe_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 add = new Form5();
            add.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 add = new Form6();
            add.Show();
        }

        private void quêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 add = new Form7();
            add.Show();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 add = new Form8();
            add.Show();
        }

        private void khuNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 add = new Form9();
            add.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 add = new Form10();
            add.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 add = new Form11();
            add.Show();
        }

        private void quảnLýThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 add = new Form12();
            add.Show();
        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form13 add = new Form13();
            add.Show();
        }

        private void chiPhíPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 add = new Form14();
            add.Show();
        }

        bool hp;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hp)
            {
                if ((lblchu.Left + lblchu.Width) < this.Width)
                    lblchu.Left = lblchu.Left + 5;
                else
                    hp = false;
            }
            else
            {
                if (lblchu.Left > 0)
                    lblchu.Left = lblchu.Left - 5;
                else
                    hp = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hp = true;
            timer1.Start();
        }
    }
}
