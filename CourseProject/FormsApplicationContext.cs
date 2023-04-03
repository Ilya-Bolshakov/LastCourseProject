using CourseProject.DAL;
using CourseProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public class FormsApplicationContext : ApplicationContext
    {
        public FormsApplicationContext()
        {
            var loadPage = new LoadPage();
            loadPage.Show();
        }
    }
}
