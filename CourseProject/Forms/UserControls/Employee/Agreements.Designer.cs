namespace CourseProject.Forms.UserControls.User
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
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddAgreement
            // 
            this.buttonAddAgreement.Location = new System.Drawing.Point(613, 421);
            this.buttonAddAgreement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddAgreement.Name = "buttonAddAgreement";
            this.buttonAddAgreement.Size = new System.Drawing.Size(179, 63);
            this.buttonAddAgreement.TabIndex = 14;
            this.buttonAddAgreement.Text = "Новый договор";
            this.buttonAddAgreement.UseVisualStyleBackColor = true;
            this.buttonAddAgreement.Click += new System.EventHandler(this.buttonAddAgreement_Click);
            // 
            // listBoxAgreements
            // 
            this.listBoxAgreements.FormattingEnabled = true;
            this.listBoxAgreements.ItemHeight = 16;
            this.listBoxAgreements.Location = new System.Drawing.Point(1, 148);
            this.listBoxAgreements.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAgreements.Name = "listBoxAgreements";
            this.listBoxAgreements.Size = new System.Drawing.Size(849, 244);
            this.listBoxAgreements.TabIndex = 13;
            this.listBoxAgreements.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAgreements_MouseDoubleClick);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUser.Location = new System.Drawing.Point(68, 49);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(79, 29);
            this.labelUser.TabIndex = 12;
            this.labelUser.Text = "label1";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxFilterName.Enabled = false;
            this.textBoxFilterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFilterName.Location = new System.Drawing.Point(544, 80);
            this.textBoxFilterName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(249, 26);
            this.textBoxFilterName.TabIndex = 16;
            this.textBoxFilterName.TextChanged += new System.EventHandler(this.textBoxFilterName_TextChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(623, 28);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(90, 36);
            this.labelFilter.TabIndex = 15;
            this.labelFilter.Text = "Фильтр";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(383, 421);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(179, 63);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Agreements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxFilterName);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonAddAgreement);
            this.Controls.Add(this.listBoxAgreements);
            this.Controls.Add(this.labelUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Agreements";
            this.Size = new System.Drawing.Size(855, 533);
            this.Load += new System.EventHandler(this.Agreements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAgreement;
        private System.Windows.Forms.ListBox listBoxAgreements;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxFilterName;
        private System.Windows.Forms.Label labelFilter;
        public System.Windows.Forms.Button buttonEdit;
    }
}
