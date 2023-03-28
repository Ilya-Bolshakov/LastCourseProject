using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
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

namespace CourseProject.Forms.UserControls.Employee
{
    public partial class User : UserControl
    {
        public BindingList<UserDto> UserList { get; set; }
        public IList<UserDto> AllUsers { get; set; }
        public User()
        {
            InitializeComponent();
        }

        private async void Users_Load(object sender, EventArgs e)
        {
            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                var dal = new UserDal(db);

                AllUsers = dal.GetUsers().Select(u => new UserDto(u)).ToList();
                db.Dispose();
                UserList = new BindingList<UserDto>(AllUsers);
            });
            await task;
            listBoxUsers.DataSource = UserList;
            listBoxUsers.DisplayMember = "Display";
        }
    }
}
