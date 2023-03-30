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
            this.textBoxFilterDate = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.listBoxVisits = new System.Windows.Forms.ListBox();
            this.buttonAddVisit = new System.Windows.Forms.Button();
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
            // textBoxFilterDate
            // 
            this.textBoxFilterDate.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFilterDate.Enabled = false;
            this.textBoxFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterDate.Location = new System.Drawing.Point(462, 58);
            this.textBoxFilterDate.Name = "textBoxFilterDate";
            this.textBoxFilterDate.Size = new System.Drawing.Size(188, 22);
            this.textBoxFilterDate.TabIndex = 8;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(521, 16);
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
            this.listBoxVisits.Size = new System.Drawing.Size(665, 264);
            this.listBoxVisits.TabIndex = 9;
            // 
            // buttonAddVisit
            // 
            this.buttonAddVisit.Location = new System.Drawing.Point(462, 402);
            this.buttonAddVisit.Name = "buttonAddVisit";
            this.buttonAddVisit.Size = new System.Drawing.Size(134, 51);
            this.buttonAddVisit.TabIndex = 10;
            this.buttonAddVisit.Text = "Новое посещение";
            this.buttonAddVisit.UseVisualStyleBackColor = true;
            this.buttonAddVisit.Click += new System.EventHandler(this.buttonAddVisit_Click);
            // 
            // DetailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddVisit);
            this.Controls.Add(this.listBoxVisits);
            this.Controls.Add(this.textBoxFilterDate);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelUser);
            this.Name = "DetailUser";
            this.Size = new System.Drawing.Size(671, 485);
            this.Load += new System.EventHandler(this.DetailUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxFilterDate;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ListBox listBoxVisits;
        private System.Windows.Forms.Button buttonAddVisit;
    }
}
