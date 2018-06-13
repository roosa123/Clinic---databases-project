using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Authorization
    {
        public static Employee GetUser(string login, string passwd)
        {
            if(LogIn(login,passwd))
            {
                clinicEntities db = new clinicEntities();
                var result = from user in db.Employee
                             where user.Login == login
                             select user;
                List<Employee> list = new List<Employee>();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list[0];
            }
            return null;
        }

        public static bool LogIn(string login, string passwd)
        {
            if (login == null || passwd == null)
                return false;
            clinicEntities db = new clinicEntities();
            var result = from user in db.Employee
                         where user.Login == login
                         select user;
            List<Employee> list = new List<Employee>();
            foreach (var item in result)
            {
                list.Add(item);
            }
            SHA1 sha = new SHA1CryptoServiceProvider();
            passwd = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(passwd)));
            passwd = passwd.Replace("-", "");
            if (result.Count() == 1)
                return passwd.ToUpper() == list[0].Password.ToUpper();
            return false;
        }

        public static bool UserExists(string login)
        {
            if (login == null)
                return false;
            clinicEntities db = new clinicEntities();
            var result = from user in db.Employee
                         where user.Login == login
                         select user;
            return result.Count() == 1;
        }
    }
}
