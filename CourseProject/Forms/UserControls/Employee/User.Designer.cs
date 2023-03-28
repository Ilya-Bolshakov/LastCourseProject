namespace CourseProject.Forms.UserControls.Employee
{
    partial class User
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
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFilterName.Enabled = false;
            this.textBoxFilterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterName.Location = new System.Drawing.Point(424, 49);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(188, 22);
            this.textBoxFilterName.TabIndex = 6;
            this.textBoxFilterName.TextChanged += new System.EventHandler(this.textBoxFilterName_TextChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(482, 17);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(75, 29);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Фильтр";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(3, 94);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(644, 251);
            this.listBoxUsers.TabIndex = 7;
            this.listBoxUsers.SelectedValueChanged += new System.EventHandler(this.listBoxUsers_SelectedValueChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilter);
            this.Name = "User";
            this.Size = new System.Drawing.Size(650, 445);
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ListBox listBoxUsers;
    }
}
