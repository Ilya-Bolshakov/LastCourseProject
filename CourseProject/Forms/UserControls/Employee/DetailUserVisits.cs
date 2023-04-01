using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
using CourseProject.DTO;
using CourseProject.Forms.EmployeeForms;
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
    public partial class DetailUserVisits : UserControl
    {
        public VisitDto Visit { get; set; }
        public DetailUserVisits(VisitDto visit)
        {
            InitializeComponent();
            labelVisit.Text = visit.ToString();
            Visit = visit;
        }

        private void DetailUserVisits_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = new BindingList<ServiceListDto>(Visit.Services.ToList());
            dataGridView.Columns["VisitId"].Visible = false;
            dataGridView.Columns["Service"].Visible = false;
        }

        private async void buttonAddService_Click(object sender, EventArgs e)
        {
            var form = new AddServiceToVisit();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var db = new EcoparkDbContext();
                var dal = new ServiceListDal(db);

                var s = dal.GetServiceList(Visit.Id, form.SelectedService.Id);
                if (s == null)
                {
                    var slNew = new ServiceListDto();
                    slNew.VisitId = Visit.Id;
                    slNew.ServiceId = form.SelectedService.Id;
                    slNew.Count = 1;
                    await dal.AddServiceToList(slNew.MapToOrm());
                    DetailUserVisits_Load(this, e);
                    textBoxFilterName_TextChanged(this, e);
                }
                else 
                {
                    s.ServiceCount++;
                    await dal.UpdateServiceToList(s);
                    DetailUserVisits_Load(this, e);
                    textBoxFilterName_TextChanged(this, e);
                }
            }
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = new BindingList<ServiceListDto>(Visit.Services.Where(s => s.Name.ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
        }
    }
}
