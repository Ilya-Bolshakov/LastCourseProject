using CourseProject.DAL;
using CourseProject.DAL.DAL.Admin;
using CourseProject.DTO;
using CourseProject.Enums;
using CourseProject.Helpers;
using System;
using System.Linq;
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
            Employee = new EmployeeDto();
            Employee.DateOfBirth = DateTime.Now;
            Employee.Employment = DateTime.Now;
        }

        public AddEmployee(EmployeeDto dto)
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            Employee = dto;
            textBoxLogin.Visible = false;
            textBoxPassword.Visible = false;
            buttonRegister.Text = "Редактировать";
            BindingData();
        }

        public void BindingData()
        {
            textBoxAddress.Text = Employee.Address;
            textBoxName.Text = Employee.Name;
            textBoxPassport.Text = Employee.Passport;
            textBoxPatronymic.Text = Employee.Patronymic;
            textBoxPhone.Text = Employee.Phone;
            textBoxSurname.Text = Employee.LastName;
            dateTimePickerDateOfBirth.Value = Employee.DateOfBirth;
            dateTimePickerEmplument.Value = Employee.Employment;
            textBoxAddress.Text = Employee.Address;


            Controls.OfType<RadioButton>().ToList().ForEach(radio => radio.Checked = radio.Text.Equals(Employee?.Gender));

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            var db = new EcoparkDbContext();
            comboBoxwork.DataSource = new WorkDal(db).GetWorks().ToList();
            comboBoxwork.DisplayMember = "Work1";
            comboBoxwork.SelectedItem = new WorkDal(db).GetWorks().FirstOrDefault(w => w.Id == Employee.Id);
            db.Dispose();
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (Employee.Id == 0)
            {
                var newUser = new Users();
                newUser.FirstName = textBoxName.Text;
                newUser.LastName = textBoxSurname.Text;
                newUser.Patronymic = textBoxPatronymic.Text;
                newUser.Passport = textBoxPassport.Text;
                newUser.DateOfBirth = dateTimePickerDateOfBirth.Value;
                newUser.Phone = textBoxPhone.Text;

                var enableRadio = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                GenderEnum d = (GenderEnum)Enum.Parse(typeof(GenderEnum), enableRadio.Text);

                newUser.Gender = (int)d;
                newUser.userLogin = textBoxLogin.Text;

                try
                {
                    var selectedWork = (Work)comboBoxwork.SelectedItem;
                    Employee.WorkId = selectedWork.Id;
                    Employee.Employment = dateTimePickerEmplument.Value;
                    Employee.Address = textBoxAddress.Text;
                    newUser.UserRole = selectedWork.Id;

                    await AccountHelper.RegisterEmployee(newUser, textBoxPassword.Text, Employee);

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                var db = new EcoparkDbContext();

                var editE = new AdminDal(db).GetEmployee(Employee.Id);
                var editU = db.Users.FirstOrDefault(u => u.Id == Employee.Id);

                editE.EmploymentDate = dateTimePickerEmplument.Value;
                editE.ResidentialAddress = textBoxAddress.Text;
                var selectedWork = (Work)comboBoxwork.SelectedItem;
                Employee.WorkId = selectedWork.Id;
                editE.Work = Employee.Id;
                editU.UserRole = Employee.Id;

                editU.FirstName = textBoxName.Text;
                editU.LastName = textBoxSurname.Text;
                editU.Passport = textBoxPassport.Text;
                editU.Patronymic = textBoxPatronymic.Text;
                editU.DateOfBirth = dateTimePickerDateOfBirth.Value;
                editU.Phone = textBoxPhone.Text;
                var enableRadio = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                GenderEnum d = (GenderEnum)Enum.Parse(typeof(GenderEnum), enableRadio.Text);

                editU.Gender = (int)d;


                try
                {
                    await db.SaveChangesAsync();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
