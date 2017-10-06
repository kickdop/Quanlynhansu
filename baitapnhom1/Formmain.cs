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


    }
}
