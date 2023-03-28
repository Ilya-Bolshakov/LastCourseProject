using CourseProject.DAL;
using CourseProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public class FormsApplicationContext : ApplicationContext
    {
        public FormsApplicationContext()
        {
            var db = new EcoparkDbContext();
            var admin = db.Users.FirstOrDefault(x => x.Employee.Work == 2);
            var employee = db.Users.FirstOrDefault(x => x.Employee.Work == 1);
            //var loginForm = new AdminForm(admin);
            var employeeForm = new EmployeeForm(employee);
            employeeForm.Show();
        }
    }
}
