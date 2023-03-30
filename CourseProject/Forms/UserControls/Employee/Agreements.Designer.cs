namespace CourseProject.Forms.UserControls.Employee
{
    partial class Agreements
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
            this.buttonAddAgreement = new System.Windows.Forms.Button();
            this.listBoxAgreements = new System.Windows.Forms.ListBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddAgreement
            // 
            this.buttonAddAgreement.Location = new System.Drawing.Point(460, 342);
            this.buttonAddAgreement.Name = "buttonAddAgreement";
            this.buttonAddAgreement.Size = new System.Drawing.Size(134, 51);
            this.buttonAddAgreement.TabIndex = 14;
            this.buttonAddAgreement.Text = "Новый договор";
            this.buttonAddAgreement.UseVisualStyleBackColor = true;
            // 
            // listBoxAgreements
            // 
            this.listBoxAgreements.FormattingEnabled = true;
            this.listBoxAgreements.Location = new System.Drawing.Point(1, 120);
            this.listBoxAgreements.Name = "listBoxAgreements";
            this.listBoxAgreements.Size = new System.Drawing.Size(638, 199);
            this.listBoxAgreements.TabIndex = 13;
            this.listBoxAgreements.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAgreements_MouseDoubleClick);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(51, 40);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(60, 24);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "label1";
            // 
            // Agreements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddAgreement);
            this.Controls.Add(this.listBoxAgreements);
            this.Controls.Add(this.labelUser);
            this.Name = "Agreements";
            this.Size = new System.Drawing.Size(641, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAgreement;
        private System.Windows.Forms.ListBox listBoxAgreements;
        private System.Windows.Forms.Label labelUser;
    }
}
