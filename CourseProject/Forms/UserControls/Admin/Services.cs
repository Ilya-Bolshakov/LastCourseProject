using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
using CourseProject.Forms.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.UserControls.Admin
{
    public partial class Services : UserControl
    {
        public BindingList<ServiceDto> ServiceList { get; set; }
        public IList<ServiceDto> AllServices { get; set; }
        public Services()
        {
            InitializeComponent();
        }

        private async void Services_Load(object sender, EventArgs e)
        {
            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                var serviceDal = new ServiceDal(db);

                AllServices = serviceDal.GetServices().Select(u => new ServiceDto(u)).ToList();
                db.Dispose();
                ServiceList = new BindingList<ServiceDto>(AllServices);
            });
            await task;
            dataGridView.DataSource = ServiceList;
            textBoxFilterName.Enabled = true;
            dataGridView.Columns["Id"].Visible = false;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = new AddService();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var db = new EcoparkDbContext();
                var dal = new ServiceDal(db);
                await dal.AddServiceAsync(form.Service.MapToOrm());

                Services_Load(this, e);
                textBoxFilterName_TextChanged(this, e);
            }
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView?.CurrentRow?.DataBoundItem != null && dataGridView?.CurrentRow?.DataBoundItem is ServiceDto)
            {
                var form = new AddService((ServiceDto)dataGridView.CurrentRow.DataBoundItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var db = new EcoparkDbContext();
                    var dal = new ServiceDal(db);
                    await dal.UpdateServiceAsync(form.Service.MapToOrm());

                    Services_Load(this, e);
                    textBoxFilterName_TextChanged(this, e);
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу");
            }
        }

        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            ServiceList = new BindingList<ServiceDto>(AllServices.Where(u => u.Name.ToLower().Contains(textBoxFilterName.Text.ToLower())).ToList());
            dataGridView.DataSource = ServiceList;
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonEdit.Enabled = true;
        }
    }
}
