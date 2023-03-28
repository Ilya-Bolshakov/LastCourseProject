using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DAL.DAL.EmployeeDal
{
    public class UserDal
    {
        private readonly EcoparkDbContext _context;
        public UserDal(EcoparkDbContext ecopark)
        {
            _context = ecopark;
        }

        public IEnumerable<Users> GetUsers()
        {
            return _context.Users.Where(u => u.UserRole == 0).AsEnumerable();
        }
    }
}
