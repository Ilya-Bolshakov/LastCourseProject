using CourseProject.DAL;
using System.ComponentModel;

namespace CourseProject.DTO
{
    public class ServiceDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }

        public ServiceDto(Service service)
        {
            Id = service.IDService;
            Name = service.ServiceName;
            Description = service.ServiceDescription;
            Price = service.Price;
        }

        public ServiceDto()
        {
        }

        public Service MapToOrm()
        {
            return new Service()
            {
                IDService = Id,
                ServiceName = Name,
                ServiceDescription = Description,
                Price = Price,
            };
        }
    }
}
