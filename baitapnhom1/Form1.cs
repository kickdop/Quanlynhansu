using baitapnhom1.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitapnhom1.Model.DAL;

namespace baitapnhom1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void dangnhap_Click(object sender, EventArgs e)
        {
            Formmain frmmain = new Formmain();
            User temp = new User();
            temp.account = textBox1.Text.Trim();
            temp.password = textBox2.Text.Trim();
            bool ans = new Userf().login(temp);
            if (ans)
            {
                this.Hide();
                frmmain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Eror");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Confirm", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }


        }
    }
}
