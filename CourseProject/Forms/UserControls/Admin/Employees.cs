using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
using CourseProject.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.Admin
{
    public partial class Employees : UserControl
    {
        public BindingList<EmployeeDto> Employments { get; set; }
        public IList<EmployeeDto> AllEmployments { get; set; }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();
            var adminDal = new AdminDal(db);

            AllEmployments = adminDal.GetEmployees().Select(u => new EmployeeDto(u)).ToList();
            Employments = new BindingList<EmployeeDto>(AllEmployments);
            listBoxEmployees.DataSource = Employments;
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            Employments = new BindingList<EmployeeDto>(AllEmployments.Where(u => u.ToString().ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
            listBoxEmployees.DataSource = Employments;
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            var addForm = new AddEmployee();
            if (addForm.ShowDialog() == DialogResult.OK)
            { 

            }
        }
    }
}
