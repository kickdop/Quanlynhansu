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
    public partial class Formmain : Form
    {
       
        
        public Formmain()
        {
            InitializeComponent();
            loadgrv();
            loadcb();


        }
        public void loadcb()
        {


            cblocnv.DataSource = new phongbanf().Danhsach().ToList();
            cblocnv.DisplayMember = "Name";
            cblocnv.ValueMember = "ID";


        }
        public void loadgrv()
        {
            grvnhanvien.DataSource = new Nhanvienf().Danhsach().ToList();


            for (int i = 0; i < grvnhanvien.RowCount; i++)
            {

                if (grvnhanvien.Rows[i].Cells[4].Value.ToString().Trim() == "1")
                    grvnhanvien.Rows[i].Cells[4].Value = "Nam";
                else
                     if (grvnhanvien.Rows[i].Cells[4].Value.ToString().Trim() == "0")
                    grvnhanvien.Rows[i].Cells[4].Value = "Nữ";
            }
        }

        private void themnv_Click(object sender, EventArgs e)
        {

            Formthemnv frthemnv = new Formthemnv();
            frthemnv.Show();

        }

        private void suanv_Click(object sender, EventArgs e)
        {
            string id = grvnhanvien.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            Formsuanv frthemnv = new Formsuanv(id);

            frthemnv.Show();



        }
        private void xoanv_Click(object sender, EventArgs e)
        {
            string id = grvnhanvien.SelectedCells[0].OwningRow.Cells["id"].Value.ToString();
            if (MessageBox.Show("bạn có muốn xóa không ?", "mesage", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Nhanvienf datanhanvien = new Nhanvienf();
                datanhanvien.xoa(id);
                loadgrv();
            }


        }

        private void huongdan_Click(object sender, EventArgs e)
        {

        }

        private void timkiemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Formtimkiem frthemnv = new Formtimkiem();
            frthemnv.Show();

        }



    }
}
