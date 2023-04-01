namespace CourseProject.Forms.Admin
{
    partial class AddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.labelEmploymentDate = new System.Windows.Forms.Label();
            this.dateTimePickerEmplument = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.comboBoxwork = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonFemale.Location = new System.Drawing.Point(647, 160);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(108, 24);
            this.radioButtonFemale.TabIndex = 49;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Женщина";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMale.Location = new System.Drawing.Point(647, 105);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(104, 24);
            this.radioButtonMale.TabIndex = 48;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мужчина";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(291, 311);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(249, 26);
            this.textBoxPhone.TabIndex = 47;
            this.textBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhone_Validating);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(97, 311);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(160, 20);
            this.labelPhone.TabIndex = 46;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(97, 265);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(146, 20);
            this.labelDateOfBirth.TabIndex = 45;
            this.labelDateOfBirth.Text = "Дата рождения:";
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(291, 265);
            this.dateTimePickerDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateOfBirth.TabIndex = 44;
            // 
            // textBoxPassport
            // 
            this.textBoxPassport.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassport.Location = new System.Drawing.Point(291, 229);
            this.textBoxPassport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(249, 23);
            this.textBoxPassport.TabIndex = 43;
            this.textBoxPassport.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassport_Validating);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(291, 185);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(249, 23);
            this.textBoxPatronymic.TabIndex = 42;
            this.textBoxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPatronymic_Validating);
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassport.Location = new System.Drawing.Point(97, 230);
            this.labelPassport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(187, 20);
            this.labelPassport.TabIndex = 41;
            this.labelPassport.Text = "Паспортные данные:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(97, 186);
            this.labelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(96, 20);
            this.labelPatronymic.TabIndex = 40;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(291, 143);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(249, 23);
            this.textBoxSurname.TabIndex = 39;
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSurname_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(291, 100);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(249, 23);
            this.textBoxName.TabIndex = 38;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(97, 144);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(92, 20);
            this.labelSurname.TabIndex = 37;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(97, 107);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 20);
            this.labelName.TabIndex = 36;
            this.labelName.Text = "Имя:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(491, 506);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(199, 69);
            this.buttonRegister.TabIndex = 35;
            this.buttonRegister.Text = "Зарегистрировать";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(491, 453);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(249, 23);
            this.textBoxPassword.TabIndex = 34;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(491, 410);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(249, 23);
            this.textBoxLogin.TabIndex = 33;
            this.textBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLogin_Validating);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(381, 458);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 20);
            this.labelPassword.TabIndex = 32;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(381, 415);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 20);
            this.labelLogin.TabIndex = 31;
            this.labelLogin.Text = "Логин:";
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.Location = new System.Drawing.Point(520, 11);
            this.labelReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(117, 20);
            this.labelReg.TabIndex = 30;
            this.labelReg.Text = "Регистрация";
            // 
            // labelEmploymentDate
            // 
            this.labelEmploymentDate.AutoSize = true;
            this.labelEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmploymentDate.Location = new System.Drawing.Point(599, 230);
            this.labelEmploymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmploymentDate.Name = "labelEmploymentDate";
            this.labelEmploymentDate.Size = new System.Drawing.Size(208, 20);
            this.labelEmploymentDate.TabIndex = 51;
            this.labelEmploymentDate.Text = "Дата трудоустройства:";
            // 
            // dateTimePickerEmplument
            // 
            this.dateTimePickerEmplument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEmplument.Location = new System.Drawing.Point(845, 230);
            this.dateTimePickerEmplument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerEmplument.Name = "dateTimePickerEmplument";
            this.dateTimePickerEmplument.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEmplument.TabIndex = 50;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddress.Location = new System.Drawing.Point(796, 279);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(249, 26);
            this.textBoxAddress.TabIndex = 53;
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAddress_Validating);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(599, 283);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(67, 20);
            this.labelAddress.TabIndex = 52;
            this.labelAddress.Text = "Адрес:";
            // 
            // comboBoxwork
            // 
            this.comboBoxwork.FormattingEnabled = true;
            this.comboBoxwork.Location = new System.Drawing.Point(885, 340);
            this.comboBoxwork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxwork.Name = "comboBoxwork";
            this.comboBoxwork.Size = new System.Drawing.Size(160, 24);
            this.comboBoxwork.TabIndex = 54;
            this.comboBoxwork.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxwork_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 590);
            this.Controls.Add(this.comboBoxwork);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmploymentDate);
            this.Controls.Add(this.dateTimePickerEmplument);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelReg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelEmploymentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmplument;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.ComboBox comboBoxwork;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}