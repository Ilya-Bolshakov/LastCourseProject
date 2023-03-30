namespace CourseProject.Forms.UserControls.Employee
{
    partial class DetailUser
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.listBoxVisits = new System.Windows.Forms.ListBox();
            this.buttonAddVisit = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(53, 39);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 24);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "label1";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(477, 17);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(75, 29);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "Фильтр";
            // 
            // listBoxVisits
            // 
            this.listBoxVisits.FormattingEnabled = true;
            this.listBoxVisits.Location = new System.Drawing.Point(3, 119);
            this.listBoxVisits.Name = "listBoxVisits";
            this.listBoxVisits.Size = new System.Drawing.Size(638, 199);
            this.listBoxVisits.TabIndex = 9;
            this.listBoxVisits.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxVisits_MouseDoubleClick);
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(462, 341);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(134, 51);
            this.buttonAddVisit.TabIndex = 10;
            this.buttonAddVisit.Text = "Новое посещение";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(308, 341);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 51);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(409, 44);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 12;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Location = new System.Drawing.Point(409, 82);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFinish.TabIndex = 13;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(360, 48);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(14, 13);
            this.labelStart.TabIndex = 14;
            this.labelStart.Text = "С";
            // 
            // labelFinish
            // 
            this.labelFinish.AutoSize = true;
            this.labelFinish.Location = new System.Drawing.Point(360, 88);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(21, 13);
            this.labelFinish.TabIndex = 15;
            this.labelFinish.Text = "По";
            // 
            // DetailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFinish);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAddVisit);
            this.Controls.Add(this.listBoxVisits);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelUser);
            this.Name = "DetailUser";
            this.Size = new System.Drawing.Size(671, 446);
            this.Load += new System.EventHandler(this.DetailUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ListBox listBoxVisits;
        private System.Windows.Forms.Button buttonAddVisit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelFinish;
    }
}
