using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DTO
{
    public class ShiftDto
    {
        public EmployeeDto Admin { get; set; }
        public EmployeeDto Employee { get; set; }
        public EmployeeDto FirstCleaner { get; set; }
        public EmployeeDto SecondCleaner { get; set; }
        public EmployeeDto ThirdCleaner { get; set; }
        public DateTime ShiftDate { get; set; }

        public ShiftDto(Shift shift)
        {
            Admin = new EmployeeDto(shift.Employee);
            Employee = new EmployeeDto(shift.Employee1);
            FirstCleaner = new EmployeeDto(shift.Employee2);
            SecondCleaner = new EmployeeDto(shift.Employee3);
            ThirdCleaner = new EmployeeDto(shift.Employee4);
            ShiftDate = shift.DateOfShift;
        }

        public ShiftDto()
        {
        }

        public Shift MapToOrm()
        {
            var shift = new Shift();
            shift.IDAdmin = Admin.Id;
            shift.IDEmployeeOnReception = Employee.Id;
            shift.IDFirstCleaner = FirstCleaner.Id;
            shift.IDSecondCleaner = SecondCleaner.Id;
            shift.IDThirdCleaner = ThirdCleaner.Id;
            shift.DateOfShift = ShiftDate;
            return shift;
        }

        public override string ToString()
        {
            return $"{Admin}, {Employee}, {FirstCleaner}, {SecondCleaner}, {ThirdCleaner} {ShiftDate.ToShortDateString()}";
        }
    }
}
