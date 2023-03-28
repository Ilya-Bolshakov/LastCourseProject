using CourseProject.DAL;
using CourseProject.Forms.Base;
using CourseProject.Forms.UserControls.Admin;
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
    public partial class AdminForm : BaseUserForm
    {
        public AdminForm(Users user) : base(user)
        {
            InitializeComponent();
        }

        private void SetNewMainControl(UserControl control)
        {
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(control);
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.Width = this.Width;
            employees.Height = this.Height;
            SetNewMainControl(employees);
        }

        private void buttonShifts_Click(object sender, EventArgs e)
        {
            Shifts shifts = new Shifts();
            shifts.Width = this.Width;
            shifts.Height = this.Height;
            SetNewMainControl(shifts);
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.Width = this.Width;
            services.Height = this.Height;
            SetNewMainControl(services);
        }
    }
}
