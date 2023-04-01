using CourseProject.DAL;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CourseProject.Forms.EmployeeForms
{
    public partial class AddAgreement : Form
    {
        public AgreementDto Agreement { get; set; }
        public AddAgreement()
        {
            InitializeComponent();
            Agreement = new AgreementDto();
            var db = new EcoparkDbContext();
            comboBox.DataSource = db.House.ToList();
            dateTimePickerFinish.Value = dateTimePickerStart.Value.AddDays(1);
        }

        public AddAgreement(AgreementDto agreement)
        {
            InitializeComponent();
            Agreement = agreement;
            var db = new EcoparkDbContext();
            var houses = db.House.ToList();
            comboBox.DataSource = houses;
            comboBox.SelectedItem = houses.FirstOrDefault(i => i.IDHouse == (int)agreement.HouseId);
            dateTimePickerFinish.Value = agreement.Start;
            dateTimePickerFinish.Value = agreement.Finish;
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
    }
}
