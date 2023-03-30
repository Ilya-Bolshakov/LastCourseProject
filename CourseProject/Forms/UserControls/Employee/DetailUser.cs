using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
using CourseProject.DTO;
using CourseProject.Forms.EmployeeForms;
using System;
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
        public UserDto Employee { get; set; }
        public User Control { get; set; }
        public DetailUser(UserDto user, UserDto employee, User control)
        {
            InitializeComponent();
            User = user;
            Employee = employee;
            labelUser.Text = user.Display;
            buttonEdit.Enabled = false;
            dateTimePickerFinish.Enabled = false;
            dateTimePickerStart.Enabled = false;
            Control = control;
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
            listBoxVisits.DataSource = VisitList;

            buttonEdit.Enabled = true;
            dateTimePickerFinish.Enabled = true;
            dateTimePickerStart.Enabled = true;
        }

        private async void buttonAddVisit_Click(object sender, System.EventArgs e)
        {
            var form = new AddVisit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Visit.UserId = User.Id;
                form.Visit.EmployeeId = Employee.Id;

                var db = new EcoparkDbContext();
                var dal = new VisitDal(db);
                
                if (AllVisits.Where(i => i.Start < form.Visit.Start || i.Finish > form.Visit.Finish).Any())
                {
                    MessageBox.Show("Недопустимая дата");
                }
                else
                {
                    buttonEdit.Enabled = false;
                    dateTimePickerFinish.Enabled = false;
                    dateTimePickerStart.Enabled = false;

                    var v = form.Visit.MapToOrm();
                    await dal.AddVisit(v);
                    DetailUser_Load(sender, e);
                    Filter();
                }
                
            }
        }

        private async void buttonEdit_Click(object sender, System.EventArgs e)
        {
            var form = new AddVisit((VisitDto)listBoxVisits.SelectedItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Visit.UserId = User.Id;
                form.Visit.EmployeeId = Employee.Id;

                var db = new EcoparkDbContext();
                var dal = new VisitDal(db);

                var b = DateTime.Now < form.Visit.Start;

                if (AllVisits.Where(i => i.Start < form.Visit.Start || i.Finish > form.Visit.Finish).Any())
                {
                    MessageBox.Show("Недопустимая дата");
                }
                else
                {
                    buttonEdit.Enabled = false;
                    dateTimePickerFinish.Enabled = false;
                    dateTimePickerStart.Enabled = false;

                    var v = form.Visit.MapToOrm();
                    await dal.UpdateVisit(v);
                    DetailUser_Load(sender, e);
                    Filter();
                }

            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, System.EventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            VisitList = new BindingList<VisitDto>(AllVisits.Where(i => i.Start.Date >= dateTimePickerStart.Value.Date && (i.Finish?.Date != null ? i.Finish?.Date <= dateTimePickerFinish.Value.Date : true)).ToList());
            listBoxVisits.DataSource = VisitList;
        }

        private void dateTimePickerFinish_ValueChanged(object sender, System.EventArgs e)
        {
            Filter();
        }

        private void listBoxVisits_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxVisits.SelectedItem != null)
            {
                Control.DisplayVisit((VisitDto)listBoxVisits.SelectedItem);
            }
        }
    }
}
