using CourseProject.DTO;
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
            DialogResult = DialogResult.OK;
            Service.Name = textBoxName.Text;
            Service.Price = Convert.ToDecimal(textBoxPrice.Text);
            Service.Description = textBoxDesc.Text;
            Close();
        }
    }
}
