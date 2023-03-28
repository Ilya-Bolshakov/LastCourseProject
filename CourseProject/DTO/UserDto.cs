using CourseProject.DAL;
using CourseProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject.Extensions;

namespace CourseProject.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int RoleInt { get; set; }
        public string Role { get; set; }
        public string Passport { get; set; }
        public int GenderInt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Display 
        {
            get
            {
                return $"{LastName} {Name} {Patronymic}. {Passport}";
            }
        }

        public UserDto()
        {
        }

        public UserDto(Users user)
        {
            Id = user.Id;
            Name = user.FirstName;
            LastName = user.LastName;
            Patronymic = user.Patronymic;
            RoleInt = user.UserRole;
            Phone = user.Phone;
            DateOfBirth = user.DateOfBirth;
            GenderInt = user.Gender;
            Passport = user.Passport;
            Gender = ((GenderEnum)Enum.GetValues(typeof(GenderEnum)).GetValue(user.Gender)).ToString();
            RoleEnum g = new RoleEnum();
            Role = g.GetEnumValue(user.UserRole);
        }

        public Users MapToOrm()
        {
            var users = new Users();
            users.FirstName = Name;
            users.LastName = LastName;
            users.Patronymic = Patronymic;
            users.UserRole = RoleInt;
            users.Phone = Phone;
            users.DateOfBirth = DateOfBirth;
            users.Gender = GenderInt;
            users.Passport = Passport;
            users.userLogin = Login;
            users.userPassword = Password;
            return users;
        }

        public override string ToString()
        {
            return $"{LastName} {Name} {Patronymic}. {Role}";
        }
    }
}
