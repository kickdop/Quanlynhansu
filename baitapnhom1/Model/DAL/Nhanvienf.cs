using baitapnhom1.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapnhom1.Model.DAL
{
    class Nhanvienf
    {
        Databasecontext mydatabase = null;
        public Nhanvienf()
        {
            mydatabase = new Databasecontext();
        }

        public Nhanvien tim(string id)
        {
            int  ID = Convert.ToInt32(id.Trim());
            return mydatabase.Nhanviens.Find(ID);
        }
        public IQueryable<Nhanvien> timtatca(string find)
        {
            return mydatabase.Nhanviens.Where(p => p.Name1.Contains(find));
        }
        public IQueryable<Nhanvien> Danhsach()
        {
            return mydatabase.Nhanviens;
        }

        public IQueryable<Nhanvien> theophongban(string id)
        {

            int _id = Convert.ToInt32(id);
            return mydatabase.Nhanviens.Where(p => p.PhongbanID == _id);

        }

        public bool them(Nhanvien them)
        {
            Nhanvien temp = mydatabase.Nhanviens.Where(p => p.MaNV == them.MaNV).SingleOrDefault();
            if (temp != null) return false;

            mydatabase.Nhanviens.Add(them);
            mydatabase.SaveChanges();

            return true;
        }

        public bool xoa(string id)
        {
            int _id = Convert.ToInt32(id);
            Nhanvien temp = mydatabase.Nhanviens.Find(_id);
            if (temp == null) return false;

            mydatabase.Nhanviens.Remove(temp);
            mydatabase.SaveChanges();
            return true;

        }

        public bool edit(Nhanvien sua)
        {
            Nhanvien temp = mydatabase.Nhanviens.Where(p => p.id == sua.id).SingleOrDefault();
            if (temp == null) return false;

            temp.Bangcap = sua.Bangcap;
            temp.ChucvuID = sua.ChucvuID;
            temp.CMT = sua.CMT;
            temp.DOB = sua.DOB;
            temp.Gioitinh = sua.Gioitinh;
            temp.MaNV = sua.MaNV;
            temp.Name1 = sua.Name1;
            temp.Ngayvaolam = sua.Ngayvaolam;
            temp.Noiohiennay = sua.Noiohiennay;
            temp.PhongbanID = sua.PhongbanID;
            temp.SDT = sua.SDT;
            


            mydatabase.SaveChanges();
            return true;
        }

    }
}
