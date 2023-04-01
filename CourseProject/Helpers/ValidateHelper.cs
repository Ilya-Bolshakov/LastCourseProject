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
        public static bool ValidateSimpleText(string text, ref string errorMessage)
        {
            var regex = new Regex(@"^[a-zA-Zа-яА-Я]+$");
            if (!regex.IsMatch(text))
            {
                errorMessage = "Поле должно быть одним словом, содержащим только буквы";
                return false;
            }
            return true;
        }

        public static bool ValidatePassport(string passport, ref string errorMessage)
        {
            var regex = new Regex(@"^\d{7,12}$");
            if (regex.IsMatch(passport))
            {
                var db = new EcoparkDbContext();
                if (db.Users.Where(u => u.Passport.Equals(passport)).Any())
                {
                    errorMessage = "Такие паспортные данные уже существуют";
                    return false;
                }
                return true;
            }
            else
            {
                errorMessage = "Поле 'Паспорт' должно содержать от 7 до 12 цифр";
                return false;
            }
        }

        public static bool ValidatePhone(string phone, ref string errorMessage)
        {
            var regex = new Regex(@"^\d{7,12}$");
            if (regex.IsMatch(phone))
            {
                var db = new EcoparkDbContext();
                if (db.Users.Where(u => u.Phone.Equals(phone)).Any())
                {
                    errorMessage = "Такой номер телефона уже существуют";
                    return false;
                }
                return true;
            }
            else
            {
                errorMessage = "Поле 'Телефон' должно содержать от 7 до 12 цифр";
                return false;
            }
        }

        public static bool ValidateLogin(string login, ref string errorMessage)
        {
            if (String.IsNullOrEmpty(login))
            {
                errorMessage = "Поле 'Логин' должно быть заполнено";
                return false;
            }
            var db = new EcoparkDbContext();
            if (db.Users.Where(u => u.userLogin == login).Any())
            {
                errorMessage = "Такой логин уже существует";
                return false;
            }
           
            return true;
        }

        public static bool ValidatePassword(string pass, ref string errorMessage)
        {
            if (String.IsNullOrEmpty(pass))
            {
                errorMessage = "Поле 'Пароль' должно быть заполнено";
                return false;
            }
            return true;
        }
    }
}
