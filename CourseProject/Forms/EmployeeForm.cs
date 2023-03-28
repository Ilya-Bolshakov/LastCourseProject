using CourseProject.DAL;
using CourseProject.DTO;
using CourseProject.Forms.Base;
using CourseProject.Forms.UserControls.Employee;
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
        public EmployeeForm(Users user) : base(user)
        {
            InitializeComponent();
            Text = new UserDto(user).ToString();
        }

        private void SetNewMainControl(UserControl control)
        {
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(control);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }
    }
}
