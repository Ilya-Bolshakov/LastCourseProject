﻿namespace CourseProject.Forms.UserControls.User
{
    partial class DetailUserVisits
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
            this.buttonAddService = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(478, 360);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(134, 51);
            this.buttonAddService.TabIndex = 19;
            this.buttonAddService.Text = "Добавить услугу в посещение";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(473, 94);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(75, 29);
            this.labelFilter.TabIndex = 17;
            this.labelFilter.Text = "Фильтр";
            // 
            // labelVisit
            // 
            this.labelVisit.AutoSize = true;
            this.labelVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisit.Location = new System.Drawing.Point(12, 10);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(51, 20);
            this.labelVisit.TabIndex = 16;
            this.labelVisit.Text = "label1";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Location = new System.Drawing.Point(478, 137);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(159, 20);
            this.textBoxFilterName.TabIndex = 21;
            this.textBoxFilterName.TextChanged += new System.EventHandler(this.textBoxFilterName_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 94);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(443, 245);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(325, 360);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(134, 51);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Убрать услугу из посещения";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DetailUserVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelVisit);
            this.Name = "DetailUserVisits";
            this.Size = new System.Drawing.Size(671, 446);
            this.Load += new System.EventHandler(this.DetailUserVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Button buttonAddService;
        public System.Windows.Forms.Button buttonDelete;
    }
}
