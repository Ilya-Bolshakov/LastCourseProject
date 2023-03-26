﻿using CourseProject.DAL;
using CourseProject.Enums;
using CourseProject.Guards;
using CourseProject.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class RegisterForm : BaseForm
    {
        public RegisterForm()
        {
            InitializeComponent();
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
}
