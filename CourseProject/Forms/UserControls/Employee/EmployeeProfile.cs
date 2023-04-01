using CourseProject.DAL;
using CourseProject.DTO;
using CourseProject.Enums;
using CourseProject.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.User
{
    public partial class EmployeeProfile : UserControl
    {
        public UserDto Employee { get; set; }
        public EmployeeProfile(UserDto employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private async void EmployeeProfile_Load(object sender, EventArgs e)
        {
            EmployeeDto employeeDto = null;

            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                employeeDto = new EmployeeDto(db.Employee.FirstOrDefault(em => em.Id == Employee.Id));
            });
            await task;
            labelEmployeeDate.Text = employeeDto.Employment.ToShortDateString();
            labelEmployeeDate.Visible = true;
            labelName.Text = $"{Employee.LastName} {Employee.Name} {Employee.Patronymic}";
            labelName.Visible = true;
            labelPhone.Text = Employee.Phone;
            labelPhone.Visible = true;
            labelWork.Text = employeeDto.Work;
            labelWork.Visible = true;
        }
    }
}
