using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.EmployeeDal
{
    public class AgreementDal
    {
        private readonly EcoparkDbContext _context;
        public AgreementDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public IEnumerable<Agreement> GetAgreements()
        {
            return _context.Agreement.AsEnumerable();
        }

        public async Task AddAgreement(Agreement agreement)
        {
            _context.Agreement.Add(agreement);
            await _context.SaveChangesAsync();
        }

        public async Task<Agreement> UpdateAgreement(Agreement agreement)
        {
            _context.Entry(agreement).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
            return agreement;
        }
    }
}
