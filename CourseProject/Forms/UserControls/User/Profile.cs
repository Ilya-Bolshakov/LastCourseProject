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

namespace CourseProject.Forms.UserControls.User
{
    public partial class Profile : UserControl
    {
        public UserDto User { get; set; }
        public Profile(UserDto dto)
        {
            InitializeComponent();
            User = dto;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            labelDateOfBirth.Text = User.DateOfBirth.ToShortDateString();
            labelDateOfBirth.Visible = true;
            labelName.Text = $"{User.LastName} {User.Name} {User.Patronymic}";
            labelName.Visible = true;
            labelPhone.Text = User.Phone;
            labelPhone.Visible = true;
            labelpassport.Text = User.Passport;
            labelpassport.Visible = true;
        }
    }
}
