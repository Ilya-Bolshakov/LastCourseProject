using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.EmployeeForms
{
    public partial class AddServiceToVisit : Form
    {
        public IEnumerable<ServiceDto> AllServices { get; set; }
        public ServiceDto SelectedService { get; set; }
        public AddServiceToVisit()
        {
            InitializeComponent();
        }

        private async void AddServiceToVisit_Load(object sender, EventArgs e)
        {
            var task = Task.Run(() =>
            {
                var db = new EcoparkDbContext();
                var dal = new ServiceDal(db);

                AllServices = dal.GetServices().Select(u => new ServiceDto(u)).ToList();
                db.Dispose();
            });
            await task;

            comboBox.DataSource = AllServices;
            comboBox.DisplayMember = "Name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SelectedService = comboBox.SelectedItem as ServiceDto;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<ServiceDto>(comboBox.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBox, null);
            }
            else
            {
                e.Cancel = true;
                comboBox.Focus();
                errorProvider.SetError(comboBox, errorMessage);
            }
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            comboBox.DataSource = AllServices.Where(i => i.Name.ToLower().Contains(comboBox.Text.ToLower())).ToList();
        }
    }
}
