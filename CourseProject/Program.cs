using CourseProject.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                FormsApplicationContext context = new FormsApplicationContext();
                AppProperties.Run(context);
            }
            catch (Exception)
            {
                MessageBox.Show("В ходе приложения возникла неизвестная ошибка");
            }
            
        }
    }
}
