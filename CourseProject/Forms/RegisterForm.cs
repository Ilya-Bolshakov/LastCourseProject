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
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void labelEntry_Click(object sender, EventArgs e)
        {
            this.CloseApp = false;
            this.Close();
            var loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
