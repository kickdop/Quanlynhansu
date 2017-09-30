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
    public partial class Formsuanv : Form
    {
        chucvuf datachucvu = new chucvuf();
        phongbanf dataphongban = new phongbanf();
        Nhanvienf datanhanvien = new Nhanvienf();
        string _id;
        Nhanvien a;
        public Formsuanv(string id)
        {
            InitializeComponent();
            _id = id;
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

          a = datanhanvien.tim(_id);

            manv.Text = a.MaNV ;
            name.Text= a.Name1 ;
             ngaysinh.Text=( a.DOB==null)?"":a.DOB.ToString();
            if (a.Gioitinh.Trim() == "1") nam.Checked = true;
            else Nu.Checked = true;
            noio.Text = a.Noiohiennay ;
            ngayvaolam.Text =a.Ngayvaolam.ToString() ;
           bangcap.Text = a.Bangcap ;
            sdt.Text= a.SDT ;
             cmt.Text= a.CMT;
            cbchucvu.SelectedValue= a.ChucvuID;
            cbphongban.SelectedValue = a.PhongbanID;

        }

        private void them_Click(object sender, EventArgs e)
        {
            if (manv.Text == "" || name.Text == "" || cmt.Text == "") MessageBox.Show("Tên nhân viên, mã nhân viên, cmt không đc để trống", "Cảnh báo");
            else
            {

                
                a.MaNV = manv.Text;
                a.Name1 = name.Text;
                a.DOB = Convert.ToDateTime(ngaysinh.Text);
                a.Gioitinh = (nam.Checked == true) ? "1" : "0";
                a.Noiohiennay = noio.Text;
                a.Ngayvaolam = Convert.ToDateTime(ngayvaolam.Text);
                a.Bangcap = bangcap.Text;
                a.SDT = sdt.Text;
                a.CMT = cmt.Text;
                a.ChucvuID = Convert.ToInt32(cbchucvu.SelectedValue.ToString());
                a.PhongbanID = Convert.ToInt32(cbphongban.SelectedValue.ToString());
                try
                {
                    datanhanvien.edit(a);
                    MessageBox.Show("sua thành công", "Message");
                   

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
