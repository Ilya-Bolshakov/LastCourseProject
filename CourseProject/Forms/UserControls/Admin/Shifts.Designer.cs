namespace CourseProject.Forms.UserControls.Admin
{
    partial class Shifts
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
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonAddShift = new System.Windows.Forms.Button();
            this.listBoxShifts = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(416, 17);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(90, 34);
            this.labelFilter.TabIndex = 8;
            this.labelFilter.Text = "Фильтр";
            // 
            // buttonAddShift
            // 
            this.buttonAddShift.Location = new System.Drawing.Point(405, 357);
            this.buttonAddShift.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddShift.Name = "buttonAddShift";
            this.buttonAddShift.Size = new System.Drawing.Size(105, 58);
            this.buttonAddShift.TabIndex = 7;
            this.buttonAddShift.Text = "Создать смену";
            this.buttonAddShift.UseVisualStyleBackColor = true;
            // 
            // listBoxShifts
            // 
            this.listBoxShifts.FormattingEnabled = true;
            this.listBoxShifts.Location = new System.Drawing.Point(0, 0);
            this.listBoxShifts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxShifts.Name = "listBoxShifts";
            this.listBoxShifts.Size = new System.Drawing.Size(360, 329);
            this.listBoxShifts.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(365, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAddShift);
            this.Controls.Add(this.listBoxShifts);
            this.Name = "Shifts";
            this.Size = new System.Drawing.Size(734, 553);
            this.Load += new System.EventHandler(this.Shifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonAddShift;
        private System.Windows.Forms.ListBox listBoxShifts;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
