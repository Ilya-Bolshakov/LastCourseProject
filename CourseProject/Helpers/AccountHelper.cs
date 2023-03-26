using CourseProject.DAL;
using CourseProject.Enums;
using CourseProject.Guards;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Helpers
{
    internal class AccountHelper
    {
        public static Users Login(string login, string password)
        {   
            if (login == null) return null;

            var db = new EcoparkDbContext();

            IHashable hasher = new SecurePasswordHasher();

            var user = db.Users.FirstOrDefault(u => u.userLogin.Equals(login));
            if (user == null) return null;
            else 
            {
                if (hasher.VerifyPassword(password, user.userPassword))
                {
                    return user;
                }
                else return null;
            }
        }

        public async static Task<bool> Register(Users newUser, string password)
        {
            IHashable hasher = new SecurePasswordHasher();
            newUser.userPassword = hasher.Hash(password);

            try
            {
                var db = new EcoparkDbContext();
                db.Users.Add(newUser);
                await db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("При попытке регистрации произошла ошибка!");
            }
           
        }
    }
}
