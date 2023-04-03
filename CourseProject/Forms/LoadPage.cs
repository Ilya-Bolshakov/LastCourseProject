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
    public partial class LoadPage : BaseForm
    {
        public LoadPage()
        {
            InitializeComponent();
            timer.Start();
            CloseApp = false;
            pictureBox1.Image = new Bitmap("biznes-it-tehnologii-internet.jpg");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            var loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }
    }
}
