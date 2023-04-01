using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CourseProject.Helpers
{
    public static class ValidateHelper
    {
        public static bool ValidateSimpleText(string text)
        {
            var regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
            return regex.IsMatch(text);
        }

        public static bool ValidatePassport(string passport)
        {
            var regex = new Regex(@"^\d{7,12}$");
            return regex.IsMatch(passport);
        }

        public static bool ValidatePhone(string phone)
        {
            var regex = new Regex(@"^\d{7,12}$");
            return regex.IsMatch(phone);
        }

        public static bool ValidateLogin(string login)
        {
            try
            {
                var db = new EcoparkDbContext();
                db.Users.Single(u => u.userLogin == login);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
