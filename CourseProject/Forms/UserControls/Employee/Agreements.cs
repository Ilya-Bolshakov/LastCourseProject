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
    public partial class Agreements : UserControl
    {
        public BindingList<VisitDto> AgreementList { get; set; }
        public UserDto User { get; set; }
        public UserAgreement Control { get; set; }
        public Agreements(UserDto user, UserAgreement control)
        {
            InitializeComponent();
            User = user;
            labelUser.Text = user.Display;
            Control = control;

            listBoxAgreements.DataSource = new BindingList<AgreementDto>(User.Agreements.ToList());
        }

        private void listBoxAgreements_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
