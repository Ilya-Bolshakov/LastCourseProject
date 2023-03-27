using CourseProject.DAL;
using CourseProject.Enums;
using CourseProject.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DTO
{
    public class EmployeeDto : UserDto
    {
        public string Address { get; set; }
        public Work Work { get; set; }
        public DateTime Employment { get; set; }

        public EmployeeDto()
        {

        }

        public EmployeeDto(Employee employee)
        {
            Id = employee.Id;
            Address = employee.ResidentialAddress;
            Work = employee.Work1;
            Employment = employee.EmploymentDate;

            Name = employee.Users.FirstName;
            LastName = employee.Users.LastName;
            Patronymic = employee.Users.Patronymic;
            RoleInt = employee.Users.UserRole;
            Phone = employee.Users.Phone;
            DateOfBirth = employee.Users.DateOfBirth;
            GenderInt = employee.Users.Gender;
            Passport = employee.Users.Passport;
            Gender = ((GenderEnum)Enum.GetValues(typeof(GenderEnum)).GetValue(employee.Users.Gender)).ToString();
            RoleEnum g = new RoleEnum();
            Role = g.GetEnumValue(employee.Users.UserRole);
        }

        public Employee MapEmployeeToOrm()
        {
            var employee = new Employee();
            employee.Id = Id;
            employee.ResidentialAddress = Address;
            employee.EmploymentDate = Employment;
            employee.Work1 = Work;
            employee.Work = Work.Id;

            
            return employee;
        }
    }
}
