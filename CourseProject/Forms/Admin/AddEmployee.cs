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
    public partial class AddEmployee : Form
    {
        public EmployeeDto Employee { get; set; }
        public AddEmployee()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            BindingData();
        }

        public AddEmployee(EmployeeDto dto)
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            Employee = dto;
            textBoxLogin.Visible = false;
            textBoxPassword.Visible = false;
            BindingData();
        }

        public void BindingData()
        {
            textBoxAddress.Text = Employee?.Address;
            textBoxName.Text = Employee?.Name;
            textBoxPassport.Text = Employee?.Passport;
            textBoxPatronymic.Text = Employee?.Patronymic;
            textBoxPhone.Text = Employee?.Phone;
            textBoxSurname.Text = Employee?.LastName;
            dateTimePickerDateOfBirth.Value = Employee != null ? Employee.DateOfBirth : DateTime.Now;
            dateTimePickerEmplument.Value = Employee != null ? Employee.Employment : DateTime.Now;

            Controls.OfType<RadioButton>().ToList().ForEach(radio => radio.Checked = radio.Text.Equals(Employee?.Gender));

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();
            comboBoxwork.DataSource = new WorkDal(db).GetWorks().ToList();
            comboBoxwork.DisplayMember = "Work1";
            comboBoxwork.ValueMember = "Id";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
