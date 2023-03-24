using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public static class AppProperties
    {
        public static void Run(FormsApplicationContext context)
        {
            Application.Run(context);
        }

        public static void Close()
        {
            Application.Exit();
        }
    }
}
