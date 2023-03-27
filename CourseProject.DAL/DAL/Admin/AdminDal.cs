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

        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employee.Where(u => u.Users.UserRole >= 0).AsEnumerable();
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
