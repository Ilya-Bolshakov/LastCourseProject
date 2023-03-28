using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.Admin
{
    public class ShiftDal
    {
        private readonly EcoparkDbContext _context;

        public ShiftDal(EcoparkDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shift> GetShifts()
        {
            return _context.Shift.AsEnumerable();
        }
    }
}
