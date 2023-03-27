using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
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
        public BindingList<UserDto> Users { get; set; }
        public IList<UserDto> AllUsers { get; set; }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();
            var adminDal = new AdminDal(db);

            AllUsers = adminDal.GetEmployees().Select(u => new UserDto(u)).ToList();

            Users = new BindingList<UserDto>(AllUsers);

            listBoxEmployees.DataSource = Users;
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            
            Users = new BindingList<UserDto>(AllUsers.Where(u => u.ToString().ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
            listBoxEmployees.DataSource = Users;
        }
    }
}
