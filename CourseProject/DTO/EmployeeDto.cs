using CourseProject.DAL;
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
        public int WorkInt { get; set; }
        public string Work { get; set; }
        public DateTime Employment { get; set; }

        public EmployeeDto()
        {

        }

        public EmployeeDto(Employee employee)
        {
            Id = employee.Id;
            Address = employee.ResidentialAddress;
            Work = employee.Work1.Work1;
            WorkInt = employee.Work;
            Employment = employee.EmploymentDate;
        }

        public Employee MapEmployeeToOrm()
        {
            var employee = new Employee();
            employee.Id = Id;
            employee.Work = WorkInt;
            employee.ResidentialAddress = Address;
            employee.EmploymentDate = Employment;
            
            return employee;
        }
    }
}
