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
    public partial class UserAgreement : UserControl
    {
        public BindingList<UserDto> UserList { get; set; }
        public IList<UserDto> AllUsers { get; set; }
        public UserDto Employee { get; set; }
        public UserAgreement(UserDto employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private async void UserAgreement_Load(object sender, EventArgs e)
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

        private void listBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxFilterName.Enabled = listBoxUsers.SelectedItem != null;
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            UserList = new BindingList<UserDto>(AllUsers.Where(u => u.Display.ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
            listBoxUsers.DataSource = UserList;
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBoxUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                var agreements = new Agreements((UserDto)listBoxUsers.SelectedItem);
                agreements.Width = panel.Width;
                agreements.Height = panel.Height;
                panel.Controls.Clear();
                panel.Controls.Add(agreements);
            }
        }
    }
}
