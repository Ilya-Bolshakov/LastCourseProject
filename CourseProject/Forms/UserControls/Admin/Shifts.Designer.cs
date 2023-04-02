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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(405, 15);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(90, 34);
            this.labelFilter.TabIndex = 8;
            this.labelFilter.Text = "Фильтр";
            // 
            // buttonAddShift
            // 
            this.buttonAddShift.Location = new System.Drawing.Point(386, 329);
            this.buttonAddShift.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddShift.Name = "buttonAddShift";
            this.buttonAddShift.Size = new System.Drawing.Size(111, 52);
            this.buttonAddShift.TabIndex = 7;
            this.buttonAddShift.Text = "Создать смену";
            this.buttonAddShift.UseVisualStyleBackColor = true;
            this.buttonAddShift.Click += new System.EventHandler(this.buttonAddShift_Click);
            // 
            // listBoxShifts
            // 
            this.listBoxShifts.FormattingEnabled = true;
            this.listBoxShifts.HorizontalScrollbar = true;
            this.listBoxShifts.Location = new System.Drawing.Point(0, 0);
            this.listBoxShifts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxShifts.Name = "listBoxShifts";
            this.listBoxShifts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxShifts.ScrollAlwaysVisible = true;
            this.listBoxShifts.Size = new System.Drawing.Size(349, 303);
            this.listBoxShifts.TabIndex = 6;
            this.listBoxShifts.SelectedValueChanged += new System.EventHandler(this.listBoxShifts_SelectedValueChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(238, 329);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(111, 52);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(367, 67);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAddShift);
            this.Controls.Add(this.listBoxShifts);
            this.Name = "Shifts";
            this.Size = new System.Drawing.Size(593, 437);
            this.Load += new System.EventHandler(this.Shifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Button buttonAddShift;
        private System.Windows.Forms.ListBox listBoxShifts;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}
