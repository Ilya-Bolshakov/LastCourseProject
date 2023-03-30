using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.EmployeeDal
{
    public class VisitDal
    {
        private readonly EcoparkDbContext _context;
        public VisitDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public IEnumerable<Visit> GetVisits()
        {
            return _context.Visit.AsEnumerable();
        }

        public IEnumerable<Visit> GetVisits(int userId)
        {
            return _context.Visit.Where(v => v.UserId == userId).AsEnumerable();
        }

        public async Task AddVisit(Visit visit)
        {
            _context.Visit.Add(visit);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVisit(Visit visit)
        {
            _context.Entry(visit).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
