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

namespace CourseProject.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            this.CloseApp = false;
            this.Close();
            var regform = new RegisterForm();
            regform.Show();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var user = AccountHelper.Login(textBoxLogin.Text, textBoxPassword.Text);
            if (user != null)
            {
                try
                {
                    var form = new FormsCreator().GetInstance(user);
                    this.CloseApp = false;
                    this.Close();

                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
