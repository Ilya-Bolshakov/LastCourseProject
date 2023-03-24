using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Forms
{
    public partial class BaseForm : Form
    {
        public bool CloseApp { get; set; }
        public BaseForm()
        {
            InitializeComponent();
            CloseApp = true;
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseApp)
            {
                AppProperties.Close();
            }
        }
    }
}
