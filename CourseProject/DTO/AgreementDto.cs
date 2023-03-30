using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DTO
{
    public class AgreementDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public decimal Price { get; set; }

        public AgreementDto(Agreement agreement)
        {
            Id = agreement.IDAgreement;
            UserId = agreement.Users.Id;
            Start = agreement.AgreementDate;
            Finish = agreement.AgreementDateEnd;
            Price = agreement.Price;
        }
    }
}
