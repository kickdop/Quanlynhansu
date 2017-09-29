using baitapnhom1.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapnhom1.Model.DAL
{
    class Userf
    {
        Databasecontext mydatabase = null;
        public Userf()
        {
            mydatabase = new Databasecontext();
        }

        public IQueryable<User> Danhsach()
        {
            return mydatabase.Users;
        }

        public bool them(User them)
        {
            User temp = mydatabase.Users.Where(p => p.account == them.account).SingleOrDefault();
            if (temp != null) return false;

            mydatabase.Users.Add(them);
            mydatabase.SaveChanges();

            return true;
        }

        public bool xoa(string account)
        {
            User temp = mydatabase.Users.Where(p => p.account == account).SingleOrDefault();
            if (temp == null) return false;

            mydatabase.Users.Remove(temp);
            mydatabase.SaveChanges();
            return true;

        }

        public bool edit(User sua)
        {
            User temp = mydatabase.Users.Where(p => p.account == sua.account).SingleOrDefault();
            if (temp == null) return false;


            temp.password = sua.password;
            mydatabase.SaveChanges();
            return true;
        }

        public bool login(User temp)
        {
            
            if (String.IsNullOrEmpty(temp.account) || String.IsNullOrEmpty(temp.password)) return false;
            else
            {
                 var count = (from t in mydatabase.Users
                             where t.account == temp.account && t.password == temp.password
                             select t
                            ).Count();
                if (count > 0) return true;
                else return false;
            }
           
        }
    }
}
