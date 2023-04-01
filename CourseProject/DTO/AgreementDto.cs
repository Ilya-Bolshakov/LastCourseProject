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
        public int? HouseId { get; set; }

        public AgreementDto(Agreement agreement)
        {
            Id = agreement.IDAgreement;
            UserId = agreement.Users.Id;
            Start = agreement.AgreementDate;
            Finish = agreement.AgreementDateEnd;
            Price = agreement.Price;
            HouseId = agreement.House.FirstOrDefault()?.IDHouse;
        }

        public AgreementDto()
        {
        }

        public Agreement MapToOrm()
        {
            var agreement = new Agreement();
            agreement.IDAgreement = Id;
            agreement.AgreementDate = Start;
            agreement.AgreementDateEnd = Finish;
            agreement.Price = Price;
            agreement.IDCustomer = UserId;

            var db = new EcoparkDbContext();
            agreement.House.Add(db.House.First(h => h.IDHouse == HouseId));
            db.Dispose();
            return agreement;
        }

        public override string ToString()
        {
            return $"Договор #{Id}. Объект #{HouseId}";
        }
    }
}
