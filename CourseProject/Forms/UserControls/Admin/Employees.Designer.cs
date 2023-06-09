﻿namespace CourseProject.Forms.UserControls.Admin
{
    partial class Employees
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(2, 2);
            this.listBoxEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(360, 329);
            this.listBoxEmployees.TabIndex = 0;
            this.listBoxEmployees.SelectedValueChanged += new System.EventHandler(this.listBoxEmployees_SelectedValueChanged);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(424, 376);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(105, 58);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(418, 19);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(90, 34);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Фильтр";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFilterName.Enabled = false;
            this.textBoxFilterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterName.Location = new System.Drawing.Point(367, 67);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(188, 29);
            this.textBoxFilterName.TabIndex = 4;
            this.textBoxFilterName.TextChanged += new System.EventHandler(this.textBoxFilterName_TextChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(284, 376);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(95, 58);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редактировать сотрудника";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.listBoxEmployees);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(607, 463);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Button buttonEdit;
    }
}
