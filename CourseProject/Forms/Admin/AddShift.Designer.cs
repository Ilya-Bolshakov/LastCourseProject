﻿namespace CourseProject.Forms.Admin
{
    partial class AddShift
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
            this.labelAdmin = new System.Windows.Forms.Label();
            this.comboBoxAdmin = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxFirstC = new System.Windows.Forms.ComboBox();
            this.labelFirstC = new System.Windows.Forms.Label();
            this.comboBoxSecondC = new System.Windows.Forms.ComboBox();
            this.labelSecondC = new System.Windows.Forms.Label();
            this.comboBoxThirdC = new System.Windows.Forms.ComboBox();
            this.labelThirdC = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(273, 46);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(110, 16);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Администратор";
            // 
            // comboBoxAdmin
            // 
            this.comboBoxAdmin.FormattingEnabled = true;
            this.comboBoxAdmin.Location = new System.Drawing.Point(445, 46);
            this.comboBoxAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAdmin.Name = "comboBoxAdmin";
            this.comboBoxAdmin.Size = new System.Drawing.Size(160, 24);
            this.comboBoxAdmin.TabIndex = 1;
            this.comboBoxAdmin.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxAdmin_Validating);
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(445, 92);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEmployee.TabIndex = 3;
            this.comboBoxEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEmployee_Validating);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(273, 92);
            this.labelEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(154, 16);
            this.labelEmployee.TabIndex = 2;
            this.labelEmployee.Text = "Сотрудник рецепшена";
            // 
            // comboBoxFirstC
            // 
            this.comboBoxFirstC.FormattingEnabled = true;
            this.comboBoxFirstC.Location = new System.Drawing.Point(445, 143);
            this.comboBoxFirstC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFirstC.Name = "comboBoxFirstC";
            this.comboBoxFirstC.Size = new System.Drawing.Size(160, 24);
            this.comboBoxFirstC.TabIndex = 5;
            this.comboBoxFirstC.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxFirstC_Validating);
            // 
            // labelFirstC
            // 
            this.labelFirstC.AutoSize = true;
            this.labelFirstC.Location = new System.Drawing.Point(273, 143);
            this.labelFirstC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstC.Name = "labelFirstC";
            this.labelFirstC.Size = new System.Drawing.Size(117, 16);
            this.labelFirstC.TabIndex = 4;
            this.labelFirstC.Text = "Первый уборщик";
            // 
            // comboBoxSecondC
            // 
            this.comboBoxSecondC.FormattingEnabled = true;
            this.comboBoxSecondC.Location = new System.Drawing.Point(445, 190);
            this.comboBoxSecondC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSecondC.Name = "comboBoxSecondC";
            this.comboBoxSecondC.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSecondC.TabIndex = 7;
            this.comboBoxSecondC.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSecondC_Validating);
            // 
            // labelSecondC
            // 
            this.labelSecondC.AutoSize = true;
            this.labelSecondC.Location = new System.Drawing.Point(273, 190);
            this.labelSecondC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecondC.Name = "labelSecondC";
            this.labelSecondC.Size = new System.Drawing.Size(114, 16);
            this.labelSecondC.TabIndex = 6;
            this.labelSecondC.Text = "Второй уборщик";
            // 
            // comboBoxThirdC
            // 
            this.comboBoxThirdC.FormattingEnabled = true;
            this.comboBoxThirdC.Location = new System.Drawing.Point(445, 242);
            this.comboBoxThirdC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxThirdC.Name = "comboBoxThirdC";
            this.comboBoxThirdC.Size = new System.Drawing.Size(160, 24);
            this.comboBoxThirdC.TabIndex = 9;
            this.comboBoxThirdC.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxThirdC_Validating);
            // 
            // labelThirdC
            // 
            this.labelThirdC.AutoSize = true;
            this.labelThirdC.Location = new System.Drawing.Point(273, 242);
            this.labelThirdC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThirdC.Name = "labelThirdC";
            this.labelThirdC.Size = new System.Drawing.Size(114, 16);
            this.labelThirdC.TabIndex = 8;
            this.labelThirdC.Text = "Третий уборщик";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(277, 305);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(653, 366);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(145, 58);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Сохранить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 452);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxThirdC);
            this.Controls.Add(this.labelThirdC);
            this.Controls.Add(this.comboBoxSecondC);
            this.Controls.Add(this.labelSecondC);
            this.Controls.Add(this.comboBoxFirstC);
            this.Controls.Add(this.labelFirstC);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxAdmin);
            this.Controls.Add(this.labelAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddShift";
            this.Text = "AddShift";
            this.Load += new System.EventHandler(this.AddShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.ComboBox comboBoxAdmin;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxFirstC;
        private System.Windows.Forms.Label labelFirstC;
        private System.Windows.Forms.ComboBox comboBoxSecondC;
        private System.Windows.Forms.Label labelSecondC;
        private System.Windows.Forms.ComboBox comboBoxThirdC;
        private System.Windows.Forms.Label labelThirdC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}