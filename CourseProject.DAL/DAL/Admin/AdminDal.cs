using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.Admin
{
    public class AdminDal
    {
        private readonly EcoparkDbContext _context;
        public AdminDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public IEnumerable<Users> GetEmployees()
        {
            return _context.Users.Where(u => u.UserRole >= 0).AsEnumerable();
        }
    }
}
