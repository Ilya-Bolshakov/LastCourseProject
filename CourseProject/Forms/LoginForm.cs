﻿using System;
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
    }
}