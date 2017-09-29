using baitapnhom1.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapnhom1.Model.DAL
{
    class phongbanf
    {
        Databasecontext mydatabase = null;
        public phongbanf()
        {
            mydatabase = new Databasecontext();
        }

        public IQueryable<phongban> Danhsach()
        {
            return mydatabase.phongbans;
        }

        public bool them(phongban them)
        {
            phongban temp = mydatabase.phongbans.Where(p => p.Name == them.Name).SingleOrDefault();
            if (temp != null) return false;

            mydatabase.phongbans.Add(them);
            mydatabase.SaveChanges();

            return true;
        }

        public bool xoa(string id)
        {
            int _id = Convert.ToInt32(id);
            phongban temp = mydatabase.phongbans.Find(_id);
            if (temp == null) return false;

            mydatabase.phongbans.Remove(temp);
            mydatabase.SaveChanges();
            return true;

        }

        public bool edit(phongban sua)
        {
            phongban temp = mydatabase.phongbans.Where(p => p.ID == sua.ID).SingleOrDefault();
            if (temp == null) return false;

            temp.Name = sua.Name;
            mydatabase.SaveChanges();
            return true;
        }
    }
}
