using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.EmployeeDal
{
    public class ServiceListDal
    {
        private readonly EcoparkDbContext _context;
        public ServiceListDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public async Task AddServiceToList(ServiceList service)
        {
            _context.ServiceList.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task<ServiceList> UpdateServiceToList(ServiceList service)
        {
            _context.Entry(service).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
            return service;
        }

        public ServiceList GetServiceList(int visitId, int serviceId)
        {
            return _context.ServiceList.FirstOrDefault(i => i.IDVisit == visitId && i.IDService == serviceId);
        }
    }
}
