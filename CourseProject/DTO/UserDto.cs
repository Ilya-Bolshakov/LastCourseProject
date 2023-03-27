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

        public override string ToString()
        {
            return $"{Name} {LastName} {Patronymic}. {Role}";
        }
    }
}
