namespace CourseProject.Forms
{
    partial class UserForm
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
            this.buttonVisits = new System.Windows.Forms.Button();
            this.flowLayoutPanelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(306, 7);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(895, 597);
            this.flowLayoutPanelMain.TabIndex = 5;
            // 
            // flowLayoutPanelNav
            // 
            this.flowLayoutPanelNav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelNav.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelNav.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanelNav.Controls.Add(this.buttonProfile);
            this.flowLayoutPanelNav.Controls.Add(this.buttonUsers);
            this.flowLayoutPanelNav.Controls.Add(this.buttonVisits);
            this.flowLayoutPanelNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelNav.Location = new System.Drawing.Point(1, 5);
            this.flowLayoutPanelNav.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelNav.Name = "flowLayoutPanelNav";
            this.flowLayoutPanelNav.Size = new System.Drawing.Size(300, 599);
            this.flowLayoutPanelNav.TabIndex = 4;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(3, 2);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(297, 79);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(3, 85);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(297, 62);
            this.buttonUsers.TabIndex = 1;
            this.buttonUsers.Text = "Бронирование";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonVisits
            // 
            this.buttonVisits.Location = new System.Drawing.Point(3, 151);
            this.buttonVisits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVisits.Name = "buttonVisits";
            this.buttonVisits.Size = new System.Drawing.Size(297, 91);
            this.buttonVisits.TabIndex = 2;
            this.buttonVisits.Text = "История посещений";
            this.buttonVisits.UseVisualStyleBackColor = true;
            this.buttonVisits.Click += new System.EventHandler(this.buttonVisits_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 609);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.flowLayoutPanelNav);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.flowLayoutPanelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNav;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonVisits;
    }
}