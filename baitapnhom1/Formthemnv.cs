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
using baitapnhom1.Model.Entity;


namespace baitapnhom1
{
    public partial class Formthemnv : Form
    {
        chucvuf datachucvu = new chucvuf();
        phongbanf dataphongban = new phongbanf();
        Nhanvienf datanhanvien = new Nhanvienf();
        public Formthemnv()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            nam.Checked = true;
            cbchucvu.DataSource = datachucvu.Danhsach().ToList();
            cbchucvu.DisplayMember = "Name";
            cbchucvu.ValueMember = "ID";

            cbphongban.DataSource = dataphongban.Danhsach().ToList();
            cbphongban.DisplayMember = "Name";
            cbphongban.ValueMember = "ID";
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (manv.Text == "" || name.Text == "" || cmt.Text == "") MessageBox.Show("Tên nhân viên, mã nhân viên, cmt không đc để trống", "Cảnh báo");
            else
            {
<<<<<<< HEAD
               
=======

>>>>>>> 86a0d5f6490c2e584f84220550a732a8de53442f
                Nhanvien a = new Nhanvien();
                a.MaNV = manv.Text;
                a.Name1 = name.Text;
                a.DOB = Convert.ToDateTime(ngaysinh.Text);
<<<<<<< HEAD
                a.Gioitinh = (nam.Checked == true) ? "1" :"0";
=======
                a.Gioitinh = (nam.Checked == true) ? "1" : "0";
>>>>>>> 86a0d5f6490c2e584f84220550a732a8de53442f
                a.Noiohiennay = noio.Text;
                a.Ngayvaolam = Convert.ToDateTime(ngayvaolam.Text);
                a.Bangcap = bangcap.Text;
                a.SDT = sdt.Text;
                a.CMT = cmt.Text;
                a.ChucvuID = Convert.ToInt32(cbchucvu.SelectedValue.ToString());
                a.PhongbanID = Convert.ToInt32(cbphongban.SelectedValue.ToString());
<<<<<<< HEAD
                try {
=======
                try
                {
>>>>>>> 86a0d5f6490c2e584f84220550a732a8de53442f
                    datanhanvien.them(a);
                    MessageBox.Show("Thêm mới thành công", "Message");
                    manv.Text = "";
                    name.Text = "";
<<<<<<< HEAD
                    nam.Checked=true;
=======
                    nam.Checked = true;
>>>>>>> 86a0d5f6490c2e584f84220550a732a8de53442f
                    noio.Text = "";
                    bangcap.Text = "";
                    sdt.Text = "";
                    cmt.Text = "";
<<<<<<< HEAD
                    
=======

>>>>>>> 86a0d5f6490c2e584f84220550a732a8de53442f
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString(), "ERROR");
                }



            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
