using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baitapnhom1.Model.Entity;

namespace baitapnhom1.Model.DAL
{
    class chucvuf
    {
        Databasecontext mydatabase = null;
        public chucvuf()
        {
            mydatabase = new Databasecontext();
        }

        public IQueryable<chucvu> Danhsach()
        {
            return mydatabase.chucvus;
        }

        public bool them(chucvu them)
        {
            chucvu temp = mydatabase.chucvus.Where(p => p.Name == them.Name).SingleOrDefault();
            if (temp != null) return false;

            mydatabase.chucvus.Add(them);
            mydatabase.SaveChanges();

            return true;
        }

        public bool xoa(string id)
        {
            int _id = Convert.ToInt32(id);
            chucvu temp = mydatabase.chucvus.Find(_id);
            if (temp == null) return false;

            mydatabase.chucvus.Remove(temp);
            mydatabase.SaveChanges();
            return true;

        }

        public bool edit(chucvu sua)
        {
            chucvu temp = mydatabase.chucvus.Where(p => p.ID == sua.ID).SingleOrDefault();
            if (temp == null) return false;

            temp.Name = sua.Name;
            mydatabase.SaveChanges();
            return true;
        }

    }

}
