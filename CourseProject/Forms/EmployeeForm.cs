using CourseProject.DAL;
using CourseProject.Forms.Base;
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
        }

        private void SetNewMainControl(UserControl control)
        {
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(control);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
