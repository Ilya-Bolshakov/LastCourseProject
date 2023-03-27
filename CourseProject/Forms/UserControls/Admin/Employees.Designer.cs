namespace CourseProject.Forms.UserControls.Admin
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
            this.SuspendLayout();
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(3, 3);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(479, 404);
            this.listBoxEmployees.TabIndex = 0;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(543, 442);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(140, 71);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(557, 23);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(107, 41);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Фильтр";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFilterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterName.Location = new System.Drawing.Point(489, 82);
            this.textBoxFilterName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(249, 34);
            this.textBoxFilterName.TabIndex = 4;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.listBoxEmployees);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(756, 544);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxFilterName;
    }
}
