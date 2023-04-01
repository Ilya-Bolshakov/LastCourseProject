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

namespace CourseProject.Forms.EmployeeForms
{
    public partial class AddVisit : Form
    {
        public VisitDto Visit { get; set; }
        public AddVisit()
        {
            InitializeComponent();
            Visit = new VisitDto();
        }
        public AddVisit(VisitDto visit)
        {
            InitializeComponent();
            Visit = visit;
            dateTimePickerStart.Value = Visit.Start;
            if (Visit.Finish == null)
            {
               dateTimePickerFinish.Enabled = false;
               checkBox.Checked = true;
            }
            else
            {
                dateTimePickerFinish.Value = Visit.Finish.Value;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFinish.Enabled = !checkBox.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Visit.Start = dateTimePickerStart.Value;
            if (!checkBox.Checked)
            {
                Visit.Finish = dateTimePickerFinish.Value;
            }
            else
            {
                Visit.Finish = null;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerFinish.MinDate = dateTimePickerStart.Value;
        }
    }
}
