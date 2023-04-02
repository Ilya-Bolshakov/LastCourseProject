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

namespace CourseProject.Forms.Admin
{
    public partial class AddShift : Form
    {
        public ShiftDto Shift { get; set; }
        public AddShift()
        {
            InitializeComponent();
        }

        public AddShift(ShiftDto shiftdto)
        {
            InitializeComponent();
            Shift = shiftdto;
            dateTimePicker1.Visible = false;
        }

        private void AddShift_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();

            var dal = new AdminDal(db);
            var admins = dal.GetAdmins().Select(i => new EmployeeDto(i)).ToList();
            comboBoxAdmin.DataSource = admins;
            var employees = dal.GetOnlyEmployees().Select(i => new EmployeeDto(i)).ToList();
            comboBoxEmployee.DataSource = employees;
            var cleaners = dal.GetCleaners().Select(i => new EmployeeDto(i)).ToList();
            comboBoxFirstC.DataSource = cleaners;
            comboBoxSecondC.DataSource = cleaners;
            comboBoxThirdC.DataSource = cleaners;

            if (Shift != null)
            {
                comboBoxAdmin.SelectedItem = admins.FirstOrDefault(i => i.Id == Shift.Admin.Id);
                comboBoxEmployee.SelectedItem = employees.FirstOrDefault(i => i.Id == Shift.Employee.Id);
                comboBoxFirstC.SelectedItem = cleaners.FirstOrDefault(i => i.Id == Shift.FirstCleaner.Id);
                comboBoxSecondC.SelectedItem = cleaners.FirstOrDefault(i => i.Id == Shift.SecondCleaner.Id);
                comboBoxThirdC.SelectedItem = cleaners.FirstOrDefault(i => i.Id == Shift.ThirdCleaner.Id);
            }
            else
            {
                Shift = new ShiftDto();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Shift.Admin = (EmployeeDto)comboBoxAdmin.SelectedItem;
                Shift.Employee = (EmployeeDto)comboBoxEmployee.SelectedItem;
                Shift.FirstCleaner = (EmployeeDto)comboBoxFirstC.SelectedItem;
                Shift.SecondCleaner = (EmployeeDto)comboBoxSecondC.SelectedItem;
                Shift.ThirdCleaner = (EmployeeDto)comboBoxThirdC.SelectedItem;
                Shift.ShiftDate = dateTimePicker1.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void comboBoxAdmin_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<EmployeeDto>(comboBoxAdmin.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxAdmin, null);
            }
            else
            {
                e.Cancel = true;
                comboBoxAdmin.Focus();
                errorProvider.SetError(comboBoxAdmin, errorMessage);
            }
        }

        private void comboBoxEmployee_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<EmployeeDto>(comboBoxEmployee.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxEmployee, null);
            }
            else
            {
                e.Cancel = true;
                comboBoxEmployee.Focus();
                errorProvider.SetError(comboBoxEmployee, errorMessage);
            }
        }

        private void comboBoxFirstC_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<EmployeeDto>(comboBoxFirstC.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxFirstC, null);
            }
            else
            {
                e.Cancel = true;
                comboBoxFirstC.Focus();
                errorProvider.SetError(comboBoxFirstC, errorMessage);
            }
        }

        private void comboBoxSecondC_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<EmployeeDto>(comboBoxSecondC.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxSecondC, null);
            }
            else
            {
                e.Cancel = true;
                comboBoxSecondC.Focus();
                errorProvider.SetError(comboBoxSecondC, errorMessage);
            }
        }

        private void comboBoxThirdC_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSelectedItem<EmployeeDto>(comboBoxThirdC.SelectedItem, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(comboBoxThirdC, null);
            }
            else
            {
                e.Cancel = true;
                comboBoxThirdC.Focus();
                errorProvider.SetError(comboBoxThirdC, errorMessage);
            }
        }
    }
}
