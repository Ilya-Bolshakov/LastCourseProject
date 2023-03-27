using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.Admin
{
    public class WorkDal
    {
        private readonly EcoparkDbContext _context;
        public WorkDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }
        public IEnumerable<Work> GetWorks()
        {
            return _context.Work.AsEnumerable();
        }
    }
}
