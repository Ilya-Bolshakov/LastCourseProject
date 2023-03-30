using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public List<ServiceListDto> Services { get; set; }

        public VisitDto(Visit visit)
        {
            Id = visit.IDVisit;
            UserId = visit.UserId;
            EmployeeId = visit.IDEmployeeOnReception;
            User = new UserDto(visit.Users);
            Employee = new EmployeeDto(visit.Employee);
            Start = visit.DateOfVisit;
            Finish = visit.DateOfVisitEnd;
            Services = visit.ServiceList.Where(v => v.IDVisit == Id).Select(v => new ServiceListDto(v)).ToList();
        }

        public VisitDto()
        {
        }

        public override string ToString()
        {
            return $"Посещение #{Id}. {User.Display}. {Start.ToShortDateString()} - {Finish?.ToShortDateString()}";
        }

        internal Visit MapToOrm()
        {
            var visit = new Visit();
            visit.IDVisit = Id;
            visit.UserId = UserId;
            visit.IDEmployeeOnReception = EmployeeId;
            visit.DateOfVisit = Start;
            visit.DateOfVisitEnd = Finish;
            visit.ServiceList = Services?.Select(i => i.MapToOrm()).ToList();
            return visit;
        }
    }
}
