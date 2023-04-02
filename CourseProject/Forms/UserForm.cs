using CourseProject.DAL;
using CourseProject.DTO;
using CourseProject.Forms.Base;
using CourseProject.Forms.UserControls.User;
using System;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class UserForm : BaseUserForm
    {
        public UserDto User { get; set; }
        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(Users user) : base(user)
        {
            InitializeComponent();
            User = new UserDto(user);
            Text = User.ToString();
        }

        private void SetNewMainControl(UserControl control)
        {
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(control);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Agreements user = new Agreements(User);
            user.buttonEdit.Visible = false;
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile user = new Profile(User);
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        private void buttonVisits_Click(object sender, EventArgs e)
        {
            DetailUser user = new DetailUser(User, null, DisplayVisit);
            user.buttonEdit.Visible = false;
            user.buttonAddVisit.Visible = false;
            user.buttonDeleteVisit.Visible = false;
            user.Width = this.Width;
            user.Height = this.Height;
            SetNewMainControl(user);
        }

        public void DisplayVisit(VisitDto visit)
        {
            var detailUser = new DetailUserVisits(visit);
            detailUser.buttonAddService.Visible = false;
            detailUser.Width = flowLayoutPanelMain.Width;
            detailUser.Height = flowLayoutPanelMain.Height;
            flowLayoutPanelMain.Controls.Clear();
            flowLayoutPanelMain.Controls.Add(detailUser);
        }
    }
}
