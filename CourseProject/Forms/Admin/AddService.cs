using CourseProject.DTO;
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

namespace CourseProject.Forms.Admin
{
    public partial class AddService : Form
    {
        public ServiceDto Service { get; set; }
        public AddService()
        {
            InitializeComponent();
            Service = new ServiceDto();
        }

        public AddService(ServiceDto service)
        {
            InitializeComponent();
            Service = service;

            textBoxDesc.Text = service.Description;
            textBoxName.Text = service.Name;
            textBoxPrice.Text = service.Price.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Service.Name = textBoxName.Text;
                Service.Price = Convert.ToDecimal(textBoxPrice.Text);
                Service.Description = textBoxDesc.Text;
                Close();
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateServiceName(textBoxName.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxName, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxName, errorMessage);
            }
        }

        private void textBoxPrice_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidatePrice(textBoxPrice.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxPrice, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxPrice, errorMessage);
            }
        }

        private void textBoxDesc_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage = String.Empty;
            if (ValidateHelper.ValidateEmpty(textBoxDesc.Text, ref errorMessage))
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxDesc, null);
            }
            else
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider.SetError(textBoxDesc, errorMessage);
            }
        }
    }
}
