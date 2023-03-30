using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
using CourseProject.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.Employee
{
    public partial class DetailUser : UserControl
    {
        public BindingList<VisitDto> VisitList { get; set; }
        public IList<VisitDto> AllVisits { get; set; }
        public UserDto User { get; set; }
        public DetailUser(UserDto user)
        {
            InitializeComponent();
            User = user;
            labelUser.Text = user.Display;
        }

        private async void DetailUser_Load(object sender, System.EventArgs e)
        {
            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                var dal = new VisitDal(db);
                AllVisits = dal.GetVisits(User.Id).Select(i => new VisitDto(i)).ToList();
            });
            await task;

            VisitList = new BindingList<VisitDto>(AllVisits);
        }

        private void buttonAddVisit_Click(object sender, System.EventArgs e)
        {

        }
    }
}
