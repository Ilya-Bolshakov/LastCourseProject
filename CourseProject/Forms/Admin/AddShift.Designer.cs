namespace CourseProject.Forms.Admin
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
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(205, 37);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(86, 13);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Администратор";
            // 
            // comboBoxAdmin
            // 
            this.comboBoxAdmin.FormattingEnabled = true;
            this.comboBoxAdmin.Location = new System.Drawing.Point(334, 37);
            this.comboBoxAdmin.Name = "comboBoxAdmin";
            this.comboBoxAdmin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdmin.TabIndex = 1;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(334, 75);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 3;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(205, 75);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(119, 13);
            this.labelEmployee.TabIndex = 2;
            this.labelEmployee.Text = "Сотрудник рецепшена";
            // 
            // comboBoxFirstC
            // 
            this.comboBoxFirstC.FormattingEnabled = true;
            this.comboBoxFirstC.Location = new System.Drawing.Point(334, 116);
            this.comboBoxFirstC.Name = "comboBoxFirstC";
            this.comboBoxFirstC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFirstC.TabIndex = 5;
            // 
            // labelFirstC
            // 
            this.labelFirstC.AutoSize = true;
            this.labelFirstC.Location = new System.Drawing.Point(205, 116);
            this.labelFirstC.Name = "labelFirstC";
            this.labelFirstC.Size = new System.Drawing.Size(94, 13);
            this.labelFirstC.TabIndex = 4;
            this.labelFirstC.Text = "Первый уборщик";
            // 
            // comboBoxSecondC
            // 
            this.comboBoxSecondC.FormattingEnabled = true;
            this.comboBoxSecondC.Location = new System.Drawing.Point(334, 154);
            this.comboBoxSecondC.Name = "comboBoxSecondC";
            this.comboBoxSecondC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSecondC.TabIndex = 7;
            // 
            // labelSecondC
            // 
            this.labelSecondC.AutoSize = true;
            this.labelSecondC.Location = new System.Drawing.Point(205, 154);
            this.labelSecondC.Name = "labelSecondC";
            this.labelSecondC.Size = new System.Drawing.Size(90, 13);
            this.labelSecondC.TabIndex = 6;
            this.labelSecondC.Text = "Второй уборщик";
            // 
            // comboBoxThirdC
            // 
            this.comboBoxThirdC.FormattingEnabled = true;
            this.comboBoxThirdC.Location = new System.Drawing.Point(334, 197);
            this.comboBoxThirdC.Name = "comboBoxThirdC";
            this.comboBoxThirdC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxThirdC.TabIndex = 9;
            // 
            // labelThirdC
            // 
            this.labelThirdC.AutoSize = true;
            this.labelThirdC.Location = new System.Drawing.Point(205, 197);
            this.labelThirdC.Name = "labelThirdC";
            this.labelThirdC.Size = new System.Drawing.Size(90, 13);
            this.labelThirdC.TabIndex = 8;
            this.labelThirdC.Text = "Третий уборщик";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(490, 297);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(109, 47);
            this.buttonConfirm.TabIndex = 11;
            this.buttonConfirm.Text = "Сохранить";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // AddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 367);
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
            this.Name = "AddShift";
            this.Text = "AddShift";
            this.Load += new System.EventHandler(this.AddShift_Load);
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
    }
}