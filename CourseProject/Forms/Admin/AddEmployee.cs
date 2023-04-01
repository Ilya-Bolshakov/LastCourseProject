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
            radioButtonMale.Checked = true;
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

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSimpleText(textBoxName.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxName, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxName, errorMessage);
            }
        }

        private void textBoxSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSimpleText(textBoxSurname.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxSurname, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxSurname, errorMessage);
            }
        }

        private void textBoxPatronymic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateSimpleText(textBoxPatronymic.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPatronymic, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPatronymic, errorMessage);
            }
        }

        private void textBoxPassport_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidatePassport(textBoxPassport.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPassport, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPassport, errorMessage);
            }
        }

        private void textBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidatePhone(textBoxPhone.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPhone, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPhone, errorMessage);
            }
        }

        private void textBoxAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateAddress(textBoxAddress.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxAddress, null);
            }
            else
            {
                e.Cancel = true;
                textBoxAddress.Focus();
                errorProvider.SetError(textBoxAddress, errorMessage);
            }
        }

        private void textBoxLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateLogin(textBoxLogin.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxLogin, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxLogin, errorMessage);
            }
        }

        private void textBoxPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidatePassword(textBoxPassword.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPassword, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPassword, errorMessage);
            }
        }

        private void comboBoxwork_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
