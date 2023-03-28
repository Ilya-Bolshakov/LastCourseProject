using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.Admin
{
    public class ServiceDal
    {
        private readonly EcoparkDbContext _context;
        public ServiceDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Service.AsEnumerable();
        }

        public async Task AddServiceAsync(Service service)
        {
            _context.Service.Add(service);
            await _context.SaveChangesAsync();
        }

        public async Task<Service> UpdateServiceAsync(Service service)
        {
            _context.Entry(service).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
            return service;
        }
    }
}
