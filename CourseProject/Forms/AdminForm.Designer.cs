namespace CourseProject.Forms
{
    partial class AdminForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelNav = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonShifts = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelNav
            // 
            this.flowLayoutPanelNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelNav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanelNav.Controls.Add(this.buttonEmployees);
            this.flowLayoutPanelNav.Controls.Add(this.buttonShifts);
            this.flowLayoutPanelNav.Controls.Add(this.buttonServices);
            this.flowLayoutPanelNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelNav.Location = new System.Drawing.Point(3, 4);
            this.flowLayoutPanelNav.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelNav.Name = "flowLayoutPanelNav";
            this.flowLayoutPanelNav.Size = new System.Drawing.Size(300, 535);
            this.flowLayoutPanelNav.TabIndex = 0;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(3, 3);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(297, 79);
            this.buttonEmployees.TabIndex = 0;
            this.buttonEmployees.Text = "Сотрудники";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonShifts
            // 
            this.buttonShifts.Location = new System.Drawing.Point(3, 88);
            this.buttonShifts.Name = "buttonShifts";
            this.buttonShifts.Size = new System.Drawing.Size(297, 62);
            this.buttonShifts.TabIndex = 1;
            this.buttonShifts.Text = "Смены";
            this.buttonShifts.UseVisualStyleBackColor = true;
            this.buttonShifts.Click += new System.EventHandler(this.buttonShifts_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.Location = new System.Drawing.Point(3, 156);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(297, 91);
            this.buttonServices.TabIndex = 2;
            this.buttonServices.Text = "Услуги";
            this.buttonServices.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(309, 4);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(756, 544);
            this.flowLayoutPanelMain.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.flowLayoutPanelNav);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminForm";
            this.Text = "Form";
            this.flowLayoutPanelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNav;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonShifts;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
    }
}

