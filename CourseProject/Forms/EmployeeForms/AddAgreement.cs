using CourseProject.DAL;
using CourseProject.DAL.DAL.EmployeeDal;
using CourseProject.DTO;
using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Forms.EmployeeForms
{
    public partial class AddAgreement : Form
    {
        public AgreementDto Agreement { get; set; }
        public List<House> Houses { get; set; }
        public AddAgreement()
        {
            InitializeComponent();
            Agreement = new AgreementDto();
            var db = new EcoparkDbContext();
            Houses = db.House.ToList();
            comboBox.DataSource = new BindingList<House>(Houses);
            dateTimePickerFinish.Value = dateTimePickerStart.Value.AddDays(1);
        }

        public AddAgreement(AgreementDto agreement)
        {
            InitializeComponent();
            Agreement = agreement;
            var db = new EcoparkDbContext();
            Houses = db.House.ToList();
            comboBox.DataSource = Houses;
            comboBox.SelectedItem = Houses.FirstOrDefault(i => i.IDHouse == (int)agreement.HouseId);
            //dateTimePickerFinish.Value = agreement.Start;
            //dateTimePickerFinish.Value = agreement.Finish;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Agreement.Start = dateTimePickerStart.Value;
                Agreement.Finish = dateTimePickerFinish.Value;
                var selectedHouse = (House)comboBox.SelectedItem;
                Agreement.Price = selectedHouse.HouseCategory.Price * ((dateTimePickerFinish.Value.Date - dateTimePickerStart.Value.Date).Days + 1);
                Agreement.HouseId = selectedHouse.IDHouse;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinish.MinDate = dateTimePickerStart.Value.AddDays(1);
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<House>(comboBox.SelectedItem, ref errorMessage))
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
            //comboBox.DataSource = Houses.Where(i => i.ToString().ToLower().Contains(comboBox.Text.ToLower())).ToList();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();
            var selectedHouse = (House)comboBox.SelectedItem;

            var q = from a in db.Agreement
                    where a.House.Select(i => i.IDHouse).Contains(selectedHouse.IDHouse)
                    orderby a.IDAgreement
                    select a;

            var lastAgreement = q.FirstOrDefault();

            if (lastAgreement != null)
            {
                dateTimePickerStart.MinDate = lastAgreement.AgreementDateEnd;
                dateTimePickerFinish.Value = dateTimePickerStart.Value.AddDays(1);
            }
            else
            {
                dateTimePickerStart.MinDate = DateTime.Now;
                dateTimePickerStart.Value = DateTime.Now;
                dateTimePickerFinish.Value = dateTimePickerStart.Value.AddDays(1);
            }

            
        }
    }
}
