using CourseProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.Base
{
    public partial class BaseUserForm : BaseForm
    {
        private Users _user;
        public BaseUserForm(Users user)
        {
            _user = user;
            InitializeComponent();
        }
    }
}
