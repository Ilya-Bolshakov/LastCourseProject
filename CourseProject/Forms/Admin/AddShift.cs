using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
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
}
