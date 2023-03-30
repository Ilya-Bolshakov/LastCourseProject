using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DTO
{
    public class VisitDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; }
        public UserDto User { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Finish { get; set; }

        public VisitDto(Visit visit)
        {
            Id = visit.IDVisit;
            UserId = visit.UserId;
            EmployeeId = visit.IDEmployeeOnReception;
            User = new UserDto(visit.Users);
            Employee = new EmployeeDto(visit.Employee);
            Start = visit.DateOfVisit;
            Finish = visit.DateOfVisitEnd;
        }

        public override string ToString()
        {
            return $"Посещение #{Id}. {User.Display}. {Start} - {Finish}";
        }
    }
}
