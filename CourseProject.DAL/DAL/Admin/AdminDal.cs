using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<Employee> GetOnlyEmployees()
        {
            return _context.Employee.Where(u => u.Users.UserRole == 1).AsEnumerable();
        }

        public IEnumerable<Employee> GetAdmins()
        {
            return _context.Employee.Where(u => u.Users.UserRole == 2).AsEnumerable();
        }

        public IEnumerable<Employee> GetCleaners()
        {
            return _context.Employee.Where(u => u.Users.UserRole == 3).AsEnumerable();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employee.FirstOrDefault(u => u.Id == id);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async void UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
