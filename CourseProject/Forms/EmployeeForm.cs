using CourseProject.DAL;
using CourseProject.DTO;
using CourseProject.Forms.Base;
using CourseProject.Forms.UserControls.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class EmployeeForm : BaseUserForm
    {
        public UserDto Employee { get; set; }
        public EmployeeForm(Users user) : base(user)
        {
            InitializeComponent();
            Employee = new UserDto(user);
            Text = Employee.ToString();

        }

        private void SetNewMainControl(UserControl control)
        {
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(control);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            User user = new User(Employee);
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        private void buttonAggreement_Click(object sender, EventArgs e)
        {
            UserAgreement user = new UserAgreement(Employee);
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            EmployeeProfile user = new EmployeeProfile(Employee);
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        private void flowLayoutPanelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
