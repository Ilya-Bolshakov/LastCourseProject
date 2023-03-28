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

        public async Task AddShiftAsync(Shift shift)
        {
            _context.Shift.Add(shift);
            await _context.SaveChangesAsync();
        }

        public async Task<Shift> UpdateShiftAsync(Shift shift)
        {
            _context.Entry(shift).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
            return shift;
        }
    }
}
