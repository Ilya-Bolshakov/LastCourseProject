namespace CourseProject.Forms
{
    partial class EmployeeForm
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
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelNav = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonAggreement = new System.Windows.Forms.Button();
            this.flowLayoutPanelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(229, 2);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(671, 485);
            this.flowLayoutPanelMain.TabIndex = 3;
            // 
            // flowLayoutPanelNav
            // 
            this.flowLayoutPanelNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelNav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanelNav.Controls.Add(this.buttonProfile);
            this.flowLayoutPanelNav.Controls.Add(this.buttonUsers);
            this.flowLayoutPanelNav.Controls.Add(this.buttonAggreement);
            this.flowLayoutPanelNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelNav.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNav.Name = "flowLayoutPanelNav";
            this.flowLayoutPanelNav.Size = new System.Drawing.Size(225, 487);
            this.flowLayoutPanelNav.TabIndex = 2;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(2, 2);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(223, 64);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(2, 70);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(223, 50);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Клиенты";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonAggreement
            // 
            this.buttonAggreement.Location = new System.Drawing.Point(2, 124);
            this.buttonAggreement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAggreement.Name = "buttonAggreement";
            this.buttonAggreement.Size = new System.Drawing.Size(223, 74);
            this.buttonAggreement.TabIndex = 2;
            this.buttonAggreement.Text = "Бронирование";
            this.buttonAggreement.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 495);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.flowLayoutPanelNav);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.flowLayoutPanelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNav;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonAggreement;
    }
}