namespace CourseProject.Forms.EmployeeForms
{
    partial class AddServiceToVisit
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
            this.components = new System.ComponentModel.Container();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.labelService = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(281, 85);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(160, 24);
            this.comboBox.TabIndex = 0;
            this.comboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
            this.comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(183, 89);
            this.labelService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(56, 16);
            this.labelService.TabIndex = 1;
            this.labelService.Text = "Услуга:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(281, 240);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 50);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Подтвердить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddServiceToVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 338);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.comboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddServiceToVisit";
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.AddServiceToVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}