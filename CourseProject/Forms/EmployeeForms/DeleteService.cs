using CourseProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms.EmployeeForms
{
    public partial class DeleteService : Form
    {
        public int Count { get; set; }
        public DeleteService()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Count = int.Parse(textBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateNumber(textBox.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBox, null);
            }
            else
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider.SetError(textBox, errorMessage);
            }
        }
    }
}
