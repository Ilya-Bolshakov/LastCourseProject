using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
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
        public BindingList<ServiceListDto> BindingList { get; set; }
        public DetailUserVisits(VisitDto visit)
        {
            InitializeComponent();
            labelVisit.Text = visit.ToString();
            Visit = visit;
        }

        private void DetailUserVisits_Load(object sender, EventArgs e)
        {
            BindingList = new BindingList<ServiceListDto>(Visit.Services.ToList());
            dataGridView.DataSource = BindingList;
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
                    var serviceDal = new ServiceDal(db);
                    slNew.Service = new ServiceDto(serviceDal.GetService(slNew.ServiceId));
                    Visit.Services.Add(slNew);
                    DetailUserVisits_Load(this, e);
                    textBoxFilterName_TextChanged(this, e);
                }
                else 
                {
                    s.ServiceCount++;
                    await dal.UpdateServiceToList(s);
                    var item = BindingList.First(i => i.VisitId == s.IDVisit && i.ServiceId == s.IDService);
                    item.Count = s.ServiceCount;
                    DetailUserVisits_Load(this, e);
                    textBoxFilterName_TextChanged(this, e);
                }
            }
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = new BindingList<ServiceListDto>(Visit.Services.Where(s => s.Name.ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            var form = new DeleteService();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var service = dataGridView.CurrentRow.DataBoundItem as ServiceListDto;
                var db = new EcoparkDbContext();
                var dal = new ServiceListDal(db);
                if (form.Count < service.Count)
                {
                    service.Count -= form.Count;
                    await dal.UpdateServiceToList(service.MapToOrm());
                }
                else
                {
                    await dal.Remove(service.MapToOrm());
                    Visit.Services.Remove(service);
                }
            }
            DetailUserVisits_Load(this, e);
            textBoxFilterName_TextChanged(this, e);
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonDelete.Enabled = dataGridView?.CurrentRow?.DataBoundItem is ServiceListDto;
        }
    }
}
