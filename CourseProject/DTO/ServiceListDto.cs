using CourseProject.DAL;
using System.ComponentModel;
using System.Windows.Controls;

namespace CourseProject.DTO
{
    public class ServiceListDto
    {
        [DisplayName("Название")]
        public string Name
        {
            get
            {
                return Service.Name;
            }
        }
        [DisplayName("Номер услуги")]
        public int ServiceId { get; set; }
        public ServiceDto Service { get; set; }
        public int VisitId { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }


        public ServiceListDto(ServiceList serviceList)
        {
            ServiceId = serviceList.IDService;
            VisitId = serviceList.IDVisit;
            Count = serviceList.ServiceCount;
            Service = new ServiceDto(serviceList.Service);
        }

        public ServiceListDto()
        {
        }

        public ServiceList MapToOrm()
        {
            ServiceList serviceList = new ServiceList();
            serviceList.IDService = ServiceId;
            serviceList.IDVisit = VisitId;
            serviceList.ServiceCount = Count;
            return serviceList;
        }
    }
}
