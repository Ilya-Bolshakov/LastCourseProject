using CourseProject.DAL;
using CourseProject.Enums;
using CourseProject.Guards;
using CourseProject.Helpers;
using System;
using System.Linq;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            radioButtonMale.Checked = true;
        }

        private void labelEntry_Click(object sender, EventArgs e)
        {
            this.CloseApp = false;
            this.Close();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var newUser = new Users();
                newUser.FirstName = textBoxName.Text;
                newUser.LastName = textBoxPatronymic.Text;
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
                    await AccountHelper.Register(newUser, textBoxPassword.Text);
                    this.CloseApp = false;
                    this.Close();
                    var loginForm = new LoginForm();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }            
        }

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidateSimpleText(textBoxName.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxName, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxName, "Поле 'Имя' должно быть одним словом, содержащим только буквы");
            }
        }

        private void textBoxPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidatePassport(textBoxPhone.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPhone, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPhone, "Поле 'Телефон' должно содержать от 7 до 12 цифр");
            }
        }

        private void textBoxSurname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidateSimpleText(textBoxSurname.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxSurname, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxSurname, "Поле 'Фамилия' должно быть одним словом, содержащим только буквы");
            }
        }

        private void textBoxPatronymic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidateSimpleText(textBoxPatronymic.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPatronymic, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPatronymic, "Поле 'Отчество' должно быть одним словом, содержащим только буквы");
            }
        }

        private void textBoxPassport_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidatePassport(textBoxPassport.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPassport, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPassport, "Поле 'Паспорт' должно содержать от 7 до 12 цифр");
            }
        }

        private void textBoxLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ValidateHelper.ValidateLogin(textBoxLogin.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxLogin, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxLogin, "Такой логин уже существует");
            }
        }
    }
}
