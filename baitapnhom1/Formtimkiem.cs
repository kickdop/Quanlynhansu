using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitapnhom1.Model.Entity;
using baitapnhom1.Model.DAL;

namespace baitapnhom1
{
    public partial class Formtimkiem : Form
    {
        public Formtimkiem()
        {
            InitializeComponent();
            loadgrv();
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

        private void tatca_Click(object sender, EventArgs e)
        {
            string find = textfind.Text.Trim();

            List<Nhanvien> aaa = new Nhanvienf().timtatca(find).ToList();

            grvnhanvien.DataSource = aaa;
            for (int i = 0; i < grvnhanvien.RowCount; i++)
            {

                if (grvnhanvien.Rows[i].Cells[4].Value.ToString().Trim() == "1")
                    grvnhanvien.Rows[i].Cells[4].Value = "Nam";
                else
                     if (grvnhanvien.Rows[i].Cells[4].Value.ToString().Trim() == "0")
                    grvnhanvien.Rows[i].Cells[4].Value = "Nữ";
            }
        }
    }
}
